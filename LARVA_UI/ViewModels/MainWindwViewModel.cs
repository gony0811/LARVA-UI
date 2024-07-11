using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.IO;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class MainWindowViewModel
    {
        [GenerateProperty]
        public string statusAccessMode;
        [GenerateProperty]
        public string statusAvailable;
        [GenerateProperty]
        public string statusRunMode;
        [GenerateProperty]
        public string statusAlarm;
        [GenerateProperty]
        public string statusDoorLock;
        [GenerateProperty]
        public string statusJobScheduler;
        [GenerateProperty]
        public string pauseButtonImageUrl;
        [GenerateProperty]
        public string pauseButtonContent;
        [GenerateProperty]
        public bool pauseButtonIsChecked;
        [GenerateProperty]
        public bool pauseButtonEnabled;
        [GenerateProperty]
        public bool abortButtonEnabled;
        [GenerateProperty]
        public bool buzzerOffButtonEnabled;
        [GenerateProperty]
        public bool schedulerButtonEnabled;
        [GenerateProperty]
        public bool schedulerButtonIsChecked;
        [GenerateProperty]
        public string schedulerButtonContent;
        [GenerateProperty]
        private bool emoButtonEnabled;
        [GenerateProperty]
        private Brush background_PLCHeartbeat;
        [GenerateProperty]
        private Brush foreground_PLCHeartbeat;
        [GenerateProperty]
        private string content_PLCHeartbeat;
        [GenerateProperty]
        private Brush background_HMIHeartbeat;
        [GenerateProperty]
        private Brush foreground_HMIHeartbeat;
        [GenerateProperty]
        private string content_HMIHeartbeat;


        public MainWindowViewModel()
        {
            DataManager.Instance.DataAccess.DataChangedEvent += StatusChangedEvent;

            Initialize();
        }

        private void Initialize()
        {
            bool result = false;
            int nVal = 0;

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);
            if (result)
            {
                StatusAccessMode = ConvertAccessModeStatus(nVal);

                if (nVal == (int)eAccessMode.AUTO)
                {
                    SchedulerButtonEnabled = true;
                }
                else
                {
                    SchedulerButtonEnabled = false;
                }
            }
                

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.vSys_nJobScheduler_RunStop, out result);
            if (result) 
                StatusJobScheduler = ConvertJobSchedulerStatus(nVal);

            if (result && nVal == (int)eRunStop.STOP)
            {
                SchedulerButtonContent = "작업 관리자 실행";           
                SchedulerButtonIsChecked = false;
            }

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result);
            if (result)
                StatusAvailable = ConvertAvailbaleStatus(nVal);

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nRun_Status, out result);
            if (result)
                StatusRunMode = ConvertRunStatus(nVal);

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAlarm_Status, out result);
            if (result)
                StatusAlarm = ConvertAlarmStatus(nVal);

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iMain_nDoor_Open, out result);
            if (result)
                StatusDoorLock = ConvertDoorLockStatus(nVal);

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nRun_Status, out result);

            if (result && nVal == (int)eRunStatus.PAUSED)
            {
                PauseButtonEnabled = true;
                PauseButtonIsChecked = true;
                AbortButtonEnabled = true;
                PauseButtonContent = "다시시작";
            }
            else if (result && nVal == (int)eRunStatus.IDLE)
            {
                PauseButtonIsChecked = false;
                PauseButtonEnabled = false;
                AbortButtonEnabled = false;
                PauseButtonContent = "일시정지";
            }
            else
            {
                PauseButtonEnabled = true;
                AbortButtonEnabled = true;
                PauseButtonIsChecked = false;
                PauseButtonContent = "일시정지";
            }

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nPlc_Heartbeat, out result);

            if (result && nVal == (int)eOnOff.ON)
            {
                Background_PLCHeartbeat = Brushes.LightGreen;
                Foreground_PLCHeartbeat = Brushes.Black;
                Content_PLCHeartbeat = "PLC";
            }
            else
            {
                Background_PLCHeartbeat = Brushes.DarkGreen;
                Foreground_PLCHeartbeat = Brushes.Wheat;
                Content_PLCHeartbeat = "PLC";
            }

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oEqp_nHmi_Heartbeat, out result);

            if (result && nVal == (int)eOnOff.ON)
            {
                Background_HMIHeartbeat = Brushes.Red;
                Foreground_HMIHeartbeat = Brushes.Black;
                Content_HMIHeartbeat = "HMI";
            }
            else
            {
                Background_PLCHeartbeat = Brushes.DarkRed;
                Foreground_PLCHeartbeat = Brushes.Wheat;
                Content_PLCHeartbeat = "HMI";
            }
        }

        [GenerateCommand]
        private void EmoButtonClick(RoutedEventArgs args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oMain_nEmo_Stop, true);


            Task.Run(new Action(() => {

                while(true)
                {
                    if (stopwatch.ElapsedMilliseconds >= 1000)
                    {
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oMain_nEmo_Stop, false);
                        return;
                    }
                    Thread.SpinWait(100);
                }
            }));
        }


        [GenerateCommand]
        private void ProgramExit(RoutedEventArgs args)
        {
            EPLE.App.Engine.Instance.Stop();
            Application.Current.Shutdown();         
        }

        [GenerateCommand]
        private void BuzzerOffTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
        }

        [GenerateCommand]
        private void BuzzerOffTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
        }

        [GenerateCommand]
        private void BuzzerOff(RoutedEventArgs args)
        {
            if (args is MouseEventArgs)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)args;

                if (mouseEventArgs.LeftButton == MouseButtonState.Pressed)
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
                }
                else
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
                }
            }
        }

        [GenerateCommand]
        private void SchedulerExecute(bool isChecked)
        {
            if (isChecked)
            {
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.vSys_nJobScheduler_RunStop, true);
            }
            else
            {
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.vSys_nJobScheduler_RunStop, false);
            }
        }

        [GenerateCommand]
        private void ProcessPause(bool isChecked)
        {
            if (isChecked)
            {
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Pause, true);
            }
            else
            {
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Pause, false);
            }

        }


        [GenerateCommand(Name = "AsyncProcessAbortCommand")]
        async Task AsyncProcessAbort()
        {
            DateTime start = DateTime.Now;
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Abort, true);

            while (true)
            {
                TimeSpan elipsed = DateTime.Now - start;

                int runStatus = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nRun_Status, out bool result);

                if (runStatus == (int)eRunStatus.IDLE) 
                    break;

                if (elipsed.Seconds > 10)
                    break;

                await Task.Delay(10);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Abort, false);
        }

        private void StatusChangedEvent(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = e.Data;

            if (data == null || !data.Group.Equals("EQP")) return;


            if (data.Name.Equals(IoNameHelper.iEqp_nAvailable_Status))
            {
                StatusAvailable = ConvertAvailbaleStatus((int)data.Value);
            }
            else if (data.Name.Equals(IoNameHelper.iEqp_nOp_Mode))
            {
                StatusAccessMode = ConvertAccessModeStatus((int)data.Value);
            }
            else if (data.Name.Equals(IoNameHelper.iEqp_nRun_Status))
            {
                StatusRunMode = ConvertRunStatus((int)data.Value);
            }
            else if (data.Name.Equals(IoNameHelper.iEqp_nAlarm_Status))
            {
                StatusAlarm = ConvertAlarmStatus((int)data.Value);
            }
            else if (data.Name.Equals(IoNameHelper.iMain_nDoor_Open))
            {
                StatusDoorLock = ConvertDoorLockStatus((int)data.Value);
            }
            else if (data.Name.Equals(IoNameHelper.vSys_nJobScheduler_RunStop))
            {
                StatusJobScheduler = ConvertJobSchedulerStatus((int)data.Value);
            }
            else if(data.Name.Equals(IoNameHelper.iEqp_nPlc_Heartbeat))
            {             
                ChangePLCHeartbeat((int)data.Value);
            }
        }

        private void ChangePLCHeartbeat(int nVal)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oEqp_nHmi_Heartbeat, nVal);

            if (nVal == (int)eOnOff.ON)
            {
                Background_PLCHeartbeat = Brushes.LightGreen;
                Foreground_PLCHeartbeat = Brushes.Wheat;
                Background_HMIHeartbeat = Brushes.Red;
                Foreground_HMIHeartbeat = Brushes.Wheat;
                Content_PLCHeartbeat =  "PLC";
                Content_HMIHeartbeat = "HMI";
            }
            else
            {
                Background_PLCHeartbeat = Brushes.DarkGreen;
                Foreground_PLCHeartbeat = Brushes.DarkGray;
                Background_HMIHeartbeat = Brushes.DarkRed;
                Foreground_HMIHeartbeat = Brushes.DarkGray;
                Content_PLCHeartbeat = "PLC";
                Content_HMIHeartbeat = "HMI";
            }       
        }

        private string ConvertJobSchedulerStatus(int RunStop)
        {
            if (RunStop == 1)
            {
                return "작업관리자 실행중";
            }
            else
            {
                return "작업관리자 정지중";
            }
        }

        private string ConvertAvailbaleStatus(int available)
        {
            if (available == (int)eAvailable.UP)
            {
                return "정상";
            }
            else if (available == (int)eAvailable.DOWN)
            {
                return "비정상";
            }
            else
            {
                return "알 수 없음";
            }
        }

        private string ConvertAlarmStatus(int alarmStatus)
        {
            if (alarmStatus == (int)eAlarm.HEAVY)
            {
                BuzzerOffButtonEnabled = true;
                return "중알람";
            }
            else if (alarmStatus == (int)eAlarm.LIGHT)
            {
                BuzzerOffButtonEnabled = false;
                return "경알람";
            }
            else if (alarmStatus == (int)eAlarm.NO_ALARM)
            {
                BuzzerOffButtonEnabled = false;
                return "알람 없음";
            }
            else
            {
                BuzzerOffButtonEnabled = false;
                return "알 수 없음";
            }
        }

        private string ConvertAccessModeStatus(int accessMode)
        {
            if (accessMode == (int)eAccessMode.AUTO)
            {
                SchedulerButtonEnabled = true;
                SchedulerButtonIsChecked = false;
                return "자동 모드";
            }
            else if (accessMode == (int)eAccessMode.MANUAL)
            {
                SchedulerButtonIsChecked = false;
                SchedulerButtonEnabled = false;
                return "수동 모드";
            }
            else if (accessMode == (int)eAccessMode.NONE)
            {
                SchedulerButtonIsChecked = false;
                SchedulerButtonEnabled = false;
                return "점검 모드";
            }
            else
            {
                SchedulerButtonIsChecked = false;
                SchedulerButtonEnabled = false;
                return "알 수 없음";
            }
        }

        private string ConvertRunStatus(int runMode)
        {
            if (runMode == (int)eRunStatus.IDLE)
            {
                PauseButtonContent = "일시정지";
                PauseButtonIsChecked = false;
                PauseButtonEnabled = false;
                AbortButtonEnabled = false;
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Pause, false);
                DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nOp_Abort, false);

                return "대기중";
            }
            else if (runMode == (int)eRunStatus.RUNNING)
            {
                PauseButtonContent = "일시정지";
                PauseButtonIsChecked = false;
                PauseButtonEnabled = true;
                AbortButtonEnabled = true;
                return "진행중";
            }
            else if (runMode == (int)eRunStatus.PAUSING)
            {
                PauseButtonContent = "다시시작";
                PauseButtonIsChecked = false;
                PauseButtonEnabled = true;
                AbortButtonEnabled = true;
                return "정지중";
            }
            else if (runMode == (int)eRunStatus.PAUSED)
            {
                PauseButtonContent = "다시시작";
                PauseButtonIsChecked = true;
                PauseButtonEnabled = true;
                AbortButtonEnabled = true;
                return "일시정지";
            }
            else
            {
                PauseButtonContent = "일시정지";
                PauseButtonIsChecked = false;
                PauseButtonEnabled = false;
                AbortButtonEnabled = false;
                return "알 수 없음";
            }
        }

        private string ConvertDoorLockStatus(int doorOpen)
        {
            if (doorOpen == (int)eOpenClose.CLOSE)
            {
                return "도어 잠김";
            }
            else if (doorOpen == (int)eOpenClose.OPEN)
            {
                return "도어 열림";
            }
            else
            {
                return "도어 잠김";
            }
        }

        
    }
}
