﻿using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using EPLE.Core.Threading;
using EPLE.Core;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Management;

namespace EPLE.App
{
    public partial class Engine
    {
        private string _configFilePath;
        private string _dbFilePath;
        private string _recipeFolderPath;
        private string _currentRecipe;
        private DataManager _dataManager;
        private FunctionManager _functionManager;
        private LocationManager _locationManager;
        private UserAuthorityManager _userAuthorityManager;
        private AlarmManager _alarmManager;
        private InterlockManager _interlockManager;
        private WorkQueue _workQueue;
        private ShelfInfoManager _shelfInfoManager;
        private int[] stats;
        private TimeSpan refreshInterval;
        private DateTime nextRefreshTime;
        private List<Process> managedProcess;

        private bool _isRunResetCheck;

        //private Thread _resetCheckThread;
        private Task _resetCheckTask;

        public static readonly Engine Instance = new Engine();

        public string ConfigFilePath { set { _configFilePath = value; } }
        public string DbFilePath { set { _dbFilePath = value; } }

        public string RecipeFolderPath { set { _recipeFolderPath = value; } }
        public string CurrentRecipe { get { return _currentRecipe; } set { _currentRecipe = value; } }

        private Engine()
        {

        }



        public void Inialize()
        {
            List<string> localIPs = GetLocalIPAddress(0);

            ObjectQuery oq = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher query1 = new ManagementObjectSearcher(oq);

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            string getEquipmentInfo = @"SELECT * FROM master_equipment";
            DataTable eqpData = DbHandler.Instance.ExecuteQuery(_dbFilePath, getEquipmentInfo);

            var eqpInfo = (from m in eqpData.AsEnumerable() select m).FirstOrDefault();

            if (eqpInfo != null)
            {
                DataRow dr = eqpInfo as DataRow;//bool macAddressNotFound = true;
                                                //bool ipAddressNotFound = true;

                CommonData.Instance.EQP_SETTINGS.EQPID = dr["EQPID"] as string;//foreach (NetworkInterface adapter in adapters)
                CommonData.Instance.EQP_SETTINGS.EQPNAME = dr["EQPNAME"] as string;//{
                CommonData.Instance.EQP_SETTINGS.IPADDRESS = dr["IPADDRESS"] as string;//    PhysicalAddress pa = adapter.GetPhysicalAddress();
                CommonData.Instance.EQP_SETTINGS.MACADDRESS = dr["MACADDRESS"] as string;
                CommonData.Instance.EQP_SETTINGS.EQP_SW_VERSION = dr["EQP_SW_VERSION"] as string;//    CommonData.Instance.EQP_SETTINGS.MACADDRESS = pa.ToString();
                CommonData.Instance.EQP_SETTINGS.MACADDRESS = dr["MACADDRESS"] as string;//    if (string.IsNullOrEmpty(CommonData.Instance.EQP_SETTINGS.MACADDRESS)) continue;
                string simulation_mode = dr["SIMULATION_MODE"] as string;
                if (simulation_mode.Substring(0, 1).ToUpper().Equals("Y")) CommonData.Instance.EQP_SETTINGS.SIMULATION_MODE = true;
                else CommonData.Instance.EQP_SETTINGS.SIMULATION_MODE = false;
            }

            managedProcess = new List<Process>();
        }

        private void ResetCheckThreadStart()
        {
            if (_isRunResetCheck)
                ResetCheckThreadStop();

            _resetCheckTask = new Task(ResetCheckMethod);

            _isRunResetCheck = true;
            _resetCheckTask.Start();
        }

        private void ResetCheckThreadStop()
        {
            if (_isRunResetCheck != false && _resetCheckTask.Status == TaskStatus.Running /*!_resetCheckThread.IsAlive*/)
            {
                _isRunResetCheck = false;

                _resetCheckTask.Wait();
                _resetCheckTask.Dispose();

                return;
            }

            _isRunResetCheck = false;
            _resetCheckTask.Dispose();
            //_resetCheckThread.Join();
            //_resetCheckThread = null;
        }

        private void ResetCheckMethod()
        {
            while (_isRunResetCheck)
            {
                try
                {
                    if (DataManager.Instance.DataAccess == null)
                    {
                        _isRunResetCheck = false;
                        return;
                    }

                    var dataList = DataManager.Instance.DataAccess.RemoteObject.DataList.Where(o => (o.Direction != eDirection.IN
                        && o.DataResetTimeout > 0
                        && !string.IsNullOrEmpty(o.DefaultValue))
                        && o.DataSetTime != null
                        && Environment.TickCount - o.DataSetTime > o.DataResetTimeout).ToList();

                    if (dataList != null && dataList.Count > 0)
                    {
                        foreach (Data data in dataList)
                        {
                            data.DataSetTime = null;


                            switch (data.Type)
                            {
                                case eDataType.Int:
                                    {
                                        DataManager.Instance.SET_INT_DATA(data.Name, Convert.ToInt32(data.DefaultValue));
                                    }
                                    break;
                                case eDataType.Double:
                                    {
                                        DataManager.Instance.SET_DOUBLE_DATA(data.Name, Convert.ToDouble(data.DefaultValue));
                                    }
                                    break;
                                case eDataType.String:
                                    {
                                        DataManager.Instance.SET_STRING_DATA(data.Name, data.DefaultValue);
                                    }
                                    break;
                                case eDataType.Object:
                                    {
                                        DataManager.Instance.SET_DATA(data.Name, data.DefaultValue);
                                    }
                                    break;
                                default:
                                    {
                                        throw new Exception("UNKNOWN DATA TYPE EXCEPTION");
                                    }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Instance.SystemLog.Error(ex.ToString());
                }

                Thread.Sleep(100);
            }
        }


        public void Start()
        {
            stats = new int[6];
            nextRefreshTime = DateTime.Now;
            refreshInterval = TimeSpan.FromSeconds(1.0);

            _alarmManager = AlarmManager.Instance;
            _alarmManager.Initialize(_dbFilePath);
            _alarmManager.SetAlarmEvent += _alarmManager_SetAlarmEvent;
            _alarmManager.ResetAlarmEvent += _alarmManager_ResetAlarmEvent;

            _interlockManager = InterlockManager.Instance;
            _interlockManager.Initialize(_dbFilePath);
            _dataManager = DataManager.Instance;
            _dataManager.Initialize(_configFilePath);
            _dataManager.DataAccess.DataChangedEvent += DataChangedEvent.DataManager_DataChangedEvent;
            _dataManager.DataAccess.DataChangedEvent += DataChangedEvent.DataManager_AlarmChangedEvent;

            _functionManager = FunctionManager.Instance;
            _functionManager.Initialize(_dbFilePath);

            _locationManager = LocationManager.Instance;
            _locationManager.Initialize(_dbFilePath);

            _userAuthorityManager = UserAuthorityManager.Instance;
            _userAuthorityManager.Initialize(@"./config/db_io.mdb");

            _shelfInfoManager = ShelfInfoManager.Instance;
            _shelfInfoManager.Initialize(_dbFilePath);


            _workQueue = WorkQueue.Instance;
            _workQueue.ConcurrentLimit = 10;
            _workQueue.AllWorkCompleted += new EventHandler(work_AllWorkCompleted);
            _workQueue.WorkerException += new ResourceExceptionEventHandler(work_WorkerException);
            _workQueue.ChangedWorkItemState += new ChangedWorkItemStateEventHandler(work_ChangedWorkItemState);

            ResetCheckThreadStart();

            InializeDataOut();

            if (CommonData.Instance.EQP_SETTINGS.SIMULATION_MODE)
            {
                DataManager.Instance.SET_STRING_DATA("vSys.sEqp.SimulationMode", "SIMULATION");
            }
            else
            {
                DataManager.Instance.SET_STRING_DATA("vSys.sEqp.SimulationMode", "NORMAL");
            }
        }

        private void _alarmManager_ResetAlarmEvent(object sender, EventArgs e)
        {
            List<ALARM> currentAlarms = _alarmManager.GetCurrentAlarmAsList();

            if (currentAlarms.FindAll((a) => (a.LEVEL == eALCD.Heavy)).Count > 0)
            {
                return;
            }
            else if (currentAlarms.FindAll((a) => (a.LEVEL == eALCD.Light)).Count > 0)
            {
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Alarm", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Availability", 2);
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Move", 2);

                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);

                InterlockManager.Instance.INTERLOCK_RESET();
            }
            else
            {
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Alarm", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Availability", 2);
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Move", 2);
                //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Interlock", 2);

                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 0);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 1);
                //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.White", 0);

                InterlockManager.Instance.INTERLOCK_RESET();
            }
        }

        private void _alarmManager_SetAlarmEvent(object sender, EventArgs e)
        {
            if (e is AlarmEventArgs)
            {
                AlarmEventArgs args = e as AlarmEventArgs;

                if (args.Alarm.ENABLE == eALED.Enable && args.Alarm.LEVEL == eALCD.Heavy)
                {
                    //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Alarm", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Availability", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iEqp.Move", 1);

                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 0);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                }
                else if (args.Alarm.ENABLE == eALED.Enable && args.Alarm.LEVEL == eALCD.Light)
                {
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Red", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Yellow", 1);
                    //DataManager.Instance.SET_INT_DATA("vSys.iSignalTower.Green", 0);
                }
            }


        }

        public void Stop()
        {
            ResetCheckThreadStop();
            DeviceManager.Instance.DeinitializeDeviceInfo();
        }

        void InializeDataOut()
        {
            var dataList = DataManager.Instance.DataAccess.RemoteObject.DataList.Where(o => (o.Direction == eDirection.OUT && !string.IsNullOrEmpty(o.DefaultValue))).ToList();

            foreach (Data data in dataList)
            {
                //if (data.Module == "TEACHING")
                //    continue;

                data.DataSetTime = null;

                switch (data.Type)
                {
                    case eDataType.Int:
                        {
                            DataManager.Instance.SET_INT_DATA(data.Name, Convert.ToInt32(data.DefaultValue));
                        }
                        break;
                    case eDataType.Double:
                        {
                            DataManager.Instance.SET_DOUBLE_DATA(data.Name, Convert.ToDouble(data.DefaultValue));
                        }
                        break;
                    case eDataType.String:
                        {
                            DataManager.Instance.SET_STRING_DATA(data.Name, data.DefaultValue);
                        }
                        break;
                    case eDataType.Object:
                        {
                            DataManager.Instance.SET_DATA(data.Name, data.DefaultValue);
                        }
                        break;
                    default:
                        {
                            throw new Exception("UNKNOWN DATA TYPE EXCEPTION");
                        }
                }
            }
        }

        public static String getMacAddress(String ipaddress)
        {
            String queryStr = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled='TRUE'";
            ObjectQuery objectQuery = new ObjectQuery(queryStr);
            ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection mos = searcher.Get();

            String macAddress = null;

            foreach (ManagementObject mo in mos)
            {
                if (String.IsNullOrEmpty(ipaddress))
                {
                    macAddress = mo["MACAddress"].ToString();
                    break;
                }
                else
                {
                    String[] address = (String[])mo["IPAddress"];

                    if (ipaddress.Equals(address[0]))
                    {
                        macAddress = mo["MACAddress"].ToString();
                        String transMac = "";
                        String[] macArray = macAddress.Split(':');

                        foreach (String m in macArray)
                        {
                            transMac += m;
                        }


                        macAddress = transMac;
                        break;
                    }
                }
            }
            return macAddress;
        }

        public static String getIpAddress(String macaddress)
        {
            String queryStr = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled='TRUE'";
            ObjectQuery objectQuery = new ObjectQuery(queryStr);
            ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection mos = searcher.Get();

            String IpAddress = null;

            foreach (ManagementObject mo in mos)
            {
                if (String.IsNullOrEmpty(macaddress))
                {
                    String[] address = (String[])mo["IPAddress"];

                    IpAddress = address[0];
                    break;
                }
                else
                {
                    String mac = mo["MACAddress"].ToString();
                    String transMac = "";
                    String[] macArray = mac.Split(':');

                    foreach (String m in macArray)
                    {
                        transMac += m;
                    }

                    if (macaddress.Equals(transMac))
                    {
                        String[] address = (String[])mo["IPAddress"];
                        IpAddress = address[0];
                        break;
                    }
                }
            }
            return IpAddress;
        }

        private List<string> GetLocalIPAddress(int index)
        {
            List<IPAddress> interNetworks = new List<IPAddress>();
            foreach (var item in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork)
                {
                    interNetworks.Add(item);
                }
            }

            List<string> allLocalIpAddress = new List<string>();
            foreach (var item in interNetworks)
                allLocalIpAddress.Add(item.ToString());
            return allLocalIpAddress;
        }


        private void work_AllWorkCompleted(object sender, EventArgs e)
        {
            stats = new int[6];
            RefreshCounts();
        }

        private void work_WorkerException(object sender, ResourceExceptionEventArgs e)
        {
            //Console.WriteLine("Error : {0}", e.Exception.Message);
        }

        private void work_ChangedWorkItemState(object sender, ChangedWorkItemStateEventArgs e)
        {
            lock (this)
            {
                stats[(int)e.PreviousState] -= 1;
                stats[(int)e.WorkItem.State] += 1;
            }

            if (DateTime.Now > nextRefreshTime)
            {
                RefreshCounts();
                nextRefreshTime = DateTime.Now + refreshInterval;
            }
        }

        private void RefreshCounts()
        {

        }
    }
}
