using EPLE.App;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_SERVO_HOME : AbstractFunction
    {
        public F_SERVO_HOME()
        {

        }

        public override bool AvailableStatus()
        {
            bool result = false;
            int available = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result);
            int accessMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            return result;
        }

        public override string Execute(object[] args = null)
        {
            if (args[0] == null)
                return F_RESULT_FAIIL;

            eServoIndex servo_index = (eServoIndex)args[0];

            switch(servo_index)
            {
                case eServoIndex.X_AXIS :
                    this.RequestIoName = IoNameHelper.oServo_nXHome_Req;
                    this.ReplyIoName = IoNameHelper.iServo_nXHome_Reply;
                    break;
                case eServoIndex.Y_AXIS :
                    this.RequestIoName = IoNameHelper.oServo_nYHome_Req;
                    this.ReplyIoName = IoNameHelper.iServo_nYHome_Reply;
                    break;
                case eServoIndex.Z_AXIS :
                    this.RequestIoName = IoNameHelper.oServo_nZHome_Req;
                    this.ReplyIoName = IoNameHelper.iServo_nZHome_Reply;
                    break;
                case eServoIndex.FLIP_AXIS :
                    this.RequestIoName = IoNameHelper.oServo_nFlipHome_Req;
                    this.ReplyIoName = IoNameHelper.iServo_nFlipHome_Reply;
                    break;
            }

            return base.Execute();
        }
    }
}
