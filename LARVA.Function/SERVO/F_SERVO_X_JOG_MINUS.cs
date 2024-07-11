using EPLE.App;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_SERVO_X_JOG_MINUS : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oServo_nJogXMinus_Req;
        private string reply_io_name = IoNameHelper.iServo_nJogXMinus_Reply;

        public F_SERVO_X_JOG_MINUS()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
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
            bool result = false;

            bool jogFastMode = (bool)args[0];

            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oServo_nJogXMode_Set, jogFastMode);

            if (DataManager.Instance.SET_INT_DATA(RequestIoName, (int)eOnOff.ON))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (true)
                {
                    Thread.Sleep(100);

                    if (Abort)
                    {
                        return F_RESULT_ABORT;
                    }
                    else if (stopwatch.ElapsedMilliseconds > TimeoutMiliseconds)
                    {
                        return this.F_RESULT_TIMEOUT;
                    }
                    else if (DataManager.Instance.GET_INT_DATA(ReplyIoName, out result) == (int)eOnOff.ON)
                    {
                        Abort = false;
                        IsProcessing = false;
                        DataManager.Instance.SET_INT_DATA(RequestIoName, (int)eOnOff.OFF);
                        return this.F_RESULT_SUCCESS;
                    }
                    else
                    {
                        IsProcessing = true;
                        continue;
                    }
                }
            }
            else
            {
                return this.F_RESULT_FAIIL;
            }
        }
    }
}
