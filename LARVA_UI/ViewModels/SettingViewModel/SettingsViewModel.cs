using DevExpress.Charts.Designer.Native;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid.HitTest;
using DevExpress.Xpf.PivotGrid;
using DevExpress.Xpf.WindowsUI;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.IO;
using LARVA_UI.Views;
using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class SettingsViewModel
    {

        [GenerateProperty]
        private double setPosition_XAxis;
        [GenerateProperty]
        private double setPosition_YAxis;
        [GenerateProperty]
        private double setPosition_ZAxis;
        [GenerateProperty]
        private double setPosition_TAxis;
        [GenerateProperty]
        private double setVelocity_XAxis;
        [GenerateProperty]
        private double setVelocity_YAxis;
        [GenerateProperty]
        private double setVelocity_ZAxis;
        [GenerateProperty]
        private double setVelocity_TAxis;
        [GenerateProperty]
        private double actPosition_XAxis;
        [GenerateProperty]
        private double actPosition_YAxis;
        [GenerateProperty]
        private double actPosition_ZAxis;
        [GenerateProperty]
        private double actPosition_TAxis;
        [GenerateProperty]
        private double actVelocity_XAxis;
        [GenerateProperty]
        private double actVelocity_YAxis;
        [GenerateProperty]
        private double actVelocity_ZAxis;
        [GenerateProperty]
        private double actVelocity_TAxis;
        [GenerateProperty]
        private double targetPosition_XAxis;
        [GenerateProperty]
        private double targetPosition_YAxis;
        [GenerateProperty]
        private double targetPosition_ZAxis;
        [GenerateProperty]
        private double targetPosition_TAxis;
        [GenerateProperty]
        private double targetVelocity_XAxis;
        [GenerateProperty]
        private double targetVelocity_YAxis;
        [GenerateProperty]
        private double targetVelocity_ZAxis;
        [GenerateProperty]
        private double targetVelocity_TAxis;

     

        public SettingsViewModel()
        {
            DataManager.Instance.DataAccess.DataChangedEvent += MotionDataChangedEvent;
            //timer = new DispatcherTimer();
            //timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            //timer.Tick += Timer_Tick;
            //timer.Start();
            Initialize();
        }

        [GenerateCommand]
        private void TAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_TAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void ZAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_ZAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void YAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_YAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void XAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_XAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void TAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_TAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void ZAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_ZAxis = Convert.ToDouble(eventArgs.NewValue);
        }
        [GenerateCommand]
        private void YAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_YAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void XAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_XAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        private void MotionDataChangedEvent(object sender, DataChangedEventHandlerArgs e)
        {
            bool result = false;
            EPLE.IO.Data data = e.Data;

            if (data.Name.Equals(IoNameHelper.iXAxis_dSet_Pos))
            {
                SetPosition_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dSet_Velo))
            {
                SetVelocity_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dAct_Pos))
            {
                ActPosition_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dAct_Velo))
            {
                ActVelocity_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Pos))
            {
                SetPosition_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Velo))
            {
                SetVelocity_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dAct_Pos))
            {
                ActPosition_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dAct_Velo))
            {
                ActVelocity_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dSet_Pos))
            {
                SetPosition_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Velo))
            {
                SetVelocity_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dAct_Pos))
            {
                ActPosition_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dAct_Velo))
            {
                ActVelocity_ZAxis = (double)data.Value;
            }

            else if (data.Name.Equals(IoNameHelper.iTAxis_dSet_Pos))
            {
                SetPosition_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dSet_Velo))
            {
                SetVelocity_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dAct_Pos))
            {
                ActPosition_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dAct_Velo))
            {
                ActVelocity_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsCalibrated))
            {
                ServoState_XAxis = ServoStateConverter(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsCalibrated))
             {
                 ServoState_YAxis = ServoStateConverter(2);
             }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsCalibrated))
            {
                ServoState_ZAxis = ServoStateConverter(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsCalibrated))
            {
                ServoState_TAxis = ServoStateConverter(4);
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsDisabled))
            {
                ServoReady_XAxis = ServoReady(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsDisabled))
            {
                ServoReady_YAxis = ServoReady(2);
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsDisabled))
            {
                ServoReady_ZAxis = ServoReady(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsDisabled))
            {
                ServoReady_TAxis = ServoReady(4);
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsNotMove))
            {
                ServoNotMoving_XAxis = ServoNotMoving(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsNotMove))
            {
                ServoNotMoving_YAxis = ServoNotMoving(2);
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsNotMove))
            {
                ServoNotMoving_ZAxis = ServoNotMoving(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsNotMove))
            {
                ServoNotMoving_TAxis = ServoNotMoving(4);
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_HasErr))
            {
                ServoError_XAxis = ServoError(1);

                int ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iXAxis_nStatus_ErrId, out result);

                if (result)
                    ServoErrNo_XAxis = "ERROR ID : " + ErrId.ToString();
                else
                    ServoErrNo_XAxis = "ERROR ID : 0";
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_HasErr))
            {
                ServoError_YAxis = ServoError(2);
                int ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iYAxis_nStatus_ErrId, out result);
                if (result)
                    ServoErrNo_YAxis = "ERROR ID : " + ErrId.ToString();
                else
                    ServoErrNo_YAxis = "ERROR ID : 0";
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_HasErr))
            {
                ServoError_ZAxis = ServoError(3);
                int ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iZAxis_nStatus_ErrId, out result);
                if (result)
                    ServoErrNo_ZAxis = "ERROR ID : " + ErrId.ToString();
                else
                    ServoErrNo_ZAxis = "ERROR ID : 0";
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_HasErr))
            {
                ServoError_TAxis = ServoError(4);
                int ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTAxis_nStatus_ErrId, out result);
                if (result)
                    ServoErrNo_TAxis = "ERROR ID : " + ErrId.ToString();
                else
                    ServoErrNo_TAxis = "ERROR ID : 0";
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nTarget_IsIn))
            {
                ServoInPos_XAxis = ServoInPosition(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nTarget_IsIn))
            {
                ServoInPos_YAxis = ServoInPosition(2);
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nTarget_IsIn))
            {
                ServoInPos_ZAxis = ServoInPosition(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nTarget_IsIn))
            {
                ServoInPos_TAxis = ServoInPosition(4);
            }
            //else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_ErrId))
            //{
            //    ServoErrNo_XAxis = data.Value.ToString();
            //}
            //else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_ErrId))
            //{
            //    ServoErrNo_YAxis = data.Value.ToString();
            //}
            //else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_ErrId))
            //{
            //    ServoErrNo_ZAxis = data.Value.ToString();
            //}
            //else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_ErrId))
            //{
            //    ServoErrNo_TAxis = data.Value.ToString();
            //}
            else
            {

            }
        }


        private void Initialize()
        {
            bool result;

            //TargetPosition_XAxis = 0;

            ServoState_XAxis = ServoStateConverter((int)eAxisIndex.X_AXIS);
            ServoReady_XAxis = ServoReady((int)eAxisIndex.X_AXIS);
            ServoNotMoving_XAxis = ServoNotMoving((int)eAxisIndex.X_AXIS);

            ServoState_YAxis = ServoStateConverter((int)eAxisIndex.Y_AXIS);
            ServoReady_YAxis = ServoReady((int)eAxisIndex.Y_AXIS);
            ServoNotMoving_YAxis = ServoNotMoving((int)eAxisIndex.Y_AXIS);

            ServoState_ZAxis = ServoStateConverter((int)eAxisIndex.Z_AXIS);
            ServoReady_ZAxis = ServoReady((int)eAxisIndex.Z_AXIS);
            ServoNotMoving_ZAxis = ServoNotMoving((int)eAxisIndex.Z_AXIS);

            ServoState_TAxis = ServoStateConverter((int)eAxisIndex.FLIP_AXIS);
            ServoReady_TAxis = ServoReady((int)eAxisIndex.FLIP_AXIS);
            ServoNotMoving_TAxis = ServoNotMoving((int)eAxisIndex.FLIP_AXIS);

            ServoError_XAxis = ServoError((int)eAxisIndex.X_AXIS);
            ServoError_YAxis = ServoError((int)eAxisIndex.Y_AXIS);
            ServoError_ZAxis = ServoError((int)eAxisIndex.Z_AXIS);
            ServoError_TAxis = ServoError((int)eAxisIndex.FLIP_AXIS);

            ServoInPos_XAxis = ServoInPosition((int)eAxisIndex.X_AXIS);
            ServoInPos_YAxis = ServoInPosition((int)eAxisIndex.Y_AXIS);
            ServoInPos_ZAxis = ServoInPosition((int)eAxisIndex.Z_AXIS);
            ServoInPos_TAxis = ServoInPosition((int)eAxisIndex.FLIP_AXIS);

            int ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iXAxis_nStatus_ErrId, out result);

            if (result)
                ServoErrNo_XAxis = "ERROR ID : " + ErrId.ToString();
            else
                ServoErrNo_XAxis = "ERROR ID : 0";

            ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iYAxis_nStatus_ErrId, out result);

            if (result)
                ServoErrNo_YAxis = "ERROR ID : " + ErrId.ToString();
            else
                ServoErrNo_YAxis = "ERROR ID : 0";

            ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iZAxis_nStatus_ErrId, out result);

            if (result)
                ServoErrNo_ZAxis = "ERROR ID : " + ErrId.ToString();
            else
                ServoErrNo_ZAxis = "ERROR ID : 0";

            ErrId = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTAxis_nStatus_ErrId, out result);

            if (result)
                ServoErrNo_TAxis = "ERROR ID : " + ErrId.ToString();
            else
                ServoErrNo_TAxis = "ERROR ID : 0";

            double targetPosX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveSet_Pos, out result);

            if (result)
                TargetPosition_XAxis = targetPosX;
            else
                TargetPosition_XAxis = 0.0;

            double targetPosY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveSet_Pos, out result);

            if (result)
                TargetPosition_YAxis = targetPosY;
            else
                TargetPosition_YAxis = 0.0;

            double targetPosZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveSet_Pos, out result);

            if (result)
                TargetPosition_ZAxis = targetPosZ;
            else
                TargetPosition_ZAxis = 0.0;

            double targetPosT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dFlipMoveSet_Pos, out result);

            if (result)
                TargetPosition_TAxis = targetPosT;
            else
                TargetPosition_TAxis = 0.0;

            double targetVelX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveVel_Set, out result);

            if (result)
                TargetVelocity_XAxis = targetVelX;
            else
                TargetVelocity_XAxis = 0.0;

            double targetVelY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveVel_Set, out result);

            if (result)
                TargetVelocity_YAxis = targetVelY;
            else
                TargetVelocity_YAxis = 0.0;

            double targetVelZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveVel_Set, out result);

            if (result)
                TargetVelocity_ZAxis = targetVelZ;
            else
                TargetVelocity_ZAxis = 0.0;

            double targetVelT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dFlipMoveVel_Set, out result);

            if (result)
                TargetVelocity_TAxis = targetVelT;
            else
                TargetVelocity_TAxis = 0.0;

            double setPosX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dSet_Pos, out result);

            if (result) 
                SetPosition_XAxis = setPosX;
            else 
                SetPosition_XAxis = 0.0;

            double setVelX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_XAxis = setVelX;
            else
                SetVelocity_XAxis = 0.0;

            double actPosX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Pos, out result);

            if (result)
                ActPosition_XAxis = actPosX;
            else
                ActPosition_XAxis    = 0.0;

            double actVelX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_XAxis = actVelX;
            else
                ActVelocity_XAxis = 0.0;
         
            double setPosY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dSet_Pos, out result);

            if (result)
                SetPosition_YAxis = setPosY;
            else
                SetPosition_YAxis = 0.0;

            double setVelY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_YAxis = setVelY;
            else
                SetVelocity_YAxis = 0.0;

            double actPosY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Pos, out result);

            if (result)
                ActPosition_YAxis = actPosY;
            else
                ActPosition_YAxis = 0.0;

            double actVelY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_YAxis = actVelY;
            else
                ActVelocity_YAxis = 0.0;

            double setPosZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dSet_Pos, out result);

            if (result)
                SetPosition_ZAxis = setPosZ;
            else
                SetPosition_ZAxis = 0.0;

            double setVelZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_ZAxis = setVelZ;
            else
                SetVelocity_ZAxis = 0.0;

            double actPosZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Pos, out result);

            if (result)
                ActPosition_ZAxis = actPosZ;
            else
                ActPosition_ZAxis = 0.0;

            double actVelZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_ZAxis = actVelZ;
            else
                ActVelocity_ZAxis = 0.0;

            double setPosT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dSet_Pos, out result);

            if (result)
                SetPosition_TAxis = setPosT;
            else
                SetPosition_TAxis = 0.0;

            double setVelT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_TAxis = setVelT;
            else
                SetVelocity_TAxis = 0.0;

            double actPosT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dAct_Pos, out result);

            if (result)
                ActPosition_TAxis = actPosT;
            else
                ActPosition_TAxis = 0.0;

            double actVelT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_TAxis = actVelT;
            else
                ActVelocity_TAxis = 0.0;
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void XAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }


        [GenerateCommand]
        private void XAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        private bool IsRunning()
        {
            int opMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out bool result);

            if (result && (opMode != (int)eAccessMode.MANUAL))
            {
                string msg = string.Format("수동 모드에서만 조작 가능합니다.");
                WinUIMessageBox.Show(msg, "WARNING", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false) return;
            

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisServoResetClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_RESET");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Reset, true);
            //Thread.Sleep(500);
            //bool tmp = true;
            //tmp = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_HasErr, out bool result);
            //if (tmp == false)
            //{
            //    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Reset, false);
            //}
        }

        [GenerateCommand]
        private void XAxisServoDisableClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_OFF");
        }

        [GenerateCommand]
        private void XAxisServoEnableClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_ON");
        }

        [GenerateCommand]
        private void XAxisServoHome(RoutedEventArgs args)
        {

            if (IsRunning() == false) return;

            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper., true);
            object[] param = new object[] { eServoIndex.X_AXIS };
            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_HOME", param);
            //FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_TOBBAB_CHANGE");
        }

        [GenerateCommand]
        private void XAxisServoHalt(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_HALT");
        }

        [GenerateCommand]
        private void XAxisServoMoveTo(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveVel_Set, TargetVelocity_XAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveSet_Pos, TargetPosition_XAxis);

            object[] argument = { TargetVelocity_XAxis, TargetPosition_XAxis }; 

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_MOVE_ABS", argument);
            //FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_MOVE_ABS");
        }

        [GenerateCommand]
        private void XAxisServoMoveBy(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            object[] argument = { TargetVelocity_XAxis, TargetPosition_XAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_MOVE_REL", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Pos, (double)TargetPosition_XAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Velo, (double)TargetVelocity_XAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_MoveREL, true);
        }


        [GenerateCommand]
        private void YAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void YAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisServoReset(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_RESET");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Reset, true);
        }

        [GenerateCommand]
        private void YAxisServoDisable(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_OFF");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Off, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_On, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_BwOn, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_FwOn, false);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void YAxisServoEnable(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_ON");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Off, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_On, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_BwOn, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_FwOn, true);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dCtrl_Override, 100);
        }

        [GenerateCommand]
        private void YAxisServoHome(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            object[] param = new object[] { eServoIndex.Y_AXIS };
            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_HOME", param);
        }

        [GenerateCommand]
        private void YAxisServoHalt(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void YAxisServoMoveTo(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            object[] argument = { TargetVelocity_YAxis, TargetPosition_YAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, (double)TargetPosition_YAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Velo, (double)TargetVelocity_YAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void YAxisServoMoveBy(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            object[] argument = { TargetVelocity_YAxis, TargetPosition_YAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_MOVE_REL", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, (double)TargetPosition_YAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Velo, (double)TargetVelocity_YAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void ZAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }
        [GenerateCommand]
        private void ZAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {

            if (IsRunning() == false)
            {
                return;
            }

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisServoReset(RoutedEventArgs args)
        {

            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_RESET");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Reset, true);
        }

        [GenerateCommand]
        private void ZAxisServoDisable(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_OFF");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Off, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_On, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_BwOn, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_FwOn, false);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void ZAxisServoEnable(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_ON");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Off, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_On, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_BwOn, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_FwOn, true);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dCtrl_Override, 100);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisServoHome(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] param = new object[] { eServoIndex.Z_AXIS };
            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_HOME", param);
        }

        [GenerateCommand]
        private void ZAxisServoHalt(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void ZAxisServoMoveTo(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] argument = { TargetVelocity_ZAxis, TargetPosition_ZAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, (double)TargetPosition_ZAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Velo, (double)TargetVelocity_ZAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void ZAxisServoMoveBy(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] argument = { TargetVelocity_ZAxis, TargetPosition_ZAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_MOVE_REL", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, (double)TargetPosition_ZAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Velo, (double)TargetVelocity_ZAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }


        [GenerateCommand]
        private void TAxisServoReset(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_RESET");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Reset, true);
        }


        [GenerateCommand]
        private void TAxisServoDisable(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_OFF");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Off, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_On, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_BwOn, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_FwOn, false);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void TAxisServoEnable(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_ON");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Off, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_On, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_BwOn, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_FwOn, true);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dCtrl_Override, 100);
        }
        [GenerateCommand]
        private void TAxisServoHome(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] param = new object[] { eServoIndex.FLIP_AXIS };
            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_HOME", param);
        }

        [GenerateCommand]
        private void TAxisServoHalt(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_FLIP_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void TAxisServoMoveTo(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] argument = { TargetVelocity_TAxis, TargetPosition_TAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Pos, (double)TargetPosition_TAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Velo, (double)TargetVelocity_TAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TAxisServoMoveBy(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            object[] argument = { TargetVelocity_TAxis, TargetPosition_TAxis };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_FLIP_MOVE_REL", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Pos, (double)TargetPosition_TAxis);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Velo, (double)TargetVelocity_TAxis);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        void TabControlLoaded(RoutedEventArgs args)
        {
            //DXTabControl dXTabControl = (DXTabControl)args.Source;

            //#region AXIS


            //int axis_count = DataManager.Instance.GET_INT_DATA(IoNameHelper.IN_INT_MOTION_AXIS_COUNT, out bool result);

            //for (int i = 0; i < axis_count; i++)
            //{
            //    DXTabItem AxisTab = new DXTabItem();
            //    AxisTab.Header = "Axis " + i.ToString();
            //    MotionDiagnostic AxisDiagObj = new MotionDiagnostic();
            //    AxisDiagObj.ID = i;
            //    AxisDiagObj.AxisName = "Axis " + (i + 1).ToString();
            //    //AxisDiagObj.ControlSetClicked += AxDiagSetControl_Clicked;
            //    //AxisDiagObj.JogBwFastClicked += AxisDiagObj_JogBwFastClicked;
            //    //AxisDiagObj.JogBwSlowClicked += AxisDiagObj_JogBwSlowClicked;
            //    //AxisDiagObj.JogFwFastClicked += AxisDiagObj_JogFwFastClicked;
            //    //AxisDiagObj.JogFwSlowClicked += AxisDiagObj_JogFwSlowClicked;
            //    //AxisDiagObj.ResetClicked += AxisDiagObj_ResetClicked;
            //    //AxisDiagObj.MoveAbsClicked += AxisDiagObj_MoveAbsClicked;
            //    //AxisDiagObj.MoveRelClicked += AxisDiagObj_MoveRelClicked;
            //    AxisTab.Content = AxisDiagObj;
            //    dXTabControl.Items.Add(AxisTab);
            //    //MainContent.Items.Add(AxisTab);
            //}
            //#endregion
        }

        [GenerateCommand]
        void SelectionChanged(TabControlSelectionChangedEventArgs arg)
        {
            //DXTabItem tab = (DXTabItem)arg.NewSelectedItem;
            //StackPanel sp = (StackPanel)tab.Content;
            //// Motion Setting Tab
            //if (arg.NewSelectedIndex == 0)
            //{
            //    int axis_count = DataManager.Instance.GET_INT_DATA(IoNameHelper.IN_INT_MOTION_AXIS_COUNT, out bool result);

            //    for (int i = 0; i < axis_count; i++)
            //    {
            //        MotionSettingView motionSettingView = new MotionSettingView();
            //        motionSettingView.
            //    }
            //}
            
        }

        [GenerateCommand(Name = "ServoAllEnableClickedCommand")]
        private void ServoAllEnableClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_ON");
        }

        [GenerateCommand(Name = "ServoAllDisableClickedCommand")]
        private void ServoAllDisableClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_OFF");
        }

        [GenerateCommand(Name = "ServoAllResetClickedCommand")]
        private void ServoAllResetClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;

            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_RESET");
        }

        [GenerateCommand(Name = "ServoAllHomeClickedCommand")]
        private void ServoAllHomeClicked(RoutedEventArgs args)
        {
            if (IsRunning() == false) return;
            //FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_RESET");
        }

        [GenerateCommand(Name = "XAxisTargetPositionClickedCommand")]
        private void XAxisTargetPositionClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X축 이동 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetPosition_XAxis);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetPosition_XAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "XAxisTargetVelocityClickedCommand")]
        private void XAxisTargeVelocityClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X축 이동 속도 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}",TargetVelocity_XAxis);
            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetVelocity_XAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "YAxisTargetPositionClickedCommand")]
        private void YAxisTargetPositionClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y축 이동 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetPosition_YAxis);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetPosition_YAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "YAxisTargetVelocityClickedCommand")]
        private void YAxisTargeVelocityClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y축 이동 속도 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetVelocity_YAxis);
            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetVelocity_YAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "ZAxisTargetPositionClickedCommand")]
        private void ZAxisTargetPositionClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z축 이동 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetPosition_ZAxis);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetPosition_ZAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "ZAxisTargetVelocityClickedCommand")]
        private void ZAxisTargeVelocityClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z축 이동 속도 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetVelocity_ZAxis);
            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetVelocity_ZAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "TAxisTargetPositionClickedCommand")]
        private void TAxisTargetPositionClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("T축 이동 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetPosition_TAxis);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetPosition_TAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand(Name = "TAxisTargetVelocityClickedCommand")]
        private void TAxisTargeVelocityClicked(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("T축 이동 속도 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", TargetVelocity_TAxis);
            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TargetVelocity_TAxis = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }
    }
}
