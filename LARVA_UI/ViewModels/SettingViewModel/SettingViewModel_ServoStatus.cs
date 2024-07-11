using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Mask.Internal;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using EPLE.App;
using EPLE.IO;

namespace LARVA_UI.ViewModels
{
    public partial class SettingsViewModel
    {
        [GenerateProperty]
        private string servoErrNo_XAxis;
        [GenerateProperty]
        private string servoErrNo_YAxis;
        [GenerateProperty]
        private string servoErrNo_ZAxis;
        [GenerateProperty]
        private string servoErrNo_TAxis;
        [GenerateProperty]
        private string servoInPos_XAxis;
        [GenerateProperty]
        private string servoInPos_YAxis;
        [GenerateProperty]
        private string servoInPos_ZAxis;
        [GenerateProperty]
        private string servoInPos_TAxis;
        [GenerateProperty]
        private string servoError_XAxis;
        [GenerateProperty]
        private string servoError_YAxis;
        [GenerateProperty]
        private string servoError_ZAxis;
        [GenerateProperty]
        private string servoError_TAxis;
        [GenerateProperty]
        private string servoState_XAxis;
        [GenerateProperty]
        private string servoState_YAxis;
        [GenerateProperty]
        private string servoState_ZAxis;
        [GenerateProperty]
        private string servoState_TAxis;
        [GenerateProperty]
        private string servoReady_XAxis;
        [GenerateProperty]
        private string servoReady_YAxis;
        [GenerateProperty]
        private string servoReady_ZAxis;
        [GenerateProperty]
        private string servoReady_TAxis;
        [GenerateProperty]
        private string servoNotMoving_XAxis;
        [GenerateProperty]
        private string servoNotMoving_YAxis;
        [GenerateProperty]
        private string servoNotMoving_ZAxis;
        [GenerateProperty]
        private string servoNotMoving_TAxis;

        private string ServoInPosition(int axis)
        {
            bool result = true;
            string servoInPos = "0";

            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nTarget_IsIn, out result);
                        if (result)
                            servoInPos = val ? "1" : "0";
                        else
                            servoInPos = "0";
                    }
                    break;

                case 2:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nTarget_IsIn, out result);
                        if (result)
                            servoInPos = val ? "1" : "0";
                        else
                            servoInPos = "0";
                    }
                    break;

                case 3:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nTarget_IsIn, out result);
                        if (result)
                            servoInPos = val ? "1" : "0";
                        else
                            servoInPos = "0";
                    }
                    break;

                case 4:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nTarget_IsIn, out result);
                        if (result)
                            servoInPos = val ? "1" : "0";
                        else
                            servoInPos = "0";
                    }
                    break;
            }

            return servoInPos;
        }

        private string ServoError(int axis)
        {
            bool result = true;
            string servoError = "0";

            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_HasErr, out result);
                        if (result)
                            servoError = val ? "1" : "0";
                        else
                            servoError = "0";
                    }
                    break;

                case 2:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_HasErr, out result);
                        if (result)
                            servoError = val ? "1" : "0";
                        else
                            servoError = "0";
                    }
                    break;

                case 3:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_HasErr, out result);
                        if (result)
                            servoError = val ? "1" : "0";
                        else
                            servoError = "0";
                    }
                    break;

                case 4:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_HasErr, out result);
                        if (result)
                            servoError = val ? "1" : "0";
                        else
                            servoError = "0";
                    }
                    break;
            }

            return servoError;
        }

        private string ServoNotMoving(int axis)
        {
            bool result = true;
            string isNotMoving = "0";


            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsNotMove, out result);
                        if (result)
                            isNotMoving = val ? "1" : "0";
                        else
                            isNotMoving = "0";
                    }
                    break;

                case 2:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_IsNotMove, out result);
                        if (result)
                            isNotMoving = val ? "1" : "0";
                        else
                            isNotMoving = "0";
                    }
                    break;

                case 3:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_IsNotMove, out result);
                        if (result)
                            isNotMoving = val ? "1" : "0";
                        else
                            isNotMoving = "0";
                    }
                    break;

                case 4:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_IsNotMove, out result);
                        if (result)
                            isNotMoving = val ? "1" : "0";
                        else
                            isNotMoving = "0";
                    }
                    break;
            }

            return isNotMoving;
        }

        private string ServoReady(int axis)
        {
            bool result = true;
            string isDisabled = "1";

            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsDisabled, out result);
                        if (result)
                            isDisabled = val ? "0" : "1";
                        else
                            isDisabled = "0";
                    }
                    break;

                case 2:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_IsDisabled, out result);
                        if (result)
                            isDisabled = val ? "0" : "1";
                        else
                            isDisabled = "0";
                    }
                    break;

                case 3:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_IsDisabled, out result);
                        if (result)
                            isDisabled = val ? "0" : "1";
                        else
                            isDisabled = "0";
                    }
                    break;

                case 4:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_IsDisabled, out result);
                        if (result)
                            isDisabled = val ? "0" : "1";
                        else
                            isDisabled = "0";
                    }
                    break;
            }

            return isDisabled;
        }

        private string ServoStateConverter(int axis)
        {
            string returnState = "";
            bool result = true;
            bool isCalibrate = false;

            switch (axis)
            {
                case 1:
                    {
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";
                    }
                    break;
                case 2:
                    {
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";
                    }
                    break;
                case 3:
                    {
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";
                    }
                    break;
                case 4:
                    {
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";
                    }
                    break;
            }

            if (isCalibrate == false)
            {
                returnState = "0";
            }
            else
            {
                returnState = "1";
            }

            return returnState;

        }

    }
}
