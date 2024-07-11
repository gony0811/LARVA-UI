using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using System;
using System.Windows;
using EPLE.IO;
using EPLE.App;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Media;
using DevExpress.Xpf.Core;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using System.Threading;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.XtraReports.UI;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Threading.Tasks;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ManualViewModel
    {
        [GenerateProperty]
        private bool isProcessSelectedCheck;
        [GenerateProperty]
        private bool zoneLed_100_IsChecked;
        [GenerateProperty]
        private bool zoneLed_50_IsChecked;
        [GenerateProperty]
        private bool zoneLed_Off_IsChecked;

        [GenerateProperty]
        private bool loaderShutterOpen_IsChecked;
        [GenerateProperty]
        private bool loaderShutterClose_IsChecked;
        [GenerateProperty]
        private bool loaderShuttleFwd_IsChecked;
        [GenerateProperty]
        private bool loaderShuttleBwd_IsChecked;
        [GenerateProperty]
        private bool waterTankValveOpen_IsChecked;
        [GenerateProperty]
        private bool waterTankValveClose_IsChecked;
        [GenerateProperty]
        private bool washWaterValveOpen_IsChecked;
        [GenerateProperty]
        private bool washWaterValveClose_IsChecked;
        [GenerateProperty]
        private bool washWaterPumpOn_IsChecked;
        [GenerateProperty]
        private bool washWaterPumpOff_IsChecked;
        [GenerateProperty]
        private bool washBlowerOn_IsChecked;
        [GenerateProperty]
        private bool washBlowerOff_IsChecked;
        [GenerateProperty]
        private bool upperCoverUp_IsChecked;
        [GenerateProperty]
        private bool upperCoverDown_IsChecked;
        [GenerateProperty]
        private bool impactCylinderRun_IsChecked;
        [GenerateProperty]
        private bool impactCylinderStop_IsChecked;

        [GenerateProperty]
        private bool impactCylinder1Fwd_IsChecked;
        [GenerateProperty]
        private bool impactCylinder1Bwd_IsChecked;
        [GenerateProperty]
        private bool impactCylinder2Fwd_IsChecked;
        [GenerateProperty]
        private bool impactCylinder2Bwd_IsChecked;
        [GenerateProperty]
        private bool outConveyorOn_IsChecked;
        [GenerateProperty]
        private bool outConveyorOff_IsChecked;
        [GenerateProperty]
        private bool flipOutShutterOpen_IsChecked;
        [GenerateProperty]
        private bool flipOutShutterClose_IsChecked;
        [GenerateProperty]
        private bool hoperMotorOn_IsChecked;
        [GenerateProperty]
        private bool hoperMotorOff_IsChecked;
        [GenerateProperty]
        private bool hotAirBlowerOn_IsChecked;
        [GenerateProperty]
        private bool hotAirBlowerOff_IsChecked;
        [GenerateProperty]
        private bool uVLampOn_IsChecked;
        [GenerateProperty]
        private bool uVLampOff_IsChecked;
        [GenerateProperty]
        private bool flipZoneLEDOn_IsChecked;
        [GenerateProperty]
        private bool flipZoneLEDOff_IsChecked;
        [GenerateProperty]
        private bool mistValveOn_IsChecked;
        [GenerateProperty]
        private bool mistValveOff_IsChecked;
        [GenerateProperty]
        private bool tbsShutterOpen_IsChecked;
        [GenerateProperty]
        private bool tbsShutterClose_IsChecked;
        [GenerateProperty]
        private bool tbsCylinderUp_IsChecked;
        [GenerateProperty]
        private bool tbsCylinderDown_IsChecked;
        [GenerateProperty]
        private bool mixerRun_IsChecked;
        [GenerateProperty]
        private bool mixerStop_IsChecked;
        [GenerateProperty]
        private bool flatMotorRun_IsChecked;
        [GenerateProperty]
        private bool flatMotorStop_IsChecked;
        [GenerateProperty]
        private bool flatMotorStandbyRun_IsChecked;
        [GenerateProperty]
        private bool flatMotorStandbyStop_IsChecked;
        [GenerateProperty]
        private bool boxStopperUp_IsChecked;
        [GenerateProperty]
        private bool boxStopperDown_IsChecked;
        [GenerateProperty]
        private bool circulatorFanOn_IsChecked;
        [GenerateProperty]
        private bool circulatorFanOff_IsChecked;
        [GenerateProperty]
        private bool ammoniaFanOn_IsChecked;
        [GenerateProperty]
        private bool ammoniaFanOff_IsChecked;

        [GenerateProperty]
        private bool zone1_IsChecked;
        [GenerateProperty]
        private bool zone2_IsChecked;
        [GenerateProperty]
        private bool zone3_IsChecked;
        [GenerateProperty]
        private bool zone4_IsChecked;
        [GenerateProperty]
        private bool zone5_IsChecked;
        [GenerateProperty]
        private bool zone6_IsChecked;
        [GenerateProperty]
        private bool zone7_IsChecked;
        [GenerateProperty]
        private bool zone8_IsChecked;
        [GenerateProperty]
        private bool floor1_IsChecked;
        [GenerateProperty]
        private bool floor2_IsChecked;
        [GenerateProperty]
        private bool floor3_IsChecked;
        [GenerateProperty]
        private bool floor4_IsChecked;
        [GenerateProperty]
        private bool floor5_IsChecked;
        [GenerateProperty]
        private bool column1_IsChecked;
        [GenerateProperty]
        private bool column2_IsChecked;
        [GenerateProperty]
        private bool column3_IsChecked;
        [GenerateProperty]
        private bool loaderStation_IsChecked;
        [GenerateProperty]
        private bool bufferStation_IsChecked;
        [GenerateProperty]
        private bool washStation_IsChecked;
        [GenerateProperty]
        private bool flipFaceUpStation_IsChecked;
        [GenerateProperty]
        private bool flipFaceDownStation_IsChecked;
        [GenerateProperty]
        private bool tobbabSupplyStation_IsChecked;
        [GenerateProperty]
        private bool tobbabFlatStation_IsChecked;
        [GenerateProperty]
        private bool visionStation_IsChecked;
        [GenerateProperty]
        private bool rackMove_IsChecked;
        [GenerateProperty]
        private bool processMove_IsChecked;
        [GenerateProperty]
        private bool pick_IsChecked;
        [GenerateProperty]
        private bool place_IsChecked;
        [GenerateProperty]
        private bool tRSHandLeft_IsChecked;
        [GenerateProperty]
        private bool tRSHandRight_IsChecked;
        [GenerateProperty]
        private bool tRSClampCylinderFwd_IsChecked;
        [GenerateProperty]
        private bool tRSClampCylinderBwd_IsChecked;
        [GenerateProperty]
        private bool tRSClampCylinderUp_IsChecked;
        [GenerateProperty]
        private bool tRSClampCylinderDown_IsChecked;
        [GenerateProperty]
        private bool tRSFlipClampCylinderUp_IsChecked;
        [GenerateProperty]
        private bool tRSFlipClampCylinderDown_IsChecked;
        [GenerateProperty]
        private bool tRSHandTurnRight_IsChecked;
        [GenerateProperty]
        private bool tRSHandTurnLeft_IsChecked;
        [GenerateProperty]
        private bool tRSBoxGuideFwd_IsChecked;
        [GenerateProperty]
        private bool tRSBoxGuideBwd_IsChecked;
        [GenerateProperty]
        private bool tRSClampOpen_IsChecked;
        [GenerateProperty]
        private bool tRSClampClose_IsChecked;
        [GenerateProperty]
        private bool tRSCoverUp_IsChecked;
        [GenerateProperty]
        private bool tRSCoverDown_IsChecked;
        [GenerateProperty]
        private bool tRSCoverVacOn_IsChecked;
        [GenerateProperty]
        private bool tRSCoverVacOff_IsChecked;
        [GenerateProperty]
        private bool flipLocationFaceUp_IsChecked;
        [GenerateProperty]
        private bool flipLocationFaceDown_IsChecked;
        [GenerateProperty]
        private bool zoneLed_100_IsHit;
        [GenerateProperty]
        private bool zoneLed_50_IsHit;
        [GenerateProperty]
        private bool zoneLed_Off_IsHit;
        [GenerateProperty]
        private bool loaderShutterOpen_IsHit;
        [GenerateProperty]
        private bool loaderShutterClose_IsHit;
        [GenerateProperty]
        private bool loaderShuttleFwd_IsHit;
        [GenerateProperty]
        private bool loaderShuttleBwd_IsHit;
        [GenerateProperty]
        private bool waterTankValveOpen_IsHit;
        [GenerateProperty]
        private bool waterTankValveClose_IsHit;
        [GenerateProperty]
        private bool washWaterValveOpen_IsHit;
        [GenerateProperty]
        private bool washWaterValveClose_IsHit;
        [GenerateProperty]
        private bool washWaterPumpOn_IsHit;
        [GenerateProperty]
        private bool washWaterPumpOff_IsHit;
        [GenerateProperty]
        private bool washBlowerOn_IsHit;
        [GenerateProperty]
        private bool washBlowerOff_IsHit;
        [GenerateProperty]
        private bool upperCoverUp_IsHit;
        [GenerateProperty]
        private bool upperCoverDown_IsHit;
        [GenerateProperty]
        private bool impactCylinderRun_IsHit;
        [GenerateProperty]
        private bool impactCylinderStop_IsHit;
        [GenerateProperty]
        private bool impactCylinder1Fwd_IsHit;
        [GenerateProperty]
        private bool impactCylinder1Bwd_IsHit;
        [GenerateProperty]
        private bool impactCylinder2Fwd_IsHit;
        [GenerateProperty]
        private bool impactCylinder2Bwd_IsHit;
        [GenerateProperty]
        private bool outConveyorOn_IsHit;
        [GenerateProperty]
        private bool outConveyorOff_IsHit;
        [GenerateProperty]
        private bool flipOutShutterOpen_IsHit;
        [GenerateProperty]
        private bool flipOutShutterClose_IsHit;
        [GenerateProperty]
        private bool hoperMotorOn_IsHit;
        [GenerateProperty]
        private bool hoperMotorOff_IsHit;
        [GenerateProperty]
        private bool hotAirBlowerOn_IsHit;
        [GenerateProperty]
        private bool hotAirBlowerOff_IsHit;
        [GenerateProperty]
        private bool uVLampOn_IsHit;
        [GenerateProperty]
        private bool uVLampOff_IsHit;
        [GenerateProperty]
        private bool flipZoneLEDOn_IsHit;
        [GenerateProperty]
        private bool flipZoneLEDOff_IsHit;
        [GenerateProperty]
        private bool mistValveOn_IsHit;
        [GenerateProperty]
        private bool mistValveOff_IsHit;
        [GenerateProperty]
        private bool tbsShutterOpen_IsHit;
        [GenerateProperty]
        private bool tbsShutterClose_IsHit;
        [GenerateProperty]
        private bool tbsCylinderUp_IsHit;
        [GenerateProperty]
        private bool tbsCylinderDown_IsHit;
        [GenerateProperty]
        private bool mixerRun_IsHit;
        [GenerateProperty]
        private bool mixerStop_IsHit;
        [GenerateProperty]
        private bool flatMotorRun_IsHit;
        [GenerateProperty]
        private bool flatMotorStop_IsHit;
        [GenerateProperty]
        private bool flatMotorStandbyRun_IsHit;
        [GenerateProperty]
        private bool flatMotorStandbyStop_IsHit;
        [GenerateProperty]
        private bool boxStopperUp_IsHit;
        [GenerateProperty]
        private bool boxStopperDown_IsHit;
        [GenerateProperty]
        private bool circulationFanOn_IsHit;
        [GenerateProperty]
        private bool circulationFanOff_IsHit;
        [GenerateProperty]
        private bool ammoniaFanOn_IsHit;
        [GenerateProperty]
        private bool ammoniaFanOff_IsHit;
        [GenerateProperty]
        private bool rackMove_IsHit;
        [GenerateProperty]
        private bool processMove_IsHit;
        [GenerateProperty]
        private bool tRSHandLeft_IsHit;
        [GenerateProperty]
        private bool tRSHandRight_IsHit;
        [GenerateProperty]
        private bool tRSClampCylinderFwd_IsHit;
        [GenerateProperty]
        private bool tRSClampCylinderBwd_IsHit;
        [GenerateProperty]
        private bool tRSClampCylinderUp_IsHit;
        [GenerateProperty]
        private bool tRSClampCylinderDown_IsHit;
        [GenerateProperty]
        private bool tRSFlipClampCylinderUp_IsHit;
        [GenerateProperty]
        private bool tRSFlipClampCylinderDown_IsHit;
        [GenerateProperty]
        private bool tRSHandTurnRight_IsHit;
        [GenerateProperty]
        private bool tRSHandTurnLeft_IsHit;
        [GenerateProperty]
        private bool tRSBoxGuideFwd_IsHit;
        [GenerateProperty]
        private bool tRSBoxGuideBwd_IsHit;
        [GenerateProperty]
        private bool tRSClampOpen_IsHit;
        [GenerateProperty]
        private bool tRSClampClose_IsHit;
        [GenerateProperty]
        private bool tRSCoverUp_IsHit;
        [GenerateProperty]
        private bool tRSCoverDown_IsHit;
        [GenerateProperty]
        private bool tRSCoverVacOn_IsHit;
        [GenerateProperty]
        private bool tRSCoverVacOff_IsHit;
        [GenerateProperty]
        private bool flipLocationFaceUp_IsHit;
        [GenerateProperty]
        private bool flipLocationFaceDown_IsHit;

        private string selectedZone;
        private string selectedFloor;
        private string selectedColumn;
        private string selectedProcess;

        public ManualViewModel()
        {
           
            DataManager.Instance.DataAccess.DataChangedEvent += new EventHandler<DataChangedEventHandlerArgs>(OnDataChanged);
            Initialize();
        }


        private void ZoneLed_CheckSet(int nVal)
        {
            if (nVal == (int)eLedCmd.OFF)
            {
                ZoneLed_100_IsChecked = false;
                ZoneLed_50_IsChecked = false;
                ZoneLed_Off_IsChecked = true;
                ZoneLed_100_IsHit = true;
                ZoneLed_50_IsHit = true;
                ZoneLed_Off_IsHit = false;
            }
            else if (nVal == (int)eLedCmd.ON_50)
            {
                ZoneLed_100_IsChecked = false;
                ZoneLed_50_IsChecked = true;
                ZoneLed_Off_IsChecked = false;
                ZoneLed_100_IsHit = true;
                ZoneLed_50_IsHit = false;
                ZoneLed_Off_IsHit = true;
            }
            else if (nVal == (int)eLedCmd.ON_100)
            {
                ZoneLed_100_IsChecked = true;
                ZoneLed_50_IsChecked = false;
                ZoneLed_Off_IsChecked = false;
                ZoneLed_100_IsHit = false;
                ZoneLed_50_IsHit = true;
                ZoneLed_Off_IsHit = true;
            }
            else
            {
                ZoneLed_100_IsChecked = false;
                ZoneLed_50_IsChecked = false;
                ZoneLed_Off_IsChecked = false;
                ZoneLed_100_IsHit = true;
                ZoneLed_50_IsHit = true;
                ZoneLed_Off_IsHit = true;
            }
        }

        private void LoaderShutter_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                LoaderShutterOpen_IsChecked = false;
                LoaderShutterClose_IsChecked = true;
            }
            else
            {
                LoaderShutterOpen_IsChecked = true;
                LoaderShutterClose_IsChecked = false;
            }
        }

        private void LoaderShuttle_CheckSet(int nVal)
        {
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                LoaderShuttleFwd_IsChecked = true;
                LoaderShuttleBwd_IsChecked = false;
            }
            else
            {
                LoaderShuttleFwd_IsChecked = false;
                LoaderShuttleBwd_IsChecked = true;
            }
        }

        private void WaterTankValve_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                WaterTankValveOpen_IsChecked = true;
                WaterTankValveClose_IsChecked = false;
            }
            else
            {
                WaterTankValveOpen_IsChecked = false;
                WaterTankValveClose_IsChecked = true;
            }
        }

        private void WashWaterValve_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                WashWaterValveOpen_IsChecked = true;
                WashWaterValveClose_IsChecked = false;
            }
            else
            {
                WashWaterValveOpen_IsChecked = false;
                WashWaterValveClose_IsChecked = true;
            }

        }

        private void WashWaterPump_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                WashWaterPumpOn_IsChecked = true;
                WashWaterPumpOff_IsChecked = false;
            }
            else
            {
                WashWaterPumpOn_IsChecked = false;
                WashWaterPumpOff_IsChecked = true;
            }
        }

        private void WashBlower_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                WashBlowerOn_IsChecked = true;
                WashBlowerOff_IsChecked = false;
            }
            else
            {
                WashBlowerOn_IsChecked = false;
                WashBlowerOff_IsChecked = true;
            }
        }

        private void UpperCover_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                UpperCoverUp_IsChecked = true;
                UpperCoverDown_IsChecked = false;
            }
            else
            {
                UpperCoverUp_IsChecked = false;
                UpperCoverDown_IsChecked = true;
            }
        }

        private void BoxImpactOperation_CheckSet(int nVal)
        {
            if (nVal == (int)eRunStop.RUN)
            {
                ImpactCylinderRun_IsChecked = true;
                ImpactCylinderStop_IsChecked = false;
            }
            else
            {
                ImpactCylinderRun_IsChecked = false;
                ImpactCylinderStop_IsChecked = true;
            }
        }


        private void ImpactCylinder1_CheckSet(int nVal)
        {
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                ImpactCylinder1Fwd_IsChecked = true;
                ImpactCylinder1Bwd_IsChecked = false;
            }
            else
            {
                ImpactCylinder1Fwd_IsChecked = false;
                ImpactCylinder1Bwd_IsChecked = true;
            }
        }

        private void ImpactCylinder2_CheckSet(int nVal)
        {
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                ImpactCylinder2Fwd_IsChecked = true;
                ImpactCylinder2Bwd_IsChecked = false;
            }
            else
            {
                ImpactCylinder2Fwd_IsChecked = false;
                ImpactCylinder2Bwd_IsChecked = true;
            }
        }

        private void FlipOutConveyor_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                OutConveyorOn_IsChecked = true;
                OutConveyorOff_IsChecked = false;
            }
            else
            {
                OutConveyorOn_IsChecked = false;
                OutConveyorOff_IsChecked = true;
            }
        }

        private void FlipOutShutter_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                FlipOutShutterOpen_IsChecked = true;
                FlipOutShutterClose_IsChecked = false;
            }
            else
            {
                FlipOutShutterOpen_IsChecked = false;
                FlipOutShutterClose_IsChecked = true;
            }
        }

        private void HopperMotor_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                HoperMotorOn_IsChecked = true;
                HoperMotorOff_IsChecked = false;
            }
            else
            {
                HoperMotorOn_IsChecked = false;
                HoperMotorOff_IsChecked = true;
            }
        }

        private void HotAirBlower_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                HotAirBlowerOn_IsChecked = true;
                HotAirBlowerOff_IsChecked = false;
            }
            else
            {
                HotAirBlowerOn_IsChecked = false;
                HotAirBlowerOff_IsChecked = true;
            }
        }

        private void UVLamp_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                UVLampOn_IsChecked = true;
                UVLampOff_IsChecked = false;
            }
            else
            {
                UVLampOn_IsChecked = false;
                UVLampOff_IsChecked = true;
            }
        }
        private void FlipZoneLED_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                FlipZoneLEDOn_IsChecked = true;
                FlipZoneLEDOff_IsChecked = false;
            }
            else
            {
                FlipZoneLEDOn_IsChecked = false;
                FlipZoneLEDOff_IsChecked = true;
            }
        }

        private void MistValve_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                MistValveOn_IsChecked = true;
                MistValveOff_IsChecked = false;
            }
            else
            {
                MistValveOn_IsChecked = false;
                MistValveOff_IsChecked = true;
            }
        }

        private void TbsShutter_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.DOWN)
            {
                TbsShutterOpen_IsChecked = true;
                TbsShutterClose_IsChecked = false;
            }
            else
            {
                TbsShutterOpen_IsChecked = false;
                TbsShutterClose_IsChecked = true;
            }
        }
        private void TbsUpDownCylinder_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                TbsCylinderUp_IsChecked = true;
                TbsCylinderDown_IsChecked = false;
            }
            else
            {
                TbsCylinderUp_IsChecked = false;
                TbsCylinderDown_IsChecked = true;
            }
        }

        private void MixerRun_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                MixerRun_IsChecked = true;
                MixerStop_IsChecked = false;
            }
            else
            {
                MixerRun_IsChecked = false;
                MixerStop_IsChecked = true;
            }
        }

        private void FlatMotorRun_CheckSet(int nVal)
        {
            if (nVal == (int)eRunStop.RUN)
            {
                FlatMotorRun_IsChecked = true;
                FlatMotorStop_IsChecked = false;
            }
            else
            {
                FlatMotorRun_IsChecked = false;
                FlatMotorStop_IsChecked = true;
            }
        }

        private void FlatMotorStandby_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                FlatMotorStandbyRun_IsChecked = true;
                FlatMotorStandbyStop_IsChecked = false;
            }
            else
            {
                FlatMotorStandbyRun_IsChecked = false;
                FlatMotorStandbyStop_IsChecked = true;
            }
        }

        private void TbsBoxStopper_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                BoxStopperUp_IsChecked = true;
                BoxStopperDown_IsChecked = false;
            }
            else
            {
                BoxStopperUp_IsChecked = false;
                BoxStopperDown_IsChecked = true;
            }
        }

        private void CirculatorFan_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                CirculatorFanOn_IsChecked = true;
                CirculatorFanOff_IsChecked = false;
            }
            else
            {
                CirculatorFanOn_IsChecked = false;
                CirculatorFanOff_IsChecked = true;
            }
        }
        private void AmmoniaFan_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                AmmoniaFanOn_IsChecked = true;
                AmmoniaFanOff_IsChecked = false;
            }
            else
            {
                AmmoniaFanOn_IsChecked = false;
                AmmoniaFanOff_IsChecked = true;
            }
        }

        private void TRSClampCylinderFwdBwd_CheckSet(int nVal)
        {
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                TRSClampCylinderFwd_IsChecked = true;
                TRSClampCylinderBwd_IsChecked = false;
            }
            else
            {
                TRSClampCylinderFwd_IsChecked = false;
                TRSClampCylinderBwd_IsChecked = true;
            }
        }
        private void TRSClampCylinderUpDown_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                TRSClampCylinderUp_IsChecked = true;
                TRSClampCylinderDown_IsChecked = false;
            }
            else
            {
                TRSClampCylinderUp_IsChecked = false;
                TRSClampCylinderDown_IsChecked = true;
            }
        }
        private void TRSFlipClampCylinderUpDown_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                TRSFlipClampCylinderUp_IsChecked = true;
                TRSFlipClampCylinderDown_IsChecked = false;
            }
            else
            {
                TRSFlipClampCylinderUp_IsChecked = false;
                TRSFlipClampCylinderDown_IsChecked = true;
            }
        }
        private void TRSHandTurn_CheckSet(int nVal)
        {
            if (nVal == (int)eLeftRight.RIGHT)
            {
                TRSHandTurnRight_IsChecked = true;
                TRSHandTurnLeft_IsChecked = false;
            }
            else
            {
                TRSHandTurnRight_IsChecked = false;
                TRSHandTurnLeft_IsChecked = true;
            }
        }
        private void TRSBoxGuideFwdBwd_CheckSet(int nVal)
        {
            if (nVal == (int)eFwdBwd.FORWARD)
            {
                TRSBoxGuideFwd_IsChecked = true;
                TRSBoxGuideBwd_IsChecked = false;
            }
            else
            {
                TRSBoxGuideFwd_IsChecked = false;
                TRSBoxGuideBwd_IsChecked = true;
            }
        }
        private void TRSHand_CheckSet(int nVal)
        {
            if (nVal == (int)eLeftRight.LEFT)
            {
                TRSHandLeft_IsChecked = true;
                TRSHandRight_IsChecked = false;
            }
            else
            {
                TRSHandLeft_IsChecked = false;
                TRSHandRight_IsChecked = true;
            }
        }

        private void TRSClamp_CheckSet(int nVal)
        {
            if (nVal == (int)eOpenClose.OPEN)
            {
                TRSClampOpen_IsChecked = true;
                TRSClampClose_IsChecked = false;
            }
            else
            {
                TRSClampOpen_IsChecked = false;
                TRSClampClose_IsChecked = true;
            }
        }

        private void TRSCover_CheckSet(int nVal)
        {
            if (nVal == (int)eUpDown.UP)
            {
                TRSCoverUp_IsChecked = true;
                TRSCoverDown_IsChecked = false;
            }
            else
            {
                TRSCoverUp_IsChecked = false;
                TRSCoverDown_IsChecked = true;
            }
        }

        private void TRSCoverVac_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                TRSCoverVacOn_IsChecked = true;
                TRSCoverVacOff_IsChecked = false;
            }
            else
            {
                TRSCoverVacOn_IsChecked = false;
            }
        }

        private void TRSCoverVacEject_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                TRSCoverVacOff_IsChecked = true;
                TRSCoverVacOn_IsChecked = false;
            }
            else
            {
                TRSCoverVacOff_IsChecked = false;
            }
        }

        private void FlipLocation_CheckSet(int nVal)
        {
            if (nVal == (int)eOnOff.ON)
            {
                FlipLocationFaceUp_IsChecked = true;
                FlipLocationFaceDown_IsChecked = false;
            }
            else
            {
                FlipLocationFaceUp_IsChecked = false;
                FlipLocationFaceDown_IsChecked = true;
            }
        }


        private void Initialize()
        {
            bool result = false;
            int nVal = 0;

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (result && nVal == (int)eAccessMode.MANUAL)
            {
                LoaderShutterOpen_IsHit = true;
                LoaderShutterClose_IsHit = true;
                LoaderShuttleFwd_IsHit = true;
                LoaderShuttleBwd_IsHit = true;
                WaterTankValveOpen_IsHit = true;
                WaterTankValveClose_IsHit = true;
                WashWaterValveOpen_IsHit = true;
                WashWaterValveClose_IsHit = true;
                WashWaterPumpOn_IsHit = true;
                WashWaterPumpOff_IsHit = true;
                WashBlowerOn_IsHit = true;
                WashBlowerOff_IsHit = true;
                UpperCoverUp_IsHit = true;
                UpperCoverDown_IsHit = true;
                ImpactCylinderRun_IsHit = true;
                ImpactCylinderStop_IsHit = true;
                ImpactCylinder1Fwd_IsHit = true;
                ImpactCylinder1Bwd_IsHit = true;
                ImpactCylinder2Fwd_IsHit = true;
                ImpactCylinder2Bwd_IsHit = true;
                OutConveyorOn_IsHit = true;
                OutConveyorOff_IsHit = true;
                FlipOutShutterOpen_IsHit = true;
                FlipOutShutterClose_IsHit = true;
                HoperMotorOn_IsHit = true;
                HoperMotorOff_IsHit = true;
                HotAirBlowerOn_IsHit = true;
                HotAirBlowerOff_IsHit = true;
                UVLampOn_IsHit = true;
                UVLampOff_IsHit = true;
                FlipZoneLEDOn_IsHit = true;
                FlipZoneLEDOff_IsHit = true;
                MistValveOn_IsHit = true;
                MistValveOff_IsHit = true;
                TbsShutterOpen_IsHit = true;
                TbsShutterClose_IsHit= true;
                TbsCylinderUp_IsHit = true;
                TbsCylinderDown_IsHit = true;
                MixerRun_IsHit = true;
                MixerStop_IsHit = true;
                FlatMotorRun_IsHit = true;
                FlatMotorStop_IsHit = true;
                FlatMotorStandbyRun_IsHit = true;
                FlatMotorStandbyStop_IsHit = true;
                BoxStopperUp_IsHit = true;
                BoxStopperDown_IsHit = true;
                CirculationFanOn_IsHit = true;
                CirculationFanOff_IsHit = true;
                AmmoniaFanOn_IsHit = true;
                AmmoniaFanOff_IsHit = true;
                RackMove_IsHit = true;
                ProcessMove_IsHit = true;
                TRSHandLeft_IsHit = true;
                TRSHandRight_IsHit = true;
                TRSClampCylinderFwd_IsHit = true;
                TRSClampCylinderBwd_IsHit = true;
                TRSClampCylinderUp_IsHit = true;
                TRSClampCylinderDown_IsHit = true;
                TRSFlipClampCylinderUp_IsHit = true;
                TRSFlipClampCylinderDown_IsHit = true;
                TRSHandTurnRight_IsHit = true;
                TRSHandTurnLeft_IsHit = true;
                TRSBoxGuideFwd_IsHit = true;
                TRSBoxGuideBwd_IsHit = true;
                TRSClampOpen_IsHit = true;
                TRSClampClose_IsHit = true;
                TRSCoverUp_IsHit = true;
                TRSCoverDown_IsHit = true;
                TRSCoverVacOn_IsHit = true;
                TRSCoverVacOff_IsHit = true;
                FlipLocationFaceUp_IsHit = true;
                FlipLocationFaceDown_IsHit = true;
                ZoneLed_100_IsHit = true;
                ZoneLed_50_IsHit = true;
                ZoneLed_Off_IsHit = true;
            }

            selectedZone = "1";
            Zone1_IsChecked = true;
            Zone2_IsChecked = false;
            Zone3_IsChecked = false;
            Zone4_IsChecked = false;
            Zone5_IsChecked = false;
            Zone6_IsChecked = false;
            Zone7_IsChecked = false;
            Zone8_IsChecked = false;


            selectedFloor = "1";
            Floor1_IsChecked = true;
            Floor2_IsChecked = false;
            Floor3_IsChecked = false;
            Floor4_IsChecked = false;
            Floor5_IsChecked = false;




            selectedColumn = "1";
            Column1_IsChecked = true;
            Column2_IsChecked = false;
            Column3_IsChecked = false;

            selectedProcess = "LOAD";
            LoaderStation_IsChecked = true;
            BufferStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;
            WashStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            VisionStation_IsChecked = false;

            ZoneLed_100_IsChecked = false;
            ZoneLed_50_IsChecked = false;
            ZoneLed_Off_IsChecked = false;


            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iLoader_nShutter_UpDown, out result); if (result) LoaderShutter_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iLoader_nShuttle_FwdBwd, out result); if (result) LoaderShuttle_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, out result); if (result) WaterTankValve_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, out result); if (result) WashWaterValve_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, out result);if (result) WashWaterPump_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oWash_nBoxBlower_OnOff, out result); if (result) WashBlower_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iFlip_nUpperCover_UpDown, out result); if (result) UpperCover_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, out result); if (result) BoxImpactOperation_CheckSet(nVal);

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L1_FwdBwd, out result); if (result) ImpactCylinder1_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L2_FwdBwd, out result); if (result) ImpactCylinder2_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, out result); if (result) FlipOutConveyor_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, out result); if (result) FlipOutShutter_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, out result); if (result) HopperMotor_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, out result); if (result) HotAirBlower_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, out result); if (result) UVLamp_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nZoneLed_OnOff, out result); if (result) FlipZoneLED_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, out result); if (result) MistValve_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTBS_nShutterCyl_FwdBwd, out result); if (result) TbsShutter_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTob_nSupplyCyl_UpDown, out result); if (result) TbsUpDownCylinder_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, out result); if (result) MixerRun_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTbs_nFlatVibration_RunStop, out result); if (result) FlatMotorRun_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nFlatMotorStandby_OnOff, out result); if (result) FlatMotorStandby_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTBS_nBoxStopper_UpDown, out result); if (result) TbsBoxStopper_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, out result); if (result) CirculatorFan_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, out result); if (result) AmmoniaFan_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nHandLeft_FwdBwd, out result); if (result) TRSHand_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nClampCyl_FwdBwd, out result); if (result) TRSClampCylinderFwdBwd_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nClampCyl_UpDown, out result); if (result) TRSClampCylinderUpDown_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTob_nFlipClamp_UpDown, out result); if (result) TRSFlipClampCylinderUpDown_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nHandTurn_LeftRight, out result); if (result) TRSHandTurn_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTob_nGuide_FwdBwd, out result); if (result) TRSBoxGuideFwdBwd_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nClamp_LockUnlock, out result); if (result) TRSClamp_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nBoxCover_UpDown, out result); if (result) TRSCover_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nBoxCoverVac_OnOff, out result); if (result) TRSCoverVac_CheckSet(nVal);
            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, out result); if (result) TRSCoverVacEject_CheckSet(nVal);

            if (selectedZone == "1")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "2")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);

            }
            else if (selectedZone == "3")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "4")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "5")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "6")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "7")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "8")
            {
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, out result); if (result) ZoneLed_CheckSet(nVal);
            }
        }


        private void OnDataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            EPLE.IO.Data data = (EPLE.IO.Data)e.Data;

            int nVal = 0;

            if( data.Type == eDataType.Int )
            {
                nVal = (int)data.Value;
            }


            if (data.Name.Equals(IoNameHelper.iFlip_nImpCyl_L1_FwdBwd))
            {
                ImpactCylinder1_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone1_OnOff))
            {
                if (selectedZone == "1")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone2_OnOff))
            {
                if (selectedZone == "2")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone3_OnOff))
            {
                if (selectedZone == "3")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone4_OnOff))
            {
                if (selectedZone == "4")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone5_OnOff))
            {
                if (selectedZone == "5")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone6_OnOff))
            {
                if (selectedZone == "6")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone7_OnOff))
            {
                if (selectedZone == "7")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone8_OnOff))
            {
                if (selectedZone == "8")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iFlip_nImpCyl_L2_FwdBwd))
            {
                ImpactCylinder2_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iLoader_nShutter_UpDown))
            {
                LoaderShutter_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iLoader_nShuttle_FwdBwd))
            {
                LoaderShuttle_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iFlip_nUpperCover_UpDown))
            {
                UpperCover_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTBS_nBoxStopper_UpDown))
            {
                TbsBoxStopper_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nHandLeft_FwdBwd))
            {
                TRSHand_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nClampCyl_FwdBwd))
            {
                TRSClampCylinderFwdBwd_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nClampCyl_UpDown))
            {
                TRSClampCylinderUpDown_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTob_nFlipClamp_UpDown))
            {
                TRSFlipClampCylinderUpDown_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nHandTurn_LeftRight))
            {
                TRSHandTurn_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTob_nGuide_FwdBwd))
            {
                TRSBoxGuideFwdBwd_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nClamp_LockUnlock))
            {
                TRSClamp_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nBoxCover_UpDown))
            {
                TRSCover_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTrans_nBoxCoverVac_OnOff))
            {
                TRSCoverVac_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTob_nMixerShutter_OpnCls))
            {
                TbsShutter_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.iTob_nSupplyCyl_UpDown))
            {
                TbsUpDownCylinder_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone1_OnOff))
            {
                if (selectedZone == "1")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone2_OnOff))
            {
                if (selectedZone == "2")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone3_OnOff))
            {
                if (selectedZone == "3")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone4_OnOff))
            {
                if (selectedZone == "4")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone5_OnOff))
            {
                if (selectedZone == "5")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone6_OnOff))
            {
                if (selectedZone == "6")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone7_OnOff))
            {
                if (selectedZone == "7")
                    ZoneLed_CheckSet(nVal);
            }
            else if (data.Name.Equals(IoNameHelper.oLed_nZone8_OnOff))
            {
                if (selectedZone == "8")
                    ZoneLed_CheckSet(nVal);
            }
        }

        [GenerateCommand(Name = "ProcessCheckedCommand")]
        private void ProcessChecked(RoutedEventArgs args)
        {
            
        }

        [GenerateCommand(Name = "RackCheckedCommand")]
        private void RackChecked(RoutedEventArgs args)
        {

        }

        [GenerateCommand(Name = "MistCommandClicked")]
        private void MistCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.ON);
                MistValve_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.OFF);
                MistValve_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSMISTVALVE, true);
        }
        [GenerateCommand(Name = "TbsShutterCommandClicked")]
        private void TbsShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTob_nMixerShutter_OpnCls, (int)eOpenClose.OPEN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTob_nMixerShutter_OpnCls, (int)eOpenClose.CLOSE);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTobbobMix_Shutter, true);
        }
        
        [GenerateCommand(Name = "FlatMotorCommandClicked")]
        private void FlatMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTbs_nFlatVibration_RunStop, (int)eRunStop.RUN);
                FlatMotorRun_CheckSet((int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTbs_nFlatVibration_RunStop, (int)eRunStop.STOP);
                FlatMotorRun_CheckSet((int)eRunStop.STOP);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTbsFlat_Vibration, true);
        }

        [GenerateCommand(Name = "FlatMotorstandbyCommandClicked")]
        private void FlatMotorstandbyCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotorStandby_OnOff, (int)eOnOff.ON);
                FlatMotorStandby_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotorStandby_OnOff, (int)eOnOff.OFF);
                FlatMotorStandby_CheckSet((int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "TbsCylinderUpDownCommandClicked")]
        private void TbsCylinderUpDownCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("상승"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTob_nSupplyCyl_UpDown, (int)eUpDown.UP);
                TbsUpDownCylinder_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTob_nSupplyCyl_UpDown, (int)eUpDown.DOWN);
                TbsUpDownCylinder_CheckSet((int)eUpDown.DOWN);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTobbobSupply_Cylinder, true);
        }

        [GenerateCommand(Name = "MixerCommandClicked")]
        private void MixerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, (int)eOnOff.ON);
                MixerRun_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, (int)eOnOff.OFF);
                MixerRun_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSMIXERMOTOR, true);
        }

        [GenerateCommand(Name = "BoxStopperCommandClicked")]
        private void BoxStopperCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("닫힘"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nBoxStopper_UpDown, (int)eUpDown.UP);
                TbsBoxStopper_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nBoxStopper_UpDown, (int)eUpDown.DOWN);
                TbsBoxStopper_CheckSet((int)(eUpDown.DOWN));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSBOXSTOPPERUPDOWN, true);
        }


        [GenerateCommand(Name = "WaterTankValveCommandClicked")]
        private void WaterTankValveCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.ON);
                WaterTankValve_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.OFF);
                WaterTankValve_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_WASHWATERTANKVALVE, true);
        }

        [GenerateCommand(Name = "WashWaterCommandClicked")]
        private void WashWaterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.ON);
                WashWaterValve_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.OFF);
                WashWaterValve_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_WASHWATERVALVE, true);
        }
        [GenerateCommand(Name = "WaterPumpCommandClicked")]
        private void WaterPumpCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.ON);
                WashWaterPump_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.OFF);
                WashWaterPump_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_WASHWATERPUMP, true);
        }

        [GenerateCommand(Name = "WashBlowerCommandClicked")]
        private void WashBlowerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nBoxBlower_OnOff, (int)eOnOff.ON);
                WashBlower_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nBoxBlower_OnOff, (int)eOnOff.OFF);
                WashBlower_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_WASHBOXBLOWER, true);
           
        }

        [GenerateCommand(Name = "ZoneLed_Off_ClickCommand")]
        private void ZoneLed_Off_Click(RoutedEventArgs args)
        {
            switch(selectedZone)
            {
                case "1":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.OFF); 
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE1, (int)eOnOff.ON);
                    break;
                case "2":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE2, (int)eOnOff.ON);
                    break;
                case "3":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE3, (int)eOnOff.ON);
                    break;
                case "4":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE4, (int)eOnOff.ON);
                    break;
                case "5":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE5, (int)eOnOff.ON);
                    break;
                case "6":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE6, (int)eOnOff.ON);
                    break;
                case "7":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE7, (int)eOnOff.ON);
                    break;
                case "8":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.OFF);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE8, (int)eOnOff.ON);

                    break;
            }
            
        }

        [GenerateCommand(Name = "ZoneLed_100_ClickCommand")]
        private void ZoneLed_100_Click(RoutedEventArgs args)
        {
            switch (selectedZone)
            {
                case "1":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE1, (int)eOnOff.ON);
                    break;
                case "2":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE2, (int)eOnOff.ON);
                    break;
                case "3":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE3, (int)eOnOff.ON);
                    break;
                case "4":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE4, (int)eOnOff.ON);
                    break;
                case "5":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE5, (int)eOnOff.ON);
                    break;
                case "6":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE6, (int)eOnOff.ON);
                    break;
                case "7":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE7, (int)eOnOff.ON);
                    break;
                case "8":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_100);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE8, (int)eOnOff.ON);
                    break;
            }
        }

        [GenerateCommand(Name = "ZoneLed_50_ClickCommand")]
        private void ZoneLed_50_Click(RoutedEventArgs args)
        {
            switch (selectedZone)
            {
                case "1":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE1, (int)eOnOff.ON);
                    break;
                case "2":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE2, (int)eOnOff.ON);
                    break;
                case "3":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE3, (int)eOnOff.ON);
                    break;
                case "4":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE4, (int)eOnOff.ON);
                    break;
                case "5":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE5, (int)eOnOff.ON);
                    break;
                case "6":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE6, (int)eOnOff.ON);
                    break;
                case "7":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE7, (int)eOnOff.ON);
                    break;
                case "8":
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_50);
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oExec_LEDZONE8, (int)eOnOff.ON);
                    break;
            }
        }

        [GenerateCommand]
        private void ZoneSelectClick(RoutedEventArgs args)
        {
            int nVal = 0;
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedZone = (string)btn.Content;
            //selectedZone

            Zone1_IsChecked = false;
            Zone2_IsChecked = false;
            Zone3_IsChecked = false;
            Zone4_IsChecked = false;
            Zone5_IsChecked = false;
            Zone6_IsChecked = false;
            Zone7_IsChecked = false;
            Zone8_IsChecked = false;

            if (selectedZone == "1")
            {
                Zone1_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, out bool result);
                if(result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "2")
            {
                Zone2_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "3")
            {
                Zone3_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "4")
            {
                Zone4_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "5")
            {
                Zone5_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "6")
            {
                Zone6_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "7")
            {
                Zone7_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
            else if (selectedZone == "8")
            {
                Zone8_IsChecked = true;
                nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, out bool result);
                if (result) ZoneLed_CheckSet(nVal);
            }
        }

        [GenerateCommand]
        private void FloorSelectClick(RoutedEventArgs args)
        {
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedFloor = (string)btn.Content;

            Floor1_IsChecked = false;
            Floor2_IsChecked = false;
            Floor3_IsChecked = false;
            Floor4_IsChecked = false;
            Floor5_IsChecked = false;
            //selectedZone

            if (selectedFloor == "1")
            {
                Floor1_IsChecked = true;
            }
            else if (selectedFloor == "2")
            {
                Floor2_IsChecked = true;
            }
            else if (selectedFloor == "3")
            {
                Floor3_IsChecked = true;
            }
            else if (selectedFloor == "4")
            {
                Floor4_IsChecked = true;
            }
            else if (selectedFloor == "5")
            {
                Floor5_IsChecked = true;
            }


        }

        [GenerateCommand]
        private void ColumnSelectClick(RoutedEventArgs args)
        {
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedColumn = (string)btn.Content;

            Column1_IsChecked = false;
            Column2_IsChecked = false;
            Column3_IsChecked = false;
            //selectedZone

            if (selectedColumn == "1")
            {
                Column1_IsChecked = true;
            }
            else if (selectedColumn == "2")
            {
                Column2_IsChecked = true;
            }
            else if (selectedColumn == "3")
            {
                Column3_IsChecked = true;
            }
        }

        [GenerateCommand]
        private void LoaderSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = true;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "LOAD";
        }

        [GenerateCommand]
        private void BufferSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = true;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "BUFFER";
        }

        [GenerateCommand(Name = "TobbabSupplySelectClickCommand")]
        private void TobbabSupplySelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = true;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "TOBBAB";
        }

        [GenerateCommand(Name = "TobbabFlatSelectClickCommand")]
        private void TobbabFlatSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = true;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "TBS_FLAT";
        }

        [GenerateCommand]
        private void WashSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = true;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "WASH";
        }

        [GenerateCommand]
        private void VisionSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = true;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "VISION";
        }

        [GenerateCommand]
        private void FlipFaceUpSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = true;
            FlipFaceDownStation_IsChecked = false;

            selectedProcess = "FLIP_BOX_UP";
        }
        [GenerateCommand]
        private void FlipFaceDownSelectClick(RoutedEventArgs args)
        {
            LoaderStation_IsChecked = false;
            BufferStation_IsChecked = false;
            TobbabSupplyStation_IsChecked = false;
            TobbabFlatStation_IsChecked = false;
            WashStation_IsChecked = false;
            VisionStation_IsChecked = false;
            FlipFaceUpStation_IsChecked = false;
            FlipFaceDownStation_IsChecked = true;

            selectedProcess = "FLIP_BOX_DOWN";
        }

        [GenerateCommand(Name= "AsyncRackMoveCommand")]
        async Task AsyncRackMove()
        {
            int nSelectedColumn = (int.Parse(selectedColumn) * 2) - 1;
            string location_name = string.Format("STOCK {0}_{1}{2}", selectedZone, selectedFloor, nSelectedColumn);
            LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == location_name); });
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTransMove_LocationId, Convert.ToInt32(loc.LOCATION_ID));
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nMove_RunStop, (int)eRunStop.RUN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERMOVE, true);
            RackMove_IsChecked = true;
            ProcessMove_IsChecked = false;
            Pick_IsChecked = false;
            Place_IsChecked = false;

            DateTime start = DateTime.Now;

            while (true)
            {

                if (DateTime.Now - start < TimeSpan.FromSeconds(1))
                {
                    continue;
                }

                if (!(DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTrans_nMove_Busy, out bool result) && result))
                {
                    return;
                }
                else if (DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result) == (int)eAvailable.DOWN && result)
                {
                    return;
                }
                else if (AsyncRackMoveCommand.IsCancellationRequested)
                {
                    return;
                }
                else
                {
                    await Task.Delay(10);
                }           
            }
        }

        [GenerateCommand(Name = "RackMoveClickedCommand")]
        private void RackMoveClicked(RoutedEventArgs args)
        {
            int nSelectedColumn = (int.Parse(selectedColumn) * 2) - 1;
            string location_name = string.Format("STOCK {0}_{1}{2}", selectedZone, selectedFloor, nSelectedColumn);
            LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == location_name); });
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTransMove_LocationId, Convert.ToInt32(loc.LOCATION_ID));
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nMove_RunStop, (int)eRunStop.RUN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERMOVE, true);
            RackMove_IsChecked = true;
            ProcessMove_IsChecked = false;
            Pick_IsChecked = false;
            Place_IsChecked = false;
        }

        [GenerateCommand(Name = "ProcessMoveClickedCommand")]
        private void ProcessMoveClicked(RoutedEventArgs args)
        {
            int location_id = 0;

            if (selectedProcess.Equals("TOBBAB"))
            {
                location_id = (int)eLocationId.TOBBAB;
            }
            else if (selectedProcess.Equals("TBS_FLAT"))
            {
                location_id = (int)eLocationId.TBS_FLAT;
            }
            else if (selectedProcess.Equals("FLIP_BOT_UP"))
            {
                location_id = (int)eLocationId.FLIP_BOX_UP;
            }
            else if (selectedProcess.Equals("FLIP_BOT_DOWN"))
            {
                location_id = (int)eLocationId.FLIP_BOX_DOWN;
            }
            else if (selectedProcess.Equals("WASH"))
            {
                location_id = (int)eLocationId.WASH;
            }
            else if (selectedProcess.Equals("LOAD"))
            {
                location_id = (int)eLocationId.LOAD;
            }
            else if (selectedProcess.Equals("BUFFER"))
            {
                location_id = (int)eLocationId.BUFFER;
            }
            else if (selectedProcess.Equals("VISION"))
            {
                location_id = (int)eLocationId.VISION;
            }
            else
            {
                location_id = (int)eLocationId.VISION;
            }


            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTransMove_LocationId, location_id);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nMove_RunStop, (int)eRunStop.RUN);
            

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERMOVE, true);

            RackMove_IsChecked = false;
            ProcessMove_IsChecked = true;
            Pick_IsChecked = false;
            Place_IsChecked = false;
        }

        [GenerateCommand(Name = "PlaceClickedCommand")]
        private void PlaceClicked(RoutedEventArgs args)
        {

            if (IsProcessSelectedCheck)
            {
                LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == selectedProcess); });

                if (loc != null)
                {
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nPlace_LocationId, Convert.ToInt32(loc.LOCATION_ID));
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERPLACE, true);
                }
            }
            else
            {
                int nSelectedColumn = (int.Parse(selectedColumn) * 2) - 1;
                string location_name = string.Format("STOCK {0}_{1}{2}", selectedZone, selectedFloor, nSelectedColumn);
                LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == location_name); });

                if (loc != null)
                {
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nPlace_LocationId, Convert.ToInt32(loc.LOCATION_ID));
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERPLACE, true);
                }
            }


            RackMove_IsChecked = false;
            ProcessMove_IsChecked = false;
            Pick_IsChecked = false;
            Place_IsChecked = true;
        }

        [GenerateCommand(Name = "PickClickedCommand")]
        private void PickClicked(RoutedEventArgs args)
        {
            if (IsProcessSelectedCheck)
            {
                LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == selectedProcess); });

                if (loc != null)
                {
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nPick_LocationId, Convert.ToInt32(loc.LOCATION_ID));
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERPICK, true);
                }
            }
            else
            {
                int nSelectedColumn = (int.Parse(selectedColumn) * 2) - 1;
                string location_name = string.Format("STOCK {0}_{1}{2}", selectedZone, selectedFloor, nSelectedColumn);
                LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == location_name); });

                if (loc != null)
                {
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nPick_LocationId, Convert.ToInt32(loc.LOCATION_ID));
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERPICK, true);
                }
            }

            RackMove_IsChecked = false;
            ProcessMove_IsChecked = false;
            Pick_IsChecked = true;
            Place_IsChecked = false;
        }

        [GenerateCommand(Name = "CirculatorCommandClicked")]
        private void CirculatorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.ON);
                CirculatorFan_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.OFF);
                CirculatorFan_CheckSet((int)(eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_CIRCULATORFAN, true);
        }


        [GenerateCommand(Name = "AmmoniaCommandClicked")]
        private void AmmoniaCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.ON);
                AmmoniaFan_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.OFF);
                AmmoniaFan_CheckSet((int)eOnOff.OFF);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_AMMONIAEXHAUSTFAN, true);
        }

        [GenerateCommand(Name = "TRSHandCommandClicked")]
        private void TRSHandCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.FORWARD);
                TRSHand_CheckSet((int)eLeftRight.RIGHT);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.BACKWARD);
                TRSHand_CheckSet((int)eLeftRight.LEFT);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERHAND, true);
        }
        [GenerateCommand(Name = "TRSClampCylinderFwdBwdCommandClicked")]
        private void TRSClampCylinderFwdBwdCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_FwdBwd, (int)eFwdBwd.FORWARD);
                TRSClampCylinderFwdBwd_CheckSet((int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_FwdBwd, (int)eFwdBwd.BACKWARD);
                TRSClampCylinderFwdBwd_CheckSet((int)eFwdBwd.BACKWARD);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TransferClampCylinder_FwdBwd, true);
        }
        [GenerateCommand(Name = "TRSClampCylinderUpDownCommandClicked")]
        private void TRSClampCylinderUpDownCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("위로"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_UpDown, (int)eUpDown.UP);
                TRSClampCylinderUpDown_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_UpDown, (int)eUpDown.DOWN);
                TRSClampCylinderUpDown_CheckSet((int)eUpDown.DOWN);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransferClimpCylinder_UpDown, true);
        }
        [GenerateCommand(Name = "TRSFlipClampCommandClicked")]
        private void TRSFlipClampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("위로"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nFlipClampCyl_UpDown, (int)eUpDown.UP);
                TRSFlipClampCylinderUpDown_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nFlipClampCyl_UpDown, (int)eUpDown.DOWN);
                TRSFlipClampCylinderUpDown_CheckSet((int)eUpDown.DOWN);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_FlipClimpCylinder, true);
        }
        [GenerateCommand(Name = "TRSHandTurnCommandClicked")]
        private void TRSHandTurnCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("오른쪽"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHandTurn_LeftRight, (int)eLeftRight.RIGHT);
                TRSHandTurn_CheckSet((int)eLeftRight.RIGHT);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHandTurn_LeftRight, (int)eLeftRight.LEFT);
                TRSHandTurn_CheckSet((int)eLeftRight.LEFT);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_Transfer_HandTurn, true);
        }
        [GenerateCommand(Name = "TRSBoxGuideCommandClicked")]
        private void TRSBoxGuideHandCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxGuide_FwdBwd, (int)eFwdBwd.FORWARD);
                TRSBoxGuideFwdBwd_CheckSet((int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxGuide_FwdBwd, (int)eFwdBwd.BACKWARD);
                TRSBoxGuideFwdBwd_CheckSet((int)eFwdBwd.BACKWARD);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_Guide, true);
        }
        [GenerateCommand(Name = "TRSClampCommandClicked")]
        private void TRSClampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.UNLOCK);
                TRSClamp_CheckSet((int)eLockUnlock.UNLOCK); 
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.LOCK);
                TRSClamp_CheckSet((int)eLockUnlock.LOCK);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCLAMP, true);
        }

        [GenerateCommand(Name = "TRSCoverCommandClicked")]
        private void TRSCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("위로"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.UP);
                TRSCover_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.DOWN);
                TRSCover_CheckSet((int)eUpDown.DOWN);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVER, true);
        }

        [GenerateCommand(Name = "TRSCoverVacCommandClicked")]
        private void TRSCoverVacCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("흡착"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.ON);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
				DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVAC, true);
            	DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);	
                TRSCoverVac_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.OFF);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.ON);
				DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVAC, true);
            	DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);
                TRSCoverVac_CheckSet((int)eOnOff.OFF);
                TRSCoverVacEject_CheckSet((int)eOnOff.ON);

                DateTime st = DateTime.Now;

                Task task = Task.Factory.StartNew(() =>
                {
                    bool run = true;
                    while(run)
                    {
                        TimeSpan ts = DateTime.Now - st;

                        if (ts.Milliseconds > 1000)
                        {
                            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
                            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);
                            TRSCoverVacEject_CheckSet((int)eOnOff.OFF);
                            run = false;
                            return;
                        }
                    }
                });
            }				
        }

        [GenerateCommand(Name = "UVLampCommandClicked")]
        private void UVLampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.ON);
                UVLamp_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.OFF);
                UVLamp_CheckSet((int)(eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSUVLAMP, true);
        }
        [GenerateCommand(Name = "FlipZoneLEDCommandClicked")]
        private void FlipZoneLEDCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nZoneLed_OnOff, (int)eOnOff.ON);
                FlipZoneLED_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nZoneLed_OnOff, (int)eOnOff.OFF);
                FlipZoneLED_CheckSet((int)(eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nFlipZone_Led, true);
        }

        [GenerateCommand(Name = "HotAirBlowerCommandClicked")]
        private void HotAirBlowerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.ON);
                HotAirBlower_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.OFF);
                HotAirBlower_CheckSet((int)((int)eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSHOTAIRBLOWER, true);
        }

        [GenerateCommand(Name = "HoperMotorCommandClicked")]
        private void HoperMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eOnOff.ON);
                HopperMotor_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eOnOff.OFF);
                HopperMotor_CheckSet((int)(eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TBSHOPPERMOTOR, true);
        }

        [GenerateCommand(Name = "FlipOutShutterCommandClicked")]
        private void FlipOutShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.UP);
                FlipOutShutter_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.DOWN);
                FlipOutShutter_CheckSet((int)eUpDown.DOWN);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPOUTSHUTTER, true);
        }

        [GenerateCommand(Name = "OutConveyorCommandClicked")]
        private void OutConveyorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.ON);
                FlipOutConveyor_CheckSet((int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.OFF);
                FlipOutConveyor_CheckSet((int)(eOnOff.OFF));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPOUTCONVEYOR, true);
        }




        [GenerateCommand(Name = "ImpactCylinder1CommandClicked")]
        private void ImpactCylinder1Command(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "전진")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L1_FwdBwd, (int)eFwdBwd.FORWARD);
                ImpactCylinder1_CheckSet((int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L1_FwdBwd, (int)eFwdBwd.BACKWARD);
                ImpactCylinder1_CheckSet((int)eFwdBwd.BACKWARD);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPBOXIMPACTL1R2, true);
        }
        [GenerateCommand(Name = "ImpactCylinder2CommandClicked")]
        private void ImpactCylinder2Command(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "전진")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L2_FwdBwd, (int)eFwdBwd.FORWARD);
                ImpactCylinder2_CheckSet((int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nImpCyl_L2_FwdBwd, (int)eFwdBwd.BACKWARD);
                ImpactCylinder2_CheckSet((int)eFwdBwd.BACKWARD);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPBOXIMPACTL2R1, true);
        }










        [GenerateCommand(Name = "ImpactCylinderCommandClicked")]
        private void ImpactCylinderCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.RUN);
                BoxImpactOperation_CheckSet((int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.STOP);
                BoxImpactOperation_CheckSet((int)eRunStop.STOP);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPBOXIMPACTOPERATION, true);
        }

        [GenerateCommand(Name = "UpperCoverCommandClicked")]
        private void UpperCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "위로")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.UP);
                UpperCover_CheckSet((int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.DOWN);
                UpperCover_CheckSet((int)(eUpDown.DOWN));
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPUPPERCOVER, true);
        }

        [GenerateCommand(Name = "LoaderShuttleCommandClicked")]
        private void LoaderShuttleCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.FORWARD);
                LoaderShuttle_CheckSet((int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.BACKWARD);
                LoaderShuttle_CheckSet((int)eFwdBwd.BACKWARD);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LOADERFWDBWD, true);
        }

        [GenerateCommand(Name = "LoaderShutterCommandClicked")]
        private void LoaderShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.DOWN);
                LoaderShutter_CheckSet((int)eUpDown.DOWN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.UP);
                LoaderShutter_CheckSet((int)eUpDown.UP);
            }

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_LOADERSHUTTERUPDOWN, true);
        }
        [GenerateCommand(Name = "FlipLocationCommandClicked")]
        private void FlipLocationCommand(RoutedEventArgs args)
        {
            bool result;
            double TargetPosition_TAxis_FaceUp = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceUp, out result);
            double TargetPosition_TAxis_FaceDown = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceDown, out result);
            double TargetVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dFlipMoveVel_Set, out result);
            
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("정위치"))
            {
                object[] argument = { TargetVelocity, TargetPosition_TAxis_FaceUp };

                FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_MOVE_ABS", argument);

                //LoaderShutter_CheckSet((int)eUpDown.DOWN);
            }
            else
            {
                object[] argument = { TargetVelocity, TargetPosition_TAxis_FaceDown };

                FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_MOVE_ABS", argument);
                //LoaderShutter_CheckSet((int)eUpDown.UP);
            }

        }
    }
}
