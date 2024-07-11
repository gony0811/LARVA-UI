using EPLE.App;
using EPLE.IO;
using DevExpress.Mvvm.CodeGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LARVA_UI.ViewModels;
using DevExpress.XtraRichEdit.Import.Doc;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.Xpf.WindowsUI;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for ManualView.xaml
    /// </summary>
    public partial class ManualView : UserControl
    {
        private bool result;
        public ManualView()
        {
            InitializeComponent();
            //Initialize();

            InitButtonColor();
        }

        private void InitButtonColor()
        {

        }

        private void CylinderBackward_Click(object sender, RoutedEventArgs e)
        {
            // 실린더 후진 로직
        }

        private void LedOn_Click(object sender, RoutedEventArgs e)
        {
            // LED On 로직
        }

        private void LedOff_Click(object sender, RoutedEventArgs e)
        {
            // LED Off 로직
        }

        private void FlipReverse_Click(object sender, RoutedEventArgs e)
        {
            // Flip 반전 로직
        }

        private void FlipNormal_Click(object sender, RoutedEventArgs e)
        {
            // Flip 정위치 로직
        }

        private void FlipConvShutter_Click(object sender, RoutedEventArgs e)
        {
            result = DataManager.Instance.SET_INT_DATA(IoNameHelper.iFlip_nOutShutter_UpDown, 1);
        }

        private void LoaderShutterOpen_Click(object sender, RoutedEventArgs e)
        {
            result = DataManager.Instance.SET_INT_DATA(IoNameHelper.iLoader_nShutter_UpDown, 1);
        }

        private void AutoViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.MANUAL)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("수동 모드에서 자동 화면에 접근할 수 없스니다.\n자동 모드로 변경 하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void AutoViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.MANUAL)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("수동 모드에서 자동 화면에 접근할 수 없스니다.\n자동 모드로 변경 하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void SettingsViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 설정 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void SettingsViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 설정 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void IoMonitoringViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 I/O 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void IoMonitoringViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 I/O 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }


        /*
        private void Initialize()
        {
            bool result = false;
            ManualViewModel vm = this.DataContext as ManualViewModel;

            // Loader Shutter
            int nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iLoader_nShutter_UpDown, out result);
            if (nVal == (int)eUpDown.DOWN)
            {
                vm.LoaderShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                vm.LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eUpDown.UP)
            {
                vm.LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.LoaderShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
            }

            // Loader Shuttle
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iLoader_nShuttle_FwdBwd, out result);
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                vm.LoaderShuttleFWBG = new SolidColorBrush(Colors.LightGreen);
                vm.LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eFwdBwd.BACKWARD)
            {
                vm.LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                vm.LoaderShuttleBWBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                vm.LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
            }

            // Upper Cover
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iFlip_nUpperCover_UpDown, out result);
            if (nVal == (int)eUpDown.UP)
            {
                vm.UpperCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                vm.UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eUpDown.DOWN)
            {
                vm.UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                vm.UpperCoverDnBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                vm.UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
            }


            // BoxImpact Cylinder
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, out result);
            if (nVal == (int)eRunStop.RUN)
            {
                vm.ImpactCylinderOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eRunStop.STOP)
            {
                vm.ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinderOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // BoxImpact Cylinder(1)
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iFlip_nImpCyl_L1_FwdBwd, out result);
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                vm.ImpactCylinder1FWBG = new SolidColorBrush(Colors.LightGreen);
                vm.ImpactCylinder1BWBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eFwdBwd.BACKWARD)
            {
                vm.ImpactCylinder1FWBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinder1BWBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.ImpactCylinder1FWBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinder1BWBG = new SolidColorBrush(Colors.Transparent);
            }

            // BoxImpact Cylinder(2)
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iFlip_nImpCyl_L2_FwdBwd, out result);
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                vm.ImpactCylinder2FWBG = new SolidColorBrush(Colors.LightGreen);
                vm.ImpactCylinder2BWBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eFwdBwd.BACKWARD)
            {
                vm.ImpactCylinder2FWBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinder2BWBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.ImpactCylinder2FWBG = new SolidColorBrush(Colors.Transparent);
                vm.ImpactCylinder2BWBG = new SolidColorBrush(Colors.Transparent);
            }

            // OutConveyor
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.OutConveyorOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.OutConveyorOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Out Shutter
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iFlip_nOutShutter_UpDown, out result);
            if (nVal == (int)eUpDown.DOWN)
            {
                vm.FlipOutShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                vm.FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eUpDown.UP)
            {
                vm.FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.FlipOutShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
            }

            // Hopper Moter
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.HoperMotorOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.HoperMotorOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.HoperMotorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.HoperMotorOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.HoperMotorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.HoperMotorOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // HotAirBlow
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.HotAirBlowerOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.HotAirBlowerOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.HotAirBlowerOnBG = new SolidColorBrush(Colors.Transparent);
                vm.HotAirBlowerOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.HotAirBlowerOnBG = new SolidColorBrush(Colors.Transparent);
                vm.HotAirBlowerOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // UV Lamp
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.UVLampOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.UVLampOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.UVLampOnBG = new SolidColorBrush(Colors.Transparent);
                vm.UVLampOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.UVLampOnBG = new SolidColorBrush(Colors.Transparent);
                vm.UVLampOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Mist
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.MistOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.MistOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.MistOnBG = new SolidColorBrush(Colors.Transparent);
                vm.MistOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.MistOnBG = new SolidColorBrush(Colors.Transparent);
                vm.MistOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Tobab Shutter
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTBS_nFlatCyl_FwdBwd, out result);
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                vm.TbsShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                vm.TbsShutterOpenBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eFwdBwd.BACKWARD)
            {
                vm.TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.TbsShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.TbsShutterOpenBG = new SolidColorBrush(Colors.Transparent);
            }

            // Flat Motor
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nFlatMotor_RunStop, out result);
            if (nVal == (int)eRunStop.RUN)
            {
                vm.FlatMotorOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.FlatMotorOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eRunStop.STOP)
            {
                vm.FlatMotorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.FlatMotorOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.FlatMotorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.FlatMotorOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Flat Motor standby
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nFlatMotorStandby_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.FlatMotorstandbyOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.FlatMotorstandbyOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.FlatMotorstandbyOnBG = new SolidColorBrush(Colors.Transparent);
                vm.FlatMotorstandbyOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.FlatMotorstandbyOnBG = new SolidColorBrush(Colors.Transparent);
                vm.FlatMotorstandbyOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Swing Cylinder
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nSwingCyl_RunStop, out result);
            if (nVal == (int)eRunStop.RUN)
            {
                vm.SwingOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.SwingOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eRunStop.STOP)
            {
                vm.SwingOnBG = new SolidColorBrush(Colors.Transparent);
                vm.SwingOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.SwingOnBG = new SolidColorBrush(Colors.Transparent);
                vm.SwingOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // mixer
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.MixerOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.MixerOffBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.MixerOnBG = new SolidColorBrush(Colors.Transparent);
                vm.MixerOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.MixerOnBG = new SolidColorBrush(Colors.Transparent);
                vm.MixerOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Box Stopper
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTBS_nBoxStopper_UpDown, out result);
            if (nVal == (int)eUpDown.UP)
            {
                vm.BoxStopperUpBG = new SolidColorBrush(Colors.LightGreen);
                vm.BoxStopperDownBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eUpDown.DOWN)
            {
                vm.BoxStopperUpBG = new SolidColorBrush(Colors.Transparent);
                vm.BoxStopperDownBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.BoxStopperUpBG = new SolidColorBrush(Colors.Transparent);
                vm.BoxStopperDownBG = new SolidColorBrush(Colors.Transparent);
            }

            // Wash Tank Valve
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.WaterTankValveOpenBG = new SolidColorBrush(Colors.LightGreen);
                vm.WaterTankValveCloseBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.WaterTankValveOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WaterTankValveCloseBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.WaterTankValveOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WaterTankValveCloseBG = new SolidColorBrush(Colors.Transparent);
            }

            // wash water valve
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.WashWaterOpenBG = new SolidColorBrush(Colors.LightGreen);
                vm.WashWaterCloseBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.WashWaterOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WashWaterCloseBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.WashWaterOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WashWaterCloseBG = new SolidColorBrush(Colors.Transparent);
            }

            // water pump
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.WaterPumpOpenBG = new SolidColorBrush(Colors.LightGreen);
                vm.WaterPumpCloseBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.WaterPumpOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WaterPumpCloseBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.WaterPumpOpenBG = new SolidColorBrush(Colors.Transparent);
                vm.WaterPumpCloseBG = new SolidColorBrush(Colors.Transparent);
            }

            // Transfer Clamp
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nClamp_LockUnlock, out result);
            if (nVal == (int)eLockUnlock.LOCK)
            {
                vm.TRSClampCloseBG = new SolidColorBrush(Colors.LightGreen);
                vm.TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
            }
            else if (nVal == (int)eLockUnlock.UNLOCK)
            {
                vm.TRSClampCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSClampOpenBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.TRSClampCloseBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
            }

            // Transfer Hand
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nHandLeft_FwdBwd, out result);
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                vm.TRSHandLeftBG = new SolidColorBrush(Colors.LightGreen);
                vm.TRSHandRightBG = new SolidColorBrush(Colors.Transparent);

            }
            else if (nVal == (int)eFwdBwd.BACKWARD)
            {
                vm.TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSHandRightBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSHandRightBG = new SolidColorBrush(Colors.Transparent);
            }

            // Box Cover
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nBoxCover_UpDown, out result);
            if (nVal == (int)eUpDown.UP)
            {
                vm.TRSCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                vm.TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);

            }
            else if (nVal == (int)eUpDown.DOWN)
            {
                vm.TRSCoverUpBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSCoverDnBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.TRSCoverUpBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);
            }


            // Box Vac
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nBoxCoverVac_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.TRSCoverVacOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);

            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSCoverOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                vm.TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);
            }
            
            // Exhuast Fan
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.AmmoniaOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.AmmoniaOffBG = new SolidColorBrush(Colors.Transparent);

            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.AmmoniaOnBG = new SolidColorBrush(Colors.Transparent);
                vm.AmmoniaOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.AmmoniaOnBG = new SolidColorBrush(Colors.Transparent);
                vm.AmmoniaOffBG = new SolidColorBrush(Colors.Transparent);
            }

            // Circulator Fan
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, out result);
            if (nVal == (int)eOnOff.ON)
            {
                vm.CirculatorOnBG = new SolidColorBrush(Colors.LightGreen);
                vm.CirculatorOffBG = new SolidColorBrush(Colors.Transparent);

            }
            else if (nVal == (int)eOnOff.OFF)
            {
                vm.CirculatorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.CirculatorOffBG = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                vm.CirculatorOnBG = new SolidColorBrush(Colors.Transparent);
                vm.CirculatorOffBG = new SolidColorBrush(Colors.Transparent);
            }
        }
        */
    }
}
