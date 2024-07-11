using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.App
{
    public class IoValueHelper
    {
        public const bool ON = true;
        public const bool OFF = false;
    }

    public enum eAccessMode
    {
        NONE = 0,
        MANUAL = 1,
        AUTO = 2
    }

    public enum eAvailable
    {
        DOWN = 0,
        UP = 1,
    }

    public enum eAlarm
    {
        NO_ALARM = 0,
        LIGHT = 1,
        HEAVY = 2
    }
    public enum eLedCmd
    {
        OFF = 0,
        ON_100 = 2,
        ON_50 = 3
    }

    public enum eLockUnlock
    {
        NONE = 0,
        UNLOCK = 1,
        LOCK = 2,
        ERROR = 3
    }

    public enum eOnOff
    {
        OFF = 0,
        ON = 1,
    }

    public enum eOpenClose
    {
        NONE = 0,
        CLOSE = 1,
        OPEN = 2,
        ERROR = 3
    }

    public enum eRunStop
    {
        STOP = 0,
        RUN = 1,
    }

    public enum eRunStatus
    {
        IDLE = 0,
        RUNNING = 1,
        PAUSING = 2,
        PAUSED = 3
    }

    public enum eUpDown
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        ERROR = 3
    }

    public enum eFwdBwd
    {
        NONE = 0,
        BACKWARD = 1,
        FORWARD = 2,
        ERROR = 3
    }

    public enum eLeftRight
    {
        NONE = 0,
        LEFT = 1,
        RIGHT = 2,
        ERROR = 3
    }

    public enum eCoverAction
    {
        NONE = 0,
        OPEN_ACT = 1,
        CLOSE_ACT = 2
    }

    public enum eMotorCmd
    {
        NONE = 0,
        OFF = 1,
        CW = 2,
        CCW = 3
    }

    public enum eLocationId
    {
        TOBBAB = 241,
        FLIP_BOX_UP = 240,
        VISION = 245,
        WASH = 242,
        LOAD = 243,
        BUFFER = 244,
        FLIP_BOX_DOWN = 246,
        TBS_FLAT = 247,
        MOVING = 254,
        UNKNOWN = 255,

    }

    public enum eLocationType
    {
        UNKNOWN = 0,
        STOCKER = 1,
        PROCESS = 2,
        LOADER = 3,
        BUFFER = 4
    }

    public enum eAxisIndex
    {
        X_AXIS = 1,
        Y_AXIS = 2,
        Z_AXIS = 3,
        FLIP_AXIS = 4,
    }

    public class IoNameHelper
    {
        public const string vSys_nJobScheduler_RunStop = "vSys.nJobScheduler.RunStop";
        public const string oEqp_nOp_Mode = "oEqp.nOp.Mode";
        public const string oEqp_nOp_Pause = "oEqp.nOp.Pause";
        public const string oEqp_nAlarm_Reset = "oEqp.nAlarm.Reset";
        public const string oEqp_nBuzzer_Off = "oEqp.nBuzzer.Off";
        public const string oEqp_nOp_Abort = "oEqp.nOp.Abort";
        public const string oMain_nEmo_Stop = "oMain.nEmo.Stop";
        public const string oEqp_nHmi_Heartbeat = "oEqp.nHmi.Heartbeat";
        public const string oTrans_nMove_Req = "oTrans.nMove.Req";
        public const string oFlip_nProc_Req = "oFlip.nProc.Req";
        public const string oTob_nProc_Req = "oTob.nProc.Req";
        public const string oWash_nProc_Req = "oWash.nProc.Req";
        public const string oHvac_nProc_Req = "oHvac.nProc.Req";
        public const string oMot_nXHome_Req = "oMot.nXHome.Req";
        public const string oMot_nYHome_Req = "oMot.nYHome.Req";
        public const string oMot_nZHome_Req = "oMot.nZHome.Req";
        public const string oMot_nFlipHome_Req = "oMot.nFlipHome.Req";
        public const string oMain_nDoor_OpnCls = "oMain.nDoor.OpnCls";
        public const string oHvac_nCtrl_OnOff = "oHvac.nCtrl.OnOff";
        public const string oLoader_nShutter_UpDown = "oLoader.nShutter.UpDown";
        public const string oLoader_nShuttle_FwdBwd = "oLoader.nShuttle.FwdBwd";
        public const string oLoader_nLED_OnOff = "oLoader.nLED.OnOff";
        public const string oWash_nLED_OnOff = "oWash.nLED.OnOff";
        public const string oLed_nZone1_OnOff = "oLed.nZone1.OnOff";
        public const string oLed_nZone2_OnOff = "oLed.nZone2.OnOff";
        public const string oLed_nZone3_OnOff = "oLed.nZone3.OnOff";
        public const string oLed_nZone4_OnOff = "oLed.nZone4.OnOff";
        public const string oLed_nZone5_OnOff = "oLed.nZone5.OnOff";
        public const string oLed_nZone6_OnOff = "oLed.nZone6.OnOff";
        public const string oLed_nZone7_OnOff = "oLed.nZone7.OnOff";
        public const string oLed_nZone8_OnOff = "oLed.nZone8.OnOff";
        public const string oFlip_nUpperCover_UpDown = "oFlip.nUpperCover.UpDown";
        public const string oFlip_nImpCyl_L1_FwdBwd = "oFlip.nImpCyl_L1.FwdBwd";
        public const string oFlip_nImpCyl_L2_FwdBwd = "oFlip.nImpCyl_L2.FwdBwd";
        public const string oFlip_nBoxImpact_RunStop = "oFlip.nBoxImpact.RunStop";
        public const string oFlip_nOutConv_OnOff = "oFlip.nOutConv.OnOff";
        public const string oFlip_nOutShutter_UpDown = "oFlip.nOutShutter.UpDown";
        public const string oTBS_nHopper_Motor = "oTBS.nHopper.Motor";
        public const string oHotAir_nBlower_OnOff = "oHotAir.nBlower.OnOff";
        public const string oTBS_nUVLamp_OnOff = "oTBS.nUVLamp.OnOff";
        public const string oTBS_nMist_OnOff = "oTBS.nMist.OnOff";
        public const string oTBS_nMixer_Motor = "oTBS.nMixer.Motor";
        //public const string oTBS_nShutter_FwdBwd = "oTBS.nShutter.FwdBwd";

        public const string oTBS_nFlatMotorStandby_OnOff = "oTBS.nFlatMotorStandby.OnOff";
        public const string oTBS_nFlatMotor_RunStop = "oTBS.nFlatMotor.RunStop";
        public const string oTBS_nSwingCyl_RunStop = "oTBS.nSwingCyl.RunStop";
        public const string oWash_nWaterPump_OnOff = "oWash.nWaterPump.OnOff";
        public const string oWash_nTankValve_OnOff = "oWash.nTankValve.OnOff";
        public const string oWash_nWaterValve_OnOff = "oWash.nWaterValve.OnOff";
        public const string oWash_nBoxBlower_OnOff = "oWash.nBoxBlower.OnOff";
        public const string oAir_nCirculatorFan_OnOff = "oAir.nCirculatorFan.OnOff";
        public const string oTrans_nMove_RunStop = "oTrans.nMove.RunStop";
        public const string oTrans_nPick_RunStop = "oTrans.nPick.RunStop";
        public const string oTrans_nPlace_RunStop = "oTrans.nPlace.RunStop";
        public const string oTrans_nHand_LeftRight = "oTrans.nHand.LeftRight";
        public const string oTrans_BoxClamp_LockUnlock = "oTrans.BoxClamp.LockUnlock";
        public const string oTrans_nBoxCover_UpDown = "oTrans.nBoxCover.UpDown";
        public const string oTrans_nCoverVac_OnOff = "oTrans.nCoverVac.OnOff";
        public const string oTrans_nCoverVacEject_OnOFF = "oTrans.nCoverVacEject.OnOFF";
        public const string oTBS_nBoxStopper_UpDown = "oTBS.nBoxStopper.UpDown";
        public const string oAmmo_nExhaustFan_OnOff = "oAmmo.nExhaustFan.OnOff";
        public const string oAuto_nTobbabSupply_Req = "oAuto.nTobbabSupply.Req";
        public const string oAuto_nTobbabChange_Req = "oAuto.nTobbabChange.Req";
        public const string oAuto_nJellySupply_Req = "oAuto.nJellySupply.Req";
        public const string oAuto_nRiceSupply_Req = "oAuto.nRiceSupply.Req";
        public const string oAuto_nFeedStop_Req = "oAuto.nFeedStop.Req";
        public const string oAuto_nVision_Req = "oAuto.nVision.Req";
        public const string oAuto_nLoad_Req = "oAuto.nLoad.Req";
        public const string oAuto_nUnload_Req = "oAuto.nUnload.Req";
        public const string oAuto_nMist_Req = "oAuto.nMist.Req";
        public const string oAuto_nShipment_Req = "oAuto.nShipment.Req";
        public const string oAuto_nEject_Req = "oAuto.nEject.Req";
        public const string oAuto_nLoadComplete_Reply = "oAuto.nLoadComplete.Reply";
        public const string oAuto_nVisionComplete_Reply = "oAuto.nVisionComplete.Reply";

        public const string oParam_nTobbab_Timeout = "oParam.nTobbab.Timeout";
        public const string oParam_nPick_LocationId = "oParam.nPick.LocationId";
        public const string oParam_nPlace_LocationId = "oParam.nPlace.LocationId";
        public const string oParam_nPostPick_CoverAct = "oParam.nPostPick.CoverAct";
        public const string oParam_nPrePlace_CoverAct = "oParam.nPrePlace.CoverAct";
        public const string oParam_nTransMove_LocationId = "oParam.nTransMove.LocationId";
        public const string oParam_nBoxImpact_Duration = "oParam.nBoxImpact.Duration";
        public const string oParam_nOutConv_Duration = "oParam.nOutConv.Duration";
        public const string oParam_nFlipSwing_Duration = "oParam.nFlipSwing.Duration";
        public const string oParam_nTobbab_Weight = "oParam.nTobbab.Weight";
        public const string oParam_nWash_Duration = "oParam.nWash.Duration";
        public const string oParam_fHvac_TargetTemp = "oParam.fHvac.TargetTemp";
        public const string oParam_fHvac_TargetHumidity = "oParam.fHvac.TargetHumidity";
        public const string oParam_nMist_Duration = "oParam.nMist.Duration";
        public const string oParam_nFlat_Duration = "oParam.nFlat.Duration";
        public const string oParam_nBlow_Duration = "oParam.nBlow.Duration";
        public const string oParam_nTargetBox_LocationId = "oParam.nTargetBox.LocationId";
        public const string oParam_dFlipSwing_PlusAngle = "oParam.dFlipSwing.PlusAngle";
        public const string oParam_dFlipSwing_MinusAngle = "oParam.dFlipSwing.MinusAngle";
        public const string oParam_dFlipPos_BoxFaceUp = "oParam.dFlipPos.BoxFaceUp";
        public const string oParam_dFlipPos_BoxFaceDown = "oParam.dFlipPos.BoxFaceDown";
        public const string oParam_dXAxis_WaitPos = "oParam.dXAxis.WaitPos";
        public const string oParam_dYAxis_WaitPos = "oParam.dYAxis.WaitPos";
        public const string oParam_dZAxis_WaitPos = "oParam.dZAxis.WaitPos";
        public const string oParam_dTAxis_WaitPos = "oParam.dTAxis.WaitPos";

        public const string oExec_MAINSAFETYDOOROPEN = "oExec.MAINSAFETYDOOROPEN";
        public const string oExec_HVACONOFF = "oExec.HVACONOFF";
        public const string oExec_LOADERSHUTTERUPDOWN = "oExec.LOADERSHUTTERUPDOWN";
        public const string oExec_LOADERFWDBWD = "oExec.LOADERFWDBWD";
        public const string oExec_LOADERZONELED = "oExec.LOADERZONELED";
        public const string oExec_WASHZONELED = "oExec.WASHZONELED";
        public const string oExec_LEDZONE1 = "oExec.LEDZONE1";
        public const string oExec_LEDZONE2 = "oExec.LEDZONE2";
        public const string oExec_LEDZONE3 = "oExec.LEDZONE3";
        public const string oExec_LEDZONE4 = "oExec.LEDZONE4";
        public const string oExec_LEDZONE5 = "oExec.LEDZONE5";
        public const string oExec_LEDZONE6 = "oExec.LEDZONE6";
        public const string oExec_LEDZONE7 = "oExec.LEDZONE7";
        public const string oExec_LEDZONE8 = "oExec.LEDZONE8";
        public const string oExec_FLIPUPPERCOVER = "oExec.FLIPUPPERCOVER";
        public const string oExec_FLIPBOXIMPACTL1R2 = "oExec.FLIPBOXIMPACTL1R2";
        public const string oExec_FLIPBOXIMPACTL2R1 = "oExec.FLIPBOXIMPACTL2R1";
        public const string oExec_FLIPBOXIMPACTOPERATION = "oExec.FLIPBOXIMPACTOPERATION";
        public const string oExec_FLIPOUTCONVEYOR = "oExec.FLIPOUTCONVEYOR";
        public const string oExec_FLIPOUTSHUTTER = "oExec.FLIPOUTSHUTTER";
        public const string oExec_TBSHOPPERMOTOR = "oExec.TBSHOPPERMOTOR";
        public const string oExec_TBSHOTAIRBLOWER = "oExec.TBSHOTAIRBLOWER";
        public const string oExec_TBSUVLAMP = "oExec.TBSUVLAMP";
        public const string oExec_TBSMISTVALVE = "oExec.TBSMISTVALVE";
        public const string oExec_TBSMIXERMOTOR = "oExec.TBSMIXERMOTOR";
        //deprecated : changed mixer_shutter
        //public const string oExec_TBSSHUTTEROPEN = "oExec.TBSSHUTTEROPEN";
        public const string oExec_TBSFLATMOTOROPERATION = "oExec.TBSFLATMOTOROPERATION";
        public const string oExec_TBSSWINGCYLOPERATION = "oExec.TBSSWINGCYLOPERATION";
        public const string oExec_WASHWATERPUMP = "oExec.WASHWATERPUMP";
        public const string oExec_WASHWATERTANKVALVE = "oExec.WASHWATERTANKVALVE";
        public const string oExec_WASHWATERVALVE = "oExec.WASHWATERVALVE";
        public const string oExec_CIRCULATORFAN = "oExec.CIRCULATORFAN";
        public const string oExec_TRANSFERMOVE = "oExec.TRANSFERMOVE";
        public const string oExec_TRANSFERPICK = "oExec.TRANSFERPICK";
        public const string oExec_TRANSFERPLACE = "oExec.TRANSFERPLACE";
        public const string oExec_TRANSFERHAND = "oExec.TRANSFERHAND";
        public const string oExec_TRANSFERCLAMP = "oExec.TRANSFERCLAMP";
        public const string oExec_TRANSFERCOVER = "oExec.TRANSFERCOVER";
        public const string oExec_TRANSFERCOVERVAC = "oExec.TRANSFERCOVERVAC";
        public const string oExec_TRANSFERCOVERVACEJECT = "oExec.TRANSFERCOVERVACEJECT";
        public const string oExec_TBSBOXSTOPPERUPDOWN = "oExec.TBSBOXSTOPPERUPDOWN";
        public const string oExec_AMMONIAEXHAUSTFAN = "oExec.AMMONIAEXHAUSTFAN";
        public const string oExec_WASHBOXBLOWER = "oExec.WASHBOXBLOWER";
        public const string oExec_FLATMOTORSTANDBY = "oExec.FLATMOTORSTANDBY";


        public const string oServo_nXOn_Req = "oServo.nXOn.Req";
        public const string oServo_nYOn_Req = "oServo.nYOn.Req";
        public const string oServo_nZOn_Req = "oServo.nZOn.Req";
        public const string oServo_nFlipOn_Req = "oServo.nFlipOn.Req";
        public const string oServo_nXOff_Req = "oServo.nXOff.Req";
        public const string oServo_nYOff_Req = "oServo.nYOff.Req";
        public const string oServo_nZOff_Req = "oServo.nZOff.Req";
        public const string oServo_nFlipOff_Req = "oServo.nFlipOff.Req";
        public const string oServo_nXReset_Req = "oServo.nXReset.Req";
        public const string oServo_nYReset_Req = "oServo.nYReset.Req";
        public const string oServo_nZReset_Req = "oServo.nZReset.Req";
        public const string oServo_nFlipReset_Req = "oServo.nFlipReset.Req";


        public const string oServo_nAllOn_Req = "oServo.nAllOn.Req";
        public const string oServo_nAllOff_Req = "oServo.nAllOff.Req";
        public const string oServo_nAllReset_Req = "oServo.nAllReset.Req";
        public const string oServo_nXMoveABS_Req = "oServo.nXMoveABS.Req";
        public const string oServo_nYMoveABS_Req = "oServo.nYMoveABS.Req";
        public const string oServo_nZMoveABS_Req = "oServo.nZMoveABS.Req";
        public const string oServo_nFlipMoveABS_Req = "oServo.nFlipMoveABS.Req";
        public const string oServo_nXMoveREL_Req = "oServo.nXMoveREL.Req";
        public const string oServo_nYMoveREL_Req = "oServo.nYMoveREL.Req";
        public const string oServo_nZMoveREL_Req = "oServo.nZMoveREL.Req";
        public const string oServo_nFlipMoveREL_Req = "oServo.nFlipMoveREL.Req";
        public const string oServo_dXMoveSet_Pos = "oServo.dXMoveSet.Pos";
        public const string oServo_dYMoveSet_Pos = "oServo.dYMoveSet.Pos";
        public const string oServo_dZMoveSet_Pos = "oServo.dZMoveSet.Pos";
        public const string oServo_dFlipMoveSet_Pos = "oServo.dFlipMoveSet.Pos";
        public const string oServo_dXMoveSet_Dist = "oServo.dXMoveSet.Dist";
        public const string oServo_dYMoveSet_Dist = "oServo.dYMoveSet.Dist";
        public const string oServo_dZMoveSet_Dist = "oServo.dZMoveSet.Dist";
        public const string oServo_dFlipMoveSet_Dist = "oServo.dFlipMoveSet.Dist";
        public const string oServo_nXHome_Req = "oServo.nXHome.Req";
        public const string oServo_nYHome_Req = "oServo.nYHome.Req";
        public const string oServo_nZHome_Req = "oServo.nZHome.Req";
        public const string oServo_nFlipHome_Req = "oServo.nFlipHome.Req";
        public const string oServo_nXHalt_Req = "oServo.nXHalt.Req";
        public const string oServo_nYHalt_Req = "oServo.nYHalt.Req";
        public const string oServo_nZHalt_Req = "oServo.nZHalt.Req";
        public const string oServo_nFlipHalt_Req = "oServo.nFlipHalt.Req";
        public const string oServo_nJogXPlus_Req = "oServo.nJogXPlus.Req";
        public const string oServo_nJogYPlus_Req = "oServo.nJogYPlus.Req";
        public const string oServo_nJogZPlus_Req = "oServo.nJogZPlus.Req";
        public const string oServo_nJogFlipPlus_Req = "oServo.nJogFlipPlus.Req";
        public const string oServo_nJogXMinus_Req = "oServo.nJogXMinus.Req";
        public const string oServo_nJogYMinus_Req = "oServo.nJogYMinus.Req";
        public const string oServo_nJogZMinus_Req = "oServo.nJogZMinus.Req";
        public const string oServo_nJogFlipMinus_Req = "oServo.nJogFlipMinus.Req";
        public const string oServo_nJogXStop_Req = "oServo.nJogXStop.Req";
        public const string oServo_nJogYStop_Req = "oServo.nJogYStop.Req";
        public const string oServo_nJogZStop_Req = "oServo.nJogZStop.Req";
        public const string oServo_nJogFlipStop_Req = "oServo.nJogFlipStop.Req";
        public const string oServo_nJogXMode_Set = "oServo.nJogXMode.Set";
        public const string oServo_nJogYMode_Set = "oServo.nJogYMode.Set";
        public const string oServo_nJogZMode_Set = "oServo.nJogZMode.Set";
        public const string oServo_nJogFlipMode_Set = "oServo.nJogFlipMode.Set";
        public const string oServo_dJogXFastVel_Set = "oServo.dJogXFastVel.Set";
        public const string oServo_dJogYFastVel_Set = "oServo.dJogYFastVel.Set";
        public const string oServo_dJogZFastVel_Set = "oServo.dJogZFastVel.Set";
        public const string oServo_dJogFlipFastVel_Set = "oServo.dJogFlipFastVel.Set";
        public const string oServo_dJogXSlowVel_Set = "oServo.dJogXSlowVel.Set";
        public const string oServo_dJogYSlowVel_Set = "oServo.dJogYSlowVel.Set";
        public const string oServo_dJogZSlowVel_Set = "oServo.dJogZSlowVel.Set";
        // Home Velocity I/O 추가_mh.yun_20240701
        public static string oServo_dXHomeVel_Set = "oServo.dXHomeVel.Set";
        public static string oServo_dYHomeVel_Set = "oServo.dYHomeVel.Set";
        public static string oServo_dZHomeVel_Set = "oServo.dZHomeVel.Set";
        public static string oServo_dFlipHomeVel_Set = "oServo.dFlipHomeVel.Set";
        public const string oServo_dJogFlipSlowVel_Set = "oServo.dJogFlipSlowVel.Set";
        public const string oInterlock_nXAxis_OnOff = "oInterlock.nXAxis.OnOff";
        public const string oInterlock_nYAxis_OnOff = "oInterlock.nYAxis.OnOff";
        public const string oInterlock_nZAxis_OnOff = "oInterlock.nZAxis.OnOff";
        public const string oInterlock_nFlipAxis_OnOff = "oInterlock.nFlipAxis.OnOff";
        public const string oInterlock_nTRHand_OnOff = "oInterlock.nTRHand.OnOff";
        public const string oInterlock_nAll_OnOff = "oInterlock.nAll.OnOff";
        public const string oTrans_nHandTurn_LeftRight = "oTrans.nHandTurn.LeftRight";
        public const string oTrans_nClampCyl_FwdBwd = "oTrans.nClampCyl.FwdBwd";
        public const string oTrans_nClampCyl_UpDown = "oTrans.nClampCyl.UpDown";
        public const string oTrans_nFlipClampCyl_UpDown = "oTrans.nFlipClampCyl.UpDown";
        public const string oTrans_nBoxGuide_FwdBwd = "oTrans.nBoxGuide.FwdBwd";
        public const string oFlip_nZoneLed_OnOff = "oFlip.nZoneLed.OnOff";
        public const string oTob_nMixerShutter_OpnCls = "oTob.nMixerShutter.OpnCls";
        public const string oTob_nSupplyCyl_UpDown = "oTob.nSupplyCyl.UpDown";
        public const string oTbs_nFlatVibration_RunStop = "oTbs.nFlatVibration.RunStop";
        public const string oExec_Transfer_HandTurn = "oExec.Transfer.HandTurn";
        public const string oExec_TransferClampCylinder_FwdBwd = "oExec.TransferClampCylinder.FwdBwd";
        public const string oExec_nTransferClimpCylinder_UpDown = "oExec.nTransferClimpCylinder.UpDown";
        public const string oExec_nTransfer_FlipClimpCylinder = "oExec.nTransfer.FlipClimpCylinder";
        public const string oExec_nTransfer_Guide = "oExec.nTransfer.Guide";
        public const string oExec_nFlipZone_Led = "oExec.nFlipZone.Led";
        public const string oExec_nTobbobMix_Shutter = "oExec.nTobbobMix.Shutter";
        public const string oExec_nTobbobSupply_Cylinder = "oExec.nTobbobSupply.Cylinder";
        public const string oExec_nTbsFlat_Vibration = "oExec.nTbsFlat.Vibration";




        public const string oServo_dXMoveVel_Set = "oServo.dXMoveVel.Set";
        public const string oServo_dYMoveVel_Set = "oServo.dYMoveVel.Set";
        public const string oServo_dZMoveVel_Set = "oServo.dZMoveVel.Set";
        public const string oServo_dFlipMoveVel_Set = "oServo.dFlipMoveVel.Set";

        public const string iServo_nXOn_Reply = "iServo.nXOn.Reply";
        public const string iServo_nYOn_Reply = "iServo.nYOn.Reply";
        public const string iServo_nZOn_Reply = "iServo.nZOn.Reply";
        public const string iServo_nFlipOn_Reply = "iServo.nFlipOn.Reply";
        public const string iServo_nXOff_Reply = "iServo.nXOff.Reply";
        public const string iServo_nYOff_Reply = "iServo.nYOff.Reply";
        public const string iServo_nZOff_Reply = "iServo.nZOff.Reply";
        public const string iServo_nFlipOff_Reply = "iServo.nFlipOff.Reply";
        public const string iServo_nXReset_Reply = "iServo.nXReset.Reply";
        public const string iServo_nYReset_Reply = "iServo.nYReset.Reply";
        public const string iServo_nZReset_Reply = "iServo.nZReset.Reply";
        public const string iServo_nFlipReset_Reply = "iServo.nFlipReset.Reply";



        public const string iServo_nAllOn_Reply = "iServo.nAllOn.Reply";
        public const string iServo_nAllOff_Reply = "iServo.nAllOff.Reply";
        public const string iServo_nAllReset_Reply = "iServo.nAllReset.Reply";
        public const string iServo_nXMoveABS_Reply = "iServo.nXMoveABS.Reply";
        public const string iServo_nYMoveABS_Reply = "iServo.nYMoveABS.Reply";
        public const string iServo_nZMoveABS_Reply = "iServo.nZMoveABS.Reply";
        public const string iServo_nFlipMoveABS_Reply = "iServo.nFlipMoveABS.Reply";
        public const string iServo_nXMoveREL_Reply = "iServo.nXMoveREL.Reply";
        public const string iServo_nYMoveREL_Reply = "iServo.nYMoveREL.Reply";
        public const string iServo_nZMoveREL_Reply = "iServo.nZMoveREL.Reply";
        public const string iServo_nFlipMoveREL_Reply = "iServo.nFlipMoveREL.Reply";
        public const string iServo_nXHome_Reply = "iServo.nXHome.Reply";
        public const string iServo_nYHome_Reply = "iServo.nYHome.Reply";
        public const string iServo_nZHome_Reply = "iServo.nZHome.Reply";
        public const string iServo_nFlipHome_Reply = "iServo.nFlipHome.Reply";
        public const string iServo_nXHalt_Reply = "iServo.nXHalt.Reply";
        public const string iServo_nYHalt_Reply = "iServo.nYHalt.Reply";
        public const string iServo_nZHalt_Reply = "iServo.nZHalt.Reply";
        public const string iServo_nFlipHalt_Reply = "iServo.nFlipHalt.Reply";
        public const string iServo_nJogXPlus_Reply = "iServo.nJogXPlus.Reply";
        public const string iServo_nJogYPlus_Reply = "iServo.nJogYPlus.Reply";
        public const string iServo_nJogZPlus_Reply = "iServo.nJogZPlus.Reply";
        public const string iServo_nJogFlipPlus_Reply = "iServo.nJogFlipPlus.Reply";
        public const string iServo_nJogXMinus_Reply = "iServo.nJogXMinus.Reply";
        public const string iServo_nJogYMinus_Reply = "iServo.nJogYMinus.Reply";
        public const string iServo_nJogZMinus_Reply = "iServo.nJogZMinus.Reply";
        public const string iServo_nJogFlipMinus_Reply = "iServo.nJogFlipMinus.Reply";
        public const string iServo_nJogXStop_Reply = "iServo.nJogXStop.Reply";
        public const string iServo_nJogYStop_Reply = "iServo.nJogYStop.Reply";
        public const string iServo_nJogZStop_Reply = "iServo.nJogZStop.Reply";
        public const string iServo_nJogFlipStop_Reply = "iServo.nJogFlipStop.Reply";


        public const string iEqp_nOp_Mode = "iEqp.nOp.Mode";
        public const string iEqp_nAvailable_Status = "iEqp.nAvailable.Status";
        public const string iEqp_nAlarm_Status = "iEqp.nAlarm.Status";
        public const string iEqp_nInterlock_Status = "iEqp.nInterlock.Status";
        public const string iEqp_nRun_Status = "iEqp.nRun.Status";
        public const string iEqp_nRemote_Status = "iEqp.nRemote.Status";
        public const string iEqp_nPlc_Heartbeat = "iEqp.nPlc.Heartbeat";
        public const string iTrans_nMove_Reply = "iTrans.nMove.Reply";
        public const string iTrans_nMove_Busy = "iTrans.nMove.Busy";
        public const string iFlip_nProc_Reply = "iFlip.nProc.Reply";
        public const string iFlip_nProc_Busy = "iFlip.nProc.Busy";
        public const string iTob_nProc_Reply = "iTob.nProc.Reply";
        public const string iTob_nProc_Busy = "iTob.nProc.Busy";
        public const string iWash_nProc_Reply = "iWash.nProc.Reply";
        public const string iWash_nProc_Busy = "iWash.nProc.Busy";
        public const string iHvac_nProc_Reply = "iHvac.nProc.Reply";
        public const string iHvac_nProc_Busy = "iHvac.nProc.Busy";
        public const string iMot_nXHome_Reply = "iMot.nXHome.Reply";
        public const string iMot_nXHome_Busy = "iMot.nXHome.Busy";
        public const string iMot_nYHome_Reply = "iMot.nYHome.Reply";
        public const string iMot_nYHome_Busy = "iMot.nYHome.Busy";
        public const string iMot_nZHome_Reply = "iMot.nZHome.Reply";
        public const string iMot_nZHome_Busy = "iMot.nZHome.Busy";
        public const string iMot_nFlipHome_Reply = "iMot.nFlipHome.Reply";
        public const string iMot_nFlipHome_Busy = "iMot.nFlipHome.Busy";
        public const string iAuto_nTobbabSupply_Reply = "iAuto.nTobbabSupply.Reply";
        public const string iAuto_nTobbabSupply_Busy = "iAuto.nTobbabSupply.Busy";
        public const string iAuto_nTobbabChange_Reply = "iAuto.nTobbabChange.Reply";
        public const string iAuto_nTobbabChange_Busy = "iAuto.nTobbabChange.Busy";
        public const string iAuto_nJellySupply_Reply = "iAuto.nJellySupply.Reply";
        public const string iAuto_nJellySupply_Busy = "iAuto.nJellySupply.Busy";
        public const string iAuto_nRiceSupply_Reply = "iAuto.nRiceSupply.Reply";
        public const string iAuto_nRiceSupply_Busy = "iAuto.nRiceSupply.Busy";
        public const string iAuto_nFeedStop_Reply = "iAuto.nFeedStop.Reply";
        public const string iAuto_nFeedStop_Busy = "iAuto.nFeedStop.Busy";
        public const string iAuto_nVision_Reply = "iAuto.nVision.Reply";
        public const string iAuto_nVision_Busy = "iAuto.nVision.Busy";
        public const string iAuto_nLoad_Reply = "iAuto.nLoad.Reply";
        public const string iAuto_nLoad_Busy = "iAuto.nLoad.Busy";
        public const string iAuto_nUnload_Reply = "iAuto.nUnload.Reply";
        public const string iAuto_nUnload_Busy = "iAuto.nUnload.Busy";
        public const string iAuto_nMist_Reply = "iAuto.nMist.Reply";
        public const string iAuto_nMist_Busy = "iAuto.nMist.Busy";
        public const string iAuto_nShipment_Reply = "iAuto.nShipment.Reply";
        public const string iAuto_nShipment_Busy = "iAuto.nShipment.Busy";
        public const string iAuto_nEject_Reply = "iAuto.nEject.Reply";
        public const string iAuto_nEject_Busy = "iAuto.nEject.Busy";
        public const string iAuto_nLoadComplete_Req = "iAuto.nLoadComplete.Req";
        public const string iAuto_nVisionComplete_Req = "iAuto.nVisionComplete.Req";
        public const string iHotAir_fBlower_Temp = "iHotAir.fBlower.Temp";
        public const string iLoadcell_fWeight_Value = "iLoadcell.fWeight.Value";
        public const string iGas_fAmmo_Concent = "iGas.fAmmo.Concent";
        public const string iTH_fCurrent_Temp = "iTH.fCurrent.Temp";
        public const string iTH_fCurrent_Humidity = "iTH.fCurrent.Humidity";
        public const string iHvac_nFan_Status = "iHvac.nFan.Status";
        public const string iHvac_nCooling_Status = "iHvac.nCooling.Status";
        public const string iHvac_nHeating_Status = "iHvac.nHeating.Status";
        public const string iHvac_nHumidify_Status = "iHvac.nHumidify.Status";
        public const string iHvac_nDehumidify_Status = "iHvac.nDehumidify.Status";
        public const string iHvac_nAlarm_Status = "iHvac.nAlarm.Status";
        public const string iHvac_fCurrent_Temp = "iHvac.fCurrent.Temp";
        public const string iHvac_fCurrent_Humidity = "iHvac.fCurrent.Humidity";
        public const string iMain_nDoor_Open = "iMain.nDoor.Open";
        public const string iMixer_nDoor_Open = "iMixer.nDoor.Open";
        public const string iEmo_nIn_SwitchOn = "iEmo.nIn.SwitchOn";
        public const string iEmo_nOut_SwitchOn = "iEmo.nOut.SwitchOn";
        public const string iAir_nMainSupply_Valve = "iAir.nMainSupply.Valve";
        public const string iLoader_nShutter_UpDown = "iLoader.nShutter.UpDown";
        public const string iLoader_nShuttle_FwdBwd = "iLoader.nShuttle.FwdBwd";
        public const string iLoader_nBox_CheckSns = "iLoader.nBox.CheckSns";
        public const string iBuffer_nBox_Check_Sns = "iBuffer.nBox.Check.Sns";
        public const string iFlip_nBox_Check_Sns = "iFlip.nBox.Check.Sns";
        public const string iFlip_nUpperCover_UpDown = "iFlip.nUpperCover.UpDown";
        public const string iFlip_nImpCyl_L1_FwdBwd = "iFlip.nImpCyl_L1.FwdBwd";
        public const string iFlip_nImpCyl_L2_FwdBwd = "iFlip.nImpCyl_L2.FwdBwd";
        public const string iFlip_nImpCyl_R1_FwdBwd = "iFlip.nImpCyl_R1.FwdBwd";
        public const string iFlip_nImpCyl_R2_FwdBwd = "iFlip.nImpCyl_R2.FwdBwd";
        public const string iFlip_nOutShutter_UpDown = "iFlip.nOutShutter.UpDown";
        public const string iTrans_nClamp_LockUnlock = "iTrans.nClamp.LockUnlock";
        public const string iTrans_nHandLeft_FwdBwd = "iTrans.nHandLeft.FwdBwd";
        public const string iTrans_nBoxCover_UpDown = "iTrans.nBoxCover.UpDown";
        public const string iTrans_nBoxCoverVac_OnOff = "iTrans.nBoxCoverVac.OnOff";
        public const string iTrans_nHandLeftBox_CheckSns = "iTrans.nHandLeftBox.CheckSns";
        public const string iTrans_nHandRightBox_CheckSns = "iTrans.nHandRightBox.CheckSns";
        public const string iWash_nBox_CheckSns = "iWash.nBox.CheckSns";
        public const string iWash_nTankHi_LimitSns = "iWash.nTankHi.LimitSns";
        public const string iWash_nTankLo_LimitSns = "iWash.nTankLo.LimitSns";
        public const string iWash_nTank_FullSns = "iWash.nTank.FullSns";
        public const string iWash_nDrain_BlockSns = "iWash.nDrain.BlockSns";
        public const string iTBS_nBox_CheckSns = "iTBS.nBox.CheckSns";
        public const string iTBS_nFlatMotPositive_LimitSns = "iTBS.nFlatMotPositive.LimitSns";
        public const string iTBS_nFlatMotNegative_LimitSns = "iTBS.nFlatMotNegative.LimitSns";
        public const string iTBS_nShutterCyl_FwdBwd = "iTBS.nShutterCyl.FwdBwd";
        public const string iTBS_nSwingCyl_FwdBwd = "iTBS.nSwingCyl.FwdBwd";
        public const string iTBS_nBoxStopper_UpDown = "iTBS.nBoxStopper.UpDown";
        public const string iVision_nBox_CheckSns = "iVision.nBox.CheckSns";
        public const string iTrans_nServoX_HomeSns = "iTrans.nServoX.HomeSns";
        public const string iTrans_nServoZ_HomeSns = "iTrans.nServoZ.HomeSns";
        public const string iTrans_nServoY_HomeSns = "iTrans.nServoY.HomeSns";
        public const string iTrans_nServoFlip_HomeSns = "iTrans.nServoFlip.HomeSns";
        public const string iStock_nBox_111F = "iStock.nBox.111F";
        public const string iStock_nBox_111R = "iStock.nBox.111R";
        public const string iStock_nBox_112F = "iStock.nBox.112F";
        public const string iStock_nBox_112R = "iStock.nBox.112R";
        public const string iStock_nBox_113F = "iStock.nBox.113F";
        public const string iStock_nBox_113R = "iStock.nBox.113R";
        public const string iStock_nBox_121F = "iStock.nBox.121F";
        public const string iStock_nBox_121R = "iStock.nBox.121R";
        public const string iStock_nBox_122F = "iStock.nBox.122F";
        public const string iStock_nBox_122R = "iStock.nBox.122R";
        public const string iStock_nBox_123F = "iStock.nBox.123F";
        public const string iStock_nBox_123R = "iStock.nBox.123R";
        public const string iStock_nBox_131F = "iStock.nBox.131F";
        public const string iStock_nBox_131R = "iStock.nBox.131R";
        public const string iStock_nBox_132F = "iStock.nBox.132F";
        public const string iStock_nBox_132R = "iStock.nBox.132R";
        public const string iStock_nBox_133F = "iStock.nBox.133F";
        public const string iStock_nBox_133R = "iStock.nBox.133R";
        public const string iStock_nBox_141F = "iStock.nBox.141F";
        public const string iStock_nBox_141R = "iStock.nBox.141R";
        public const string iStock_nBox_142F = "iStock.nBox.142F";
        public const string iStock_nBox_142R = "iStock.nBox.142R";
        public const string iStock_nBox_143F = "iStock.nBox.143F";
        public const string iStock_nBox_143R = "iStock.nBox.143R";
        public const string iStock_nBox_151F = "iStock.nBox.151F";
        public const string iStock_nBox_151R = "iStock.nBox.151R";
        public const string iStock_nBox_152F = "iStock.nBox.152F";
        public const string iStock_nBox_152R = "iStock.nBox.152R";
        public const string iStock_nBox_153F = "iStock.nBox.153F";
        public const string iStock_nBox_153R = "iStock.nBox.153R";
        public const string iStock_nBox_211F = "iStock.nBox.211F";
        public const string iStock_nBox_211R = "iStock.nBox.211R";
        public const string iStock_nBox_212F = "iStock.nBox.212F";
        public const string iStock_nBox_212R = "iStock.nBox.212R";
        public const string iStock_nBox_213F = "iStock.nBox.213F";
        public const string iStock_nBox_213R = "iStock.nBox.213R";
        public const string iStock_nBox_221F = "iStock.nBox.221F";
        public const string iStock_nBox_221R = "iStock.nBox.221R";
        public const string iStock_nBox_222F = "iStock.nBox.222F";
        public const string iStock_nBox_222R = "iStock.nBox.222R";
        public const string iStock_nBox_223F = "iStock.nBox.223F";
        public const string iStock_nBox_223R = "iStock.nBox.223R";
        public const string iStock_nBox_231F = "iStock.nBox.231F";
        public const string iStock_nBox_231R = "iStock.nBox.231R";
        public const string iStock_nBox_232F = "iStock.nBox.232F";
        public const string iStock_nBox_232R = "iStock.nBox.232R";
        public const string iStock_nBox_233F = "iStock.nBox.233F";
        public const string iStock_nBox_233R = "iStock.nBox.233R";
        public const string iStock_nBox_241F = "iStock.nBox.241F";
        public const string iStock_nBox_241R = "iStock.nBox.241R";
        public const string iStock_nBox_242F = "iStock.nBox.242F";
        public const string iStock_nBox_242R = "iStock.nBox.242R";
        public const string iStock_nBox_243F = "iStock.nBox.243F";
        public const string iStock_nBox_243R = "iStock.nBox.243R";
        public const string iStock_nBox_251F = "iStock.nBox.251F";
        public const string iStock_nBox_251R = "iStock.nBox.251R";
        public const string iStock_nBox_252F = "iStock.nBox.252F";
        public const string iStock_nBox_252R = "iStock.nBox.252R";
        public const string iStock_nBox_253F = "iStock.nBox.253F";
        public const string iStock_nBox_253R = "iStock.nBox.253R";
        public const string iStock_nBox_311F = "iStock.nBox.311F";
        public const string iStock_nBox_311R = "iStock.nBox.311R";
        public const string iStock_nBox_312F = "iStock.nBox.312F";
        public const string iStock_nBox_312R = "iStock.nBox.312R";
        public const string iStock_nBox_313F = "iStock.nBox.313F";
        public const string iStock_nBox_313R = "iStock.nBox.313R";
        public const string iStock_nBox_321F = "iStock.nBox.321F";
        public const string iStock_nBox_321R = "iStock.nBox.321R";
        public const string iStock_nBox_322F = "iStock.nBox.322F";
        public const string iStock_nBox_322R = "iStock.nBox.322R";
        public const string iStock_nBox_323F = "iStock.nBox.323F";
        public const string iStock_nBox_323R = "iStock.nBox.323R";
        public const string iStock_nBox_331F = "iStock.nBox.331F";
        public const string iStock_nBox_331R = "iStock.nBox.331R";
        public const string iStock_nBox_332F = "iStock.nBox.332F";
        public const string iStock_nBox_332R = "iStock.nBox.332R";
        public const string iStock_nBox_333F = "iStock.nBox.333F";
        public const string iStock_nBox_333R = "iStock.nBox.333R";
        public const string iStock_nBox_341F = "iStock.nBox.341F";
        public const string iStock_nBox_341R = "iStock.nBox.341R";
        public const string iStock_nBox_342F = "iStock.nBox.342F";
        public const string iStock_nBox_342R = "iStock.nBox.342R";
        public const string iStock_nBox_343F = "iStock.nBox.343F";
        public const string iStock_nBox_343R = "iStock.nBox.343R";
        public const string iStock_nBox_351F = "iStock.nBox.351F";
        public const string iStock_nBox_351R = "iStock.nBox.351R";
        public const string iStock_nBox_352F = "iStock.nBox.352F";
        public const string iStock_nBox_352R = "iStock.nBox.352R";
        public const string iStock_nBox_353F = "iStock.nBox.353F";
        public const string iStock_nBox_353R = "iStock.nBox.353R";
        public const string iStock_nBox_411F = "iStock.nBox.411F";
        public const string iStock_nBox_411R = "iStock.nBox.411R";
        public const string iStock_nBox_412F = "iStock.nBox.412F";
        public const string iStock_nBox_412R = "iStock.nBox.412R";
        public const string iStock_nBox_413F = "iStock.nBox.413F";
        public const string iStock_nBox_413R = "iStock.nBox.413R";
        public const string iStock_nBox_421F = "iStock.nBox.421F";
        public const string iStock_nBox_421R = "iStock.nBox.421R";
        public const string iStock_nBox_422F = "iStock.nBox.422F";
        public const string iStock_nBox_422R = "iStock.nBox.422R";
        public const string iStock_nBox_423F = "iStock.nBox.423F";
        public const string iStock_nBox_423R = "iStock.nBox.423R";
        public const string iStock_nBox_431F = "iStock.nBox.431F";
        public const string iStock_nBox_431R = "iStock.nBox.431R";
        public const string iStock_nBox_432F = "iStock.nBox.432F";
        public const string iStock_nBox_432R = "iStock.nBox.432R";
        public const string iStock_nBox_433F = "iStock.nBox.433F";
        public const string iStock_nBox_433R = "iStock.nBox.433R";
        public const string iStock_nBox_441F = "iStock.nBox.441F";
        public const string iStock_nBox_441R = "iStock.nBox.441R";
        public const string iStock_nBox_442F = "iStock.nBox.442F";
        public const string iStock_nBox_442R = "iStock.nBox.442R";
        public const string iStock_nBox_443F = "iStock.nBox.443F";
        public const string iStock_nBox_443R = "iStock.nBox.443R";
        public const string iStock_nBox_451F = "iStock.nBox.451F";
        public const string iStock_nBox_451R = "iStock.nBox.451R";
        public const string iStock_nBox_452F = "iStock.nBox.452F";
        public const string iStock_nBox_452R = "iStock.nBox.452R";
        public const string iStock_nBox_453F = "iStock.nBox.453F";
        public const string iStock_nBox_453R = "iStock.nBox.453R";
        public const string iStock_nBox_511F = "iStock.nBox.511F";
        public const string iStock_nBox_511R = "iStock.nBox.511R";
        public const string iStock_nBox_512F = "iStock.nBox.512F";
        public const string iStock_nBox_512R = "iStock.nBox.512R";
        public const string iStock_nBox_513F = "iStock.nBox.513F";
        public const string iStock_nBox_513R = "iStock.nBox.513R";
        public const string iStock_nBox_521F = "iStock.nBox.521F";
        public const string iStock_nBox_521R = "iStock.nBox.521R";
        public const string iStock_nBox_522F = "iStock.nBox.522F";
        public const string iStock_nBox_522R = "iStock.nBox.522R";
        public const string iStock_nBox_523F = "iStock.nBox.523F";
        public const string iStock_nBox_523R = "iStock.nBox.523R";
        public const string iStock_nBox_531F = "iStock.nBox.531F";
        public const string iStock_nBox_531R = "iStock.nBox.531R";
        public const string iStock_nBox_532F = "iStock.nBox.532F";
        public const string iStock_nBox_532R = "iStock.nBox.532R";
        public const string iStock_nBox_533F = "iStock.nBox.533F";
        public const string iStock_nBox_533R = "iStock.nBox.533R";
        public const string iStock_nBox_541F = "iStock.nBox.541F";
        public const string iStock_nBox_541R = "iStock.nBox.541R";
        public const string iStock_nBox_542F = "iStock.nBox.542F";
        public const string iStock_nBox_542R = "iStock.nBox.542R";
        public const string iStock_nBox_543F = "iStock.nBox.543F";
        public const string iStock_nBox_543R = "iStock.nBox.543R";
        public const string iStock_nBox_551F = "iStock.nBox.551F";
        public const string iStock_nBox_551R = "iStock.nBox.551R";
        public const string iStock_nBox_552F = "iStock.nBox.552F";
        public const string iStock_nBox_552R = "iStock.nBox.552R";
        public const string iStock_nBox_553F = "iStock.nBox.553F";
        public const string iStock_nBox_553R = "iStock.nBox.553R";
        public const string iStock_nBox_611F = "iStock.nBox.611F";
        public const string iStock_nBox_611R = "iStock.nBox.611R";
        public const string iStock_nBox_612F = "iStock.nBox.612F";
        public const string iStock_nBox_612R = "iStock.nBox.612R";
        public const string iStock_nBox_613F = "iStock.nBox.613F";
        public const string iStock_nBox_613R = "iStock.nBox.613R";
        public const string iStock_nBox_621F = "iStock.nBox.621F";
        public const string iStock_nBox_621R = "iStock.nBox.621R";
        public const string iStock_nBox_622F = "iStock.nBox.622F";
        public const string iStock_nBox_622R = "iStock.nBox.622R";
        public const string iStock_nBox_623F = "iStock.nBox.623F";
        public const string iStock_nBox_623R = "iStock.nBox.623R";
        public const string iStock_nBox_631F = "iStock.nBox.631F";
        public const string iStock_nBox_631R = "iStock.nBox.631R";
        public const string iStock_nBox_632F = "iStock.nBox.632F";
        public const string iStock_nBox_632R = "iStock.nBox.632R";
        public const string iStock_nBox_633F = "iStock.nBox.633F";
        public const string iStock_nBox_633R = "iStock.nBox.633R";
        public const string iStock_nBox_641F = "iStock.nBox.641F";
        public const string iStock_nBox_641R = "iStock.nBox.641R";
        public const string iStock_nBox_642F = "iStock.nBox.642F";
        public const string iStock_nBox_642R = "iStock.nBox.642R";
        public const string iStock_nBox_643F = "iStock.nBox.643F";
        public const string iStock_nBox_643R = "iStock.nBox.643R";
        public const string iStock_nBox_651F = "iStock.nBox.651F";
        public const string iStock_nBox_651R = "iStock.nBox.651R";
        public const string iStock_nBox_652F = "iStock.nBox.652F";
        public const string iStock_nBox_652R = "iStock.nBox.652R";
        public const string iStock_nBox_653F = "iStock.nBox.653F";
        public const string iStock_nBox_653R = "iStock.nBox.653R";
        public const string iStock_nBox_711F = "iStock.nBox.711F";
        public const string iStock_nBox_711R = "iStock.nBox.711R";
        public const string iStock_nBox_712F = "iStock.nBox.712F";
        public const string iStock_nBox_712R = "iStock.nBox.712R";
        public const string iStock_nBox_713F = "iStock.nBox.713F";
        public const string iStock_nBox_713R = "iStock.nBox.713R";
        public const string iStock_nBox_721F = "iStock.nBox.721F";
        public const string iStock_nBox_721R = "iStock.nBox.721R";
        public const string iStock_nBox_722F = "iStock.nBox.722F";
        public const string iStock_nBox_722R = "iStock.nBox.722R";
        public const string iStock_nBox_723F = "iStock.nBox.723F";
        public const string iStock_nBox_723R = "iStock.nBox.723R";
        public const string iStock_nBox_731F = "iStock.nBox.731F";
        public const string iStock_nBox_731R = "iStock.nBox.731R";
        public const string iStock_nBox_732F = "iStock.nBox.732F";
        public const string iStock_nBox_732R = "iStock.nBox.732R";
        public const string iStock_nBox_733F = "iStock.nBox.733F";
        public const string iStock_nBox_733R = "iStock.nBox.733R";
        public const string iStock_nBox_741F = "iStock.nBox.741F";
        public const string iStock_nBox_741R = "iStock.nBox.741R";
        public const string iStock_nBox_742F = "iStock.nBox.742F";
        public const string iStock_nBox_742R = "iStock.nBox.742R";
        public const string iStock_nBox_743F = "iStock.nBox.743F";
        public const string iStock_nBox_743R = "iStock.nBox.743R";
        public const string iStock_nBox_751F = "iStock.nBox.751F";
        public const string iStock_nBox_751R = "iStock.nBox.751R";
        public const string iStock_nBox_752F = "iStock.nBox.752F";
        public const string iStock_nBox_752R = "iStock.nBox.752R";
        public const string iStock_nBox_753F = "iStock.nBox.753F";
        public const string iStock_nBox_753R = "iStock.nBox.753R";
        public const string iStock_nBox_811F = "iStock.nBox.811F";
        public const string iStock_nBox_811R = "iStock.nBox.811R";
        public const string iStock_nBox_812F = "iStock.nBox.812F";
        public const string iStock_nBox_812R = "iStock.nBox.812R";
        public const string iStock_nBox_813F = "iStock.nBox.813F";
        public const string iStock_nBox_813R = "iStock.nBox.813R";
        public const string iStock_nBox_821F = "iStock.nBox.821F";
        public const string iStock_nBox_821R = "iStock.nBox.821R";
        public const string iStock_nBox_822F = "iStock.nBox.822F";
        public const string iStock_nBox_822R = "iStock.nBox.822R";
        public const string iStock_nBox_823F = "iStock.nBox.823F";
        public const string iStock_nBox_823R = "iStock.nBox.823R";
        public const string iStock_nBox_831F = "iStock.nBox.831F";
        public const string iStock_nBox_831R = "iStock.nBox.831R";
        public const string iStock_nBox_832F = "iStock.nBox.832F";
        public const string iStock_nBox_832R = "iStock.nBox.832R";
        public const string iStock_nBox_833F = "iStock.nBox.833F";
        public const string iStock_nBox_833R = "iStock.nBox.833R";
        public const string iStock_nBox_841F = "iStock.nBox.841F";
        public const string iStock_nBox_841R = "iStock.nBox.841R";
        public const string iStock_nBox_842F = "iStock.nBox.842F";
        public const string iStock_nBox_842R = "iStock.nBox.842R";
        public const string iStock_nBox_843F = "iStock.nBox.843F";
        public const string iStock_nBox_843R = "iStock.nBox.843R";
        public const string iStock_nBox_851F = "iStock.nBox.851F";
        public const string iStock_nBox_851R = "iStock.nBox.851R";
        public const string iStock_nBox_852F = "iStock.nBox.852F";
        public const string iStock_nBox_852R = "iStock.nBox.852R";
        public const string iStock_nBox_853F = "iStock.nBox.853F";
        public const string iStock_nBox_853R = "iStock.nBox.853R";



        public const string iXAxis_dAct_Pos = "iXAxis.dAct.Pos";
        public const string iXAxis_dAct_Velo = "iXAxis.dAct.Velo";
        public const string iXAxis_dSet_Pos = "iXAxis.dSet.Pos";
        public const string iXAxis_dSet_Velo = "iXAxis.dSet.Velo";
        public const string iXAxis_dCtrl_Override = "iXAxis.dCtrl.Override";
        public const string iXAxis_nStatus_ErrId = "iXAxis.nStatus.ErrId";
        public const string iXAxis_nStatus_HasErr = "iXAxis.nStatus.HasErr";
        public const string iXAxis_nStatus_IsReady = "iXAxis.nStatus.IsReady";
        public const string iXAxis_nStatus_IsDisabled = "iXAxis.nStatus.IsDisabled";
        public const string iXAxis_nStatus_IsFwDisabled = "iXAxis.nStatus.IsFwDisabled";
        public const string iXAxis_nStatus_IsBwDisabled = "iXAxis.nStatus.IsBwDisabled";
        public const string iXAxis_nStatus_IsCalibrated = "iXAxis.nStatus.IsCalibrated";
        public const string iXAxis_nStatus_HasJob = "iXAxis.nStatus.HasJob";
        public const string iXAxis_nStatus_IsNotMove = "iXAxis.nStatus.IsNotMove";
        public const string iXAxis_nDir_IsPositive = "iXAxis.nDir.IsPositive";
        public const string iXAxis_nDir_IsNegative = "iXAxis.nDir.IsNegative";
        public const string iXAxis_nTarget_IsIn = "iXAxis.nTarget.IsIn";
        public const string iXAxis_nRange_IsIn = "iXAxis.nRange.IsIn";
        public const string iYAxis_dAct_Pos = "iYAxis.dAct.Pos";
        public const string iYAxis_dAct_Velo = "iYAxis.dAct.Velo";
        public const string iYAxis_dSet_Pos = "iYAxis.dSet.Pos";
        public const string iYAxis_dSet_Velo = "iYAxis.dSet.Velo";
        public const string iYAxis_dCtrl_Override = "iYAxis.dCtrl.Override";
        public const string iYAxis_nStatus_ErrId = "iYAxis.nStatus.ErrId";
        public const string iYAxis_nStatus_HasErr = "iYAxis.nStatus.HasErr";
        public const string iYAxis_nStatus_IsReady = "iYAxis.nStatus.IsReady";
        public const string iYAxis_nStatus_IsDisabled = "iYAxis.nStatus.IsDisabled";
        public const string iYAxis_nStatus_IsFwDisabled = "iYAxis.nStatus.IsFwDisabled";
        public const string iYAxis_nStatus_IsBwDisabled = "iYAxis.nStatus.IsBwDisabled";
        public const string iYAxis_nStatus_IsCalibrated = "iYAxis.nStatus.IsCalibrated";
        public const string iYAxis_nStatus_HasJob = "iYAxis.nStatus.HasJob";
        public const string iYAxis_nStatus_IsNotMove = "iYAxis.nStatus.IsNotMove";
        public const string iYAxis_nDir_IsPositive = "iYAxis.nDir.IsPositive";
        public const string iYAxis_nDir_IsNegative = "iYAxis.nDir.IsNegative";
        public const string iYAxis_nTarget_IsIn = "iYAxis.nTarget.IsIn";
        public const string iYAxis_nRange_IsIn = "iYAxis.nRange.IsIn";
        public const string iZAxis_dAct_Pos = "iZAxis.dAct.Pos";
        public const string iZAxis_dAct_Velo = "iZAxis.dAct.Velo";
        public const string iZAxis_dSet_Pos = "iZAxis.dSet.Pos";
        public const string iZAxis_dSet_Velo = "iZAxis.dSet.Velo";
        public const string iZAxis_dCtrl_Override = "iZAxis.dCtrl.Override";
        public const string iZAxis_nStatus_ErrId = "iZAxis.nStatus.ErrId";
        public const string iZAxis_nStatus_HasErr = "iZAxis.nStatus.HasErr";
        public const string iZAxis_nStatus_IsReady = "iZAxis.nStatus.IsReady";
        public const string iZAxis_nStatus_IsDisabled = "iZAxis.nStatus.IsDisabled";
        public const string iZAxis_nStatus_IsFwDisabled = "iZAxis.nStatus.IsFwDisabled";
        public const string iZAxis_nStatus_IsBwDisabled = "iZAxis.nStatus.IsBwDisabled";
        public const string iZAxis_nStatus_IsCalibrated = "iZAxis.nStatus.IsCalibrated";
        public const string iZAxis_nStatus_HasJob = "iZAxis.nStatus.HasJob";
        public const string iZAxis_nStatus_IsNotMove = "iZAxis.nStatus.IsNotMove";
        public const string iZAxis_nDir_IsPositive = "iZAxis.nDir.IsPositive";
        public const string iZAxis_nDir_IsNegative = "iZAxis.nDir.IsNegative";
        public const string iZAxis_nTarget_IsIn = "iZAxis.nTarget.IsIn";
        public const string iZAxis_nRange_IsIn = "iZAxis.nRange.IsIn";
        public const string iTAxis_dAct_Pos = "iTAxis.dAct.Pos";
        public const string iTAxis_dAct_Velo = "iTAxis.dAct.Velo";
        public const string iTAxis_dSet_Pos = "iTAxis.dSet.Pos";
        public const string iTAxis_dSet_Velo = "iTAxis.dSet.Velo";
        public const string iTAxis_dCtrl_Override = "iTAxis.dCtrl.Override";
        public const string iTAxis_nStatus_ErrId = "iTAxis.nStatus.ErrId";
        public const string iTAxis_nStatus_HasErr = "iTAxis.nStatus.HasErr";
        public const string iTAxis_nStatus_IsReady = "iTAxis.nStatus.IsReady";
        public const string iTAxis_nStatus_IsDisabled = "iTAxis.nStatus.IsDisabled";
        public const string iTAxis_nStatus_IsFwDisabled = "iTAxis.nStatus.IsFwDisabled";
        public const string iTAxis_nStatus_IsBwDisabled = "iTAxis.nStatus.IsBwDisabled";
        public const string iTAxis_nStatus_IsCalibrated = "iTAxis.nStatus.IsCalibrated";
        public const string iTAxis_nStatus_HasJob = "iTAxis.nStatus.HasJob";
        public const string iTAxis_nStatus_IsNotMove = "iTAxis.nStatus.IsNotMove";
        public const string iTAxis_nDir_IsPositive = "iTAxis.nDir.IsPositive";
        public const string iTAxis_nDir_IsNegative = "iTAxis.nDir.IsNegative";
        public const string iTAxis_nTarget_IsIn = "iTAxis.nTarget.IsIn";
        public const string iTAxis_nRange_IsIn = "iTAxis.nRange.IsIn";

        public const string iTrans_nClampCyl_FwdBwd = "iTrans.nClampCyl.FwdBwd";
        public const string iTrans_nClampCyl_UpDown = "iTrans.nClampCyl.UpDown";
        public const string iTrans_nHandTurn_LeftRight = "iTrans.nHandTurn.LeftRight";
        public const string iTransfer_nBoxSnsRight_OnOff = "iTransfer.nBoxSnsRight.OnOff";
        public const string iTransfer_nBoxSnsMiddle_OnOff = "iTransfer.nBoxSnsMiddle.OnOff";
        public const string iTransfer_nBoxSnsLeft_OnOff = "iTransfer.nBoxSnsLeft.OnOff";
        public const string iTob_nMixerShutter_OpnCls = "iTob.nMixerShutter.OpnCls";
        public const string iTob_nSupplyCyl_UpDown = "iTob.nSupplyCyl.UpDown";
        public const string iTob_nFlipClamp_UpDown = "iTob.nFlipClamp.UpDown";
        public const string iTob_nGuide_FwdBwd = "iTob.nGuide.FwdBwd";


        public const string oXAxis_dTarget_Pos = "oXAxis.dTarget.Pos";
        public const string oXAxis_dTarget_Velo = "oXAxis.dTarget.Velo";
        public const string oXAxis_dTarget_Acc = "oXAxis.dTarget.Acc";
        public const string oXAxis_dTarget_Dcc = "oXAxis.dTarget.Dcc";
        public const string oXAxis_dTarget_Jerk = "oXAxis.dTarget.Jerk";
        public const string oXAxis_dCtrl_Override = "oXAxis.dCtrl.Override";
        public const string oXAxis_nServo_On = "oXAxis.nServo.On";
        public const string oXAxis_nServo_FwOn = "oXAxis.nServo.FwOn";
        public const string oXAxis_nServo_BwOn = "oXAxis.nServo.BwOn";
        public const string oXAxis_nServo_Off = "oXAxis.nServo.Off";
        public const string oXAxis_nServo_MoveABS = "oXAxis.nServo.MoveABS";
        public const string oXAxis_nServo_MoveREL = "oXAxis.nServo.MoveREL";
        public const string oXAxis_nServo_Halt = "oXAxis.nServo.Halt";
        public const string oXAxis_nServo_Home = "oXAxis.nServo.Home";
        public const string oXAxis_nServo_Reset = "oXAxis.nServo.Reset";
        public const string oXAxis_nJog_Mode = "oXAxis.nJog.Mode";
        public const string oXAxis_nJog_FwFast = "oXAxis.nJog.FwFast";
        public const string oXAxis_nJog_BwFast = "oXAxis.nJog.BwFast";
        public const string oXAxis_nJog_FwSlow = "oXAxis.nJog.FwSlow";
        public const string oXAxis_nJog_BwSlow = "oXAxis.nJog.BwSlow";
        public const string oYAxis_dTarget_Pos = "oYAxis.dTarget.Pos";
        public const string oYAxis_dTarget_Velo = "oYAxis.dTarget.Velo";
        public const string oYAxis_dTarget_Acc = "oYAxis.dTarget.Acc";
        public const string oYAxis_dTarget_Dcc = "oYAxis.dTarget.Dcc";
        public const string oYAxis_dTarget_Jerk = "oYAxis.dTarget.Jerk";
        public const string oYAxis_dCtrl_Override = "oYAxis.dCtrl.Override";
        public const string oYAxis_nServo_On = "oYAxis.nServo.On";
        public const string oYAxis_nServo_FwOn = "oYAxis.nServo.FwOn";
        public const string oYAxis_nServo_BwOn = "oYAxis.nServo.BwOn";
        public const string oYAxis_nServo_Off = "oYAxis.nServo.Off";
        public const string oYAxis_nServo_MoveABS = "oYAxis.nServo.MoveABS";
        public const string oYAxis_nServo_MoveREL = "oYAxis.nServo.MoveREL";
        public const string oYAxis_nServo_Halt = "oYAxis.nServo.Halt";
        public const string oYAxis_nServo_Home = "oYAxis.nServo.Home";
        public const string oYAxis_nServo_Reset = "oYAxis.nServo.Reset";
        public const string oYAxis_nJog_Mode = "oYAxis.nJog.Mode";
        public const string oYAxis_nJog_FwFast = "oYAxis.nJog.FwFast";
        public const string oYAxis_nJog_BwFast = "oYAxis.nJog.BwFast";
        public const string oYAxis_nJog_FwSlow = "oYAxis.nJog.FwSlow";
        public const string oYAxis_nJog_BwSlow = "oYAxis.nJog.BwSlow";
        public const string oZAxis_dTarget_Pos = "oZAxis.dTarget.Pos";
        public const string oZAxis_dTarget_Velo = "oZAxis.dTarget.Velo";
        public const string oZAxis_dTarget_Acc = "oZAxis.dTarget.Acc";
        public const string oZAxis_dTarget_Dcc = "oZAxis.dTarget.Dcc";
        public const string oZAxis_dTarget_Jerk = "oZAxis.dTarget.Jerk";
        public const string oZAxis_dCtrl_Override = "oZAxis.dCtrl.Override";
        public const string oZAxis_nServo_On = "oZAxis.nServo.On";
        public const string oZAxis_nServo_FwOn = "oZAxis.nServo.FwOn";
        public const string oZAxis_nServo_BwOn = "oZAxis.nServo.BwOn";
        public const string oZAxis_nServo_Off = "oZAxis.nServo.Off";
        public const string oZAxis_nServo_MoveABS = "oZAxis.nServo.MoveABS";
        public const string oZAxis_nServo_MoveREL = "oZAxis.nServo.MoveREL";
        public const string oZAxis_nServo_Halt = "oZAxis.nServo.Halt";
        public const string oZAxis_nServo_Home = "oZAxis.nServo.Home";
        public const string oZAxis_nServo_Reset = "oZAxis.nServo.Reset";
        public const string oZAxis_nJog_Mode = "oZAxis.nJog.Mode";
        public const string oZAxis_nJog_FwFast = "oZAxis.nJog.FwFast";
        public const string oZAxis_nJog_BwFast = "oZAxis.nJog.BwFast";
        public const string oZAxis_nJog_FwSlow = "oZAxis.nJog.FwSlow";
        public const string oZAxis_nJog_BwSlow = "oZAxis.nJog.BwSlow";
        public const string oTAxis_dTarget_Pos = "oTAxis.dTarget.Pos";
        public const string oTAxis_dTarget_Velo = "oTAxis.dTarget.Velo";
        public const string oTAxis_dTarget_Acc = "oTAxis.dTarget.Acc";
        public const string oTAxis_dTarget_Dcc = "oTAxis.dTarget.Dcc";
        public const string oTAxis_dTarget_Jerk = "oTAxis.dTarget.Jerk";
        public const string oTAxis_dCtrl_Override = "oTAxis.dCtrl.Override";
        public const string oTAxis_nServo_On = "oTAxis.nServo.On";
        public const string oTAxis_nServo_FwOn = "oTAxis.nServo.FwOn";
        public const string oTAxis_nServo_BwOn = "oTAxis.nServo.BwOn";
        public const string oTAxis_nServo_Off = "oTAxis.nServo.Off";
        public const string oTAxis_nServo_MoveABS = "oTAxis.nServo.MoveABS";
        public const string oTAxis_nServo_MoveREL = "oTAxis.nServo.MoveREL";
        public const string oTAxis_nServo_Halt = "oTAxis.nServo.Halt";
        public const string oTAxis_nServo_Home = "oTAxis.nServo.Home";
        public const string oTAxis_nServo_Reset = "oTAxis.nServo.Reset";
        public const string oTAxis_nJog_Mode = "oTAxis.nJog.Mode";
        public const string oTAxis_nJog_FwFast = "oTAxis.nJog.FwFast";
        public const string oTAxis_nJog_BwFast = "oTAxis.nJog.BwFast";
        public const string oTAxis_nJog_FwSlow = "oTAxis.nJog.FwSlow";
        public const string oTAxis_nJog_BwSlow = "oTAxis.nJog.BwSlow";
        // 대기위치 추가_mh.yun_240226


    }
}
