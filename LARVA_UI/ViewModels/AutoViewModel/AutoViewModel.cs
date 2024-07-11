using DevExpress.Mvvm;
using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm.CodeGenerators;
using LARVA_UI.Views;
using DevExpress.Xpf.Core;
using EPLE.App;
using EPLE.IO;
using EPLE.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;
using System.Linq;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using System.Collections.Generic;
using LARVA.Scheduler;
using System.Windows.Media;
using DevExpress.Xpf.WindowsUI;
using static DevExpress.XtraEditors.XtraInputBox;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using System.Threading;
using System.Windows.Threading;
using DevExpress.Utils.About;
using System.Threading.Tasks;
using DevExpress.Charts.Native;
using DevExpress.Data.Browsing;
using System.Xml.Linq;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class AutoViewModel
    {
        private string[] _boxButtonNames = new string[30];

        [GenerateProperty]
        public BoxSelectionViewModel boxSelectionViewModel = new BoxSelectionViewModel();

        [GenerateProperty]
        private int selectedZoneNumber;
        [GenerateProperty]
        public bool riceSupply_IsChecked;
        [GenerateProperty]
        public bool tobbabSupply_IsChecked;
        [GenerateProperty]
        public bool tobbabChange_IsChecked;
        [GenerateProperty]
        public bool jellySupply_IsChecked;
        [GenerateProperty]
        public bool shipment_IsChecked;
        [GenerateProperty]
        public bool mistSpray_IsChecked;
        [GenerateProperty]
        public bool vision_IsChecked;
        [GenerateProperty]
        public bool eject_IsChecked;
        [GenerateProperty]
        public bool unitFlipSwing_IsChecked;
        [GenerateProperty]
        public bool unitWashing_IsChecked;
        [GenerateProperty]
        public bool unitTobbab_IsChecked;
        [GenerateProperty]
        public bool feedStop_IsChecked;
        [GenerateProperty]
        public bool loading_IsChecked;
        [GenerateProperty]
        public double status_Temperature;
        [GenerateProperty]
        public double status_Humidity;
        [GenerateProperty]
        public double status_AmmoniaConcentration;
        [GenerateProperty]
        public string status_WaterTankLevel;
        [GenerateProperty]
        public Visibility manualViewNaviButtonVisibility;
        [GenerateProperty]
        public bool manualViewNaviButtonIsEnabled;

        [GenerateProperty]
        private string boxButtonName_11;
        [GenerateProperty]
        private string boxButtonName_12;
        [GenerateProperty]
        private string boxButtonName_13;
        [GenerateProperty]
        private string boxButtonName_14;
        [GenerateProperty]
        private string boxButtonName_15;
        [GenerateProperty]
        private string boxButtonName_16;
        [GenerateProperty]
        private string boxButtonName_21;
        [GenerateProperty]
        private string boxButtonName_22;
        [GenerateProperty]
        private string boxButtonName_23;
        [GenerateProperty]
        private string boxButtonName_24;
        [GenerateProperty]
        private string boxButtonName_25;
        [GenerateProperty]
        private string boxButtonName_26;
        [GenerateProperty]
        private string boxButtonName_31;
        [GenerateProperty]
        private string boxButtonName_32;
        [GenerateProperty]
        private string boxButtonName_33;
        [GenerateProperty]
        private string boxButtonName_34;
        [GenerateProperty]
        private string boxButtonName_35;
        [GenerateProperty]
        private string boxButtonName_36;
        [GenerateProperty]
        private string boxButtonName_41;
        [GenerateProperty]
        private string boxButtonName_42;
        [GenerateProperty]
        private string boxButtonName_43;
        [GenerateProperty]
        private string boxButtonName_44;
        [GenerateProperty]
        private string boxButtonName_45;
        [GenerateProperty]
        private string boxButtonName_46;
        [GenerateProperty]
        private string boxButtonName_51;
        [GenerateProperty]
        private string boxButtonName_52;
        [GenerateProperty]
        private string boxButtonName_53;
        [GenerateProperty]
        private string boxButtonName_54;
        [GenerateProperty]
        private string boxButtonName_55;
        [GenerateProperty]
        private string boxButtonName_56;


        public ObservableCollection<string> BoxButtonNames { get; private set; }

        public ObservableCollection<string> SelectedBoxes { get; private set; }

        [GenerateCommand]
        public void ToggleBoxSelection(string boxName)
        {
            if (SelectedBoxes.Contains(boxName))
                SelectedBoxes.Remove(boxName);
            else
                SelectedBoxes.Add(boxName);
        }

        public ICommand[] ChangeBoxZoneCommands { get; private set; }

        public AutoViewModel()
        {
            BoxButtonNames = new ObservableCollection<string>(Enumerable.Repeat("Initial Name", 240));

            for (int i = 0; i < 240; i++)
            {
                LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_ID == i)).FirstOrDefault();
                BoxButtonNames[i] = shelfinfo.LOCATION_NAME;
            }

            SelectedBoxes = new ObservableCollection<string>();
            InitializeCommands();
            InitializeProcessBusy();
            InitializeData();

            ChangeBoxZone(1);
        }

        private void InitializeData()
        {
            bool result = false;
            double dVal = 0.0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTH_fCurrent_Temp, out result);
            if (result) Status_Temperature = dVal;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTH_fCurrent_Humidity, out result);
            if (result) Status_Humidity = dVal / 100.0;
            
        }

        private void InitializeProcessBusy()
        {
            bool result = false;
            bool bVal = false;

            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nTobbabSupply_Busy, out result);
            if (result) TobbabSupply_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nRiceSupply_Busy, out result);
            if (result) RiceSupply_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nTobbabChange_Busy, out result);
            if (result) TobbabChange_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nJellySupply_Busy, out result);
            if (result) JellySupply_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nShipment_Busy, out result);
            if (result) Shipment_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nMist_Busy, out result);
            if (result) MistSpray_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nVision_Busy, out result);
            if (result) Vision_IsChecked = bVal;

            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nEject_Busy, out result);
            if (result) Eject_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iFlip_nProc_Busy, out result);
            if (result) UnitFlipSwing_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTob_nProc_Busy, out result);
            if (result) UnitTobbab_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iWash_nProc_Busy, out result);
            if (result) UnitWashing_IsChecked = bVal;
            bVal = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iAuto_nFeedStop_Busy, out result);
            if (result) FeedStop_IsChecked = bVal;

            DataManager.Instance.DataAccess.DataChangedEvent += FireDataChagedEvent;
        }

        private void FireDataChagedEvent(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = e.Data;

            if (data != null)
            {
                if (data.Name.Equals(IoNameHelper.iAuto_nEject_Busy))
                {
                    Eject_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nFeedStop_Busy))
                {
                    FeedStop_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nJellySupply_Busy))
                {
                    JellySupply_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nLoad_Busy))
                {
                    Loading_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nMist_Busy))
                {
                    MistSpray_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nRiceSupply_Busy))
                {
                    RiceSupply_IsChecked= Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nShipment_Busy))
                {
                    Shipment_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nTobbabChange_Busy))
                {
                    TobbabChange_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nTobbabSupply_Busy))
                {
                    TobbabSupply_IsChecked = Convert.ToBoolean(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nEject_Busy))
                {
                    Eject_IsChecked = Convert.ToBoolean((int)data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iAuto_nVision_Busy))
                {
                    Vision_IsChecked = Convert.ToBoolean((int)data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iTH_fCurrent_Temp))
                {
                    Status_Temperature = Convert.ToDouble(data.Value);
                }
                else if (data.Name.Equals(IoNameHelper.iTH_fCurrent_Humidity))
                {
                    // DisplayFormatString = "P" 로 지정하면 100곱해서 % 표기
                    // 따라서 100.0으로 나눠서 입력해야함.
                    Status_Humidity = Convert.ToDouble(data.Value) / 100.0;
                }
                else if (data.Name.Equals(IoNameHelper.iGas_fAmmo_Concent))
                {
                    Status_AmmoniaConcentration = Convert.ToDouble(data.Value);
                }
            }
        }

        [GenerateCommand(Name = "StockerZoneLedAllOffCommand")]
        private void StockerZoneLedAllOff(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.OFF);

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
        }

        [GenerateCommand(Name = "StockerZoneLedAllOn100Command")]
        private void StockerZoneLedAllOn100(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_100);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_100);

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
        }

        [GenerateCommand(Name = "StockerZoneLedAllOn50Command")]
        private void StockerZoneLedAllOn50(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_50);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_50);

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
        }

        [GenerateCommand]
        private void RackMasterMoveClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_VISION");
        }

        [GenerateCommand]
        private void TobbabSupplyClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_TOBBAB_SUPPLY");
        }

        [GenerateCommand(Name = "AsyncTobbabChangeCommand")]
        async Task AsyncTobbabChange()
        {
            var idx = 0;
            while (idx++ < 300)
            {
                if (AsyncTobbabChangeCommand.IsCancellationRequested)
                {
                    return;
                }
                await Task.Delay(10);
            }
        }

        [GenerateCommand]
        private void TobbabChangeClicked(RoutedEventArgs args)
        {
            if (BoxSelectionViewModel.BoxSelectedItems.Count == 0)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("대상 박스를 선택하세요.", "톱밥 교체 대상 박스를 선택하세요.", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.None);

                if (messageBoxResult == MessageBoxResult.OK)
                {
                    return;
                }
            }
            else
            {
                string msg = string.Format("{0}개 박스들의 톱밥 교체를 작업 대기열에 추가 하시겠습니까?", BoxSelectionViewModel.BoxSelectedItems.Count);

                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("톱밥 교체", msg, MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.Yes, MessageBoxOptions.None);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    foreach (string box in BoxSelectionViewModel.BoxSelectedItems)
                    {
                        LOCATION_INFO info = LocationManager.Instance.GetLocationList().Find((loc) => { return loc.LOCATION_NAME == box; });
                        object param = info.LOCATION_ID;

                        JobManager.Instance.CreateNewJob("TOBBAB_CHANGE", 100, "LOCAL", info.LOCATION_NAME);
                    }
                }
            }
        }

        [GenerateCommand]
        private void JellySupplyClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_JELLY_SUPPLY");
        }

        [GenerateCommand (Name = "LoadCompleteClickedCommand")]
        private void LoadCompleteClicked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oAuto_nLoadComplete_Reply, true);
        } 

        [GenerateCommand]
        private void SHIPMENTClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_SHIPMENT");
            //LocationManager.Instance.GetLocationList()
            //JobManager.Instance.CreateNewJob("TOBBAB_SUPPLY", )
        }

        [GenerateCommand]
        private void RiceSupplyClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_RICE_SUPPLY");
            //LocationManager.Instance.GetLocationList()
            //JobManager.Instance.CreateNewJob("TOBBAB_SUPPLY", )
        }

        [GenerateCommand]
        private void VisionClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_VISION");
            //LocationManager.Instance.GetLocationList()
            //JobManager.Instance.CreateNewJob("TOBBAB_SUPPLY", )
        }

        [GenerateCommand]
        private void UnloadingClicked(RoutedEventArgs args)
        {
            //if (SelectedBoxes.Count == 0) return;

           // string[] boxName = SelectedBoxes[0].Split(new char[] { '\n' });

            //LOCATION_INFO info = LocationManager.Instance.GetLocationList().Find((loc) => { return loc.LOCATION_NAME == boxName[0]; });
            //object param = info.LOCATION_ID;

            //DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, (int)info.LOCATION_ID);


            MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                 "박스 배출 공정",
                 "박스 배출 프로세스를 시작 하시겠습니까?\n" +
                 "박스 배출이 끝나면 투입/배출 완료 버튼을 누르세요",
                 MessageBoxButton.YesNo,
                 MessageBoxImage.Question,
                 MessageBoxResult.Yes, MessageBoxOptions.None
                 );

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_EJECT");
            }    
        }


        [GenerateCommand]
        private void FlipProcessClicked(RoutedEventArgs args)
        {
            MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                "톱밥 털기 단위공정",
                "톱밥 털기 단위 공정을 시작 하시겠습니까?",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.Yes, MessageBoxOptions.None
                );

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_UNIT_FLIP");
            }
        }

        [GenerateCommand]
        private void WashProcessClicked(RoutedEventArgs args)
        {
            MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                "세정 단위공정",
                "세정 단위 공정을 시작 하시겠습니까?",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.Yes, MessageBoxOptions.None
                );

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_UNIT_WASH");
            }
        }

        [GenerateCommand]
        private void TobbabProcessClicked(RoutedEventArgs args)
        {
            MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                "톱밥 공급 단위공정",
                "톱밥 공급 단위 공정 시작 하시겠습니까?",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.Yes, MessageBoxOptions.None
                );

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_UNIT_TOBBAB");
            }
        }


        [GenerateCommand]
        private void LoadingClicked(RoutedEventArgs args)
        {

            MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                "박스 투입 공정",
                "박스 투입 프로세스를 시작 하시겠습니까?\n" +
                "박스 투입이 끝나면 투입/배출 완료 버튼을 누르세요",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.Yes, MessageBoxOptions.None
                );

            if ( messageBoxResult == MessageBoxResult.Yes)
            {
                FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_LOAD");
            }
        }

        [GenerateCommand]
        private void StockLampOffClicked(RoutedEventArgs args)
        {

            switch (selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
                    break;
            }

        }

        [GenerateCommand]
        private void StockLampOn50Clicked(RoutedEventArgs args)
        {

            switch (selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
                    break;
            }

        }

        [GenerateCommand]
        private void StockLampOn100Clicked(RoutedEventArgs args)
        {

            switch (selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE1, true);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE2, true);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE3, true);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE4, true);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE5, true);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE6, true);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE7, true);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LEDZONE8, true);
                    break;
            }

        }

        private void InitializeCommands()
        {
            ChangeBoxZoneCommands = new ICommand[8];
            for (int i = 0; i < 8; i++)
            {
                int zoneNumber = i + 1;
                ChangeBoxZoneCommands[i] = new DelegateCommand(() => ChangeBoxZone(zoneNumber));
            }

            //DataManager.Instance.DataAccess.DataChangedEvent += FireDataChangedEvent;
        }


        private void FireDataChangedEvent(object sender, DataChangedEventHandlerArgs e)
        {
            bool result = false;
            Data data = e.Data;

            if (data.Name.Equals(IoNameHelper.iAuto_nLoadComplete_Req) && (int)data.Value == 1)
            {
                int busy = DataManager.Instance.GET_INT_DATA(IoNameHelper.iAuto_nLoad_Busy, out result);

                if (busy == 1)
                {
                    MessageBoxResult messageBoxResult = WinUIMessageBox.Show(
                        "박스 투입 요청",
                        "박스를 투입해 주세요!",
                        MessageBoxButton.YesNoCancel,
                        MessageBoxImage.Asterisk,
                        MessageBoxResult.OK, MessageBoxOptions.None
                        );

                    if (messageBoxResult == MessageBoxResult.OK)
                    {
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oAuto_nLoadComplete_Reply, true);
                    }
                }
                    //_loadCompleteRequest = true;
                else
                //_loadCompleteRequest = false;
                {

                }
            }
            //else if (data.Name.Equals(IoNameHelper.iAuto_nLoad_Busy))
            //{
            //    if ((int)data.Value == 1)
            //        _loadProcessBusy = true;
            //    else
            //        _loadProcessBusy = false;
            //}
        }

        private void ChangeBoxZone(int zoneNumber)
        {
            List< LOCATION_INFO> locations = LocationManager.Instance.GetLocationList();

            for (int i = 0; i < 30; i++)
            {
                LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_ID == (i + ((zoneNumber - 1) * 30)))).FirstOrDefault();
                BoxButtonNames[i] = $"{shelfinfo.LOCATION_NAME}\n{shelfinfo.LEVEL}";
            }

            selectedZoneNumber = zoneNumber;
        }

        public void ClearSelectedBoxes()
        {
            SelectedBoxes.Clear();
        }

        public void SetBoxLevel(string boxname, string shelflevel)
        {
            string newBoxname = null;
            if (boxname.Contains("\n"))
            {
                newBoxname = boxname.Substring(0, boxname.IndexOf('\n'));
            }
            else
            {
                newBoxname = boxname;
            }
            LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_NAME == newBoxname)).FirstOrDefault();
            LocationManager.Instance.UpdateLocationLevel(shelfinfo.LOCATION_ID, shelflevel);
        }
    }
}
