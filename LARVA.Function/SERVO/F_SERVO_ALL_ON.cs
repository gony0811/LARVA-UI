using EPLE.App;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_SERVO_ALL_ON : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oServo_nAllOn_Req;
        private string reply_io_name = IoNameHelper.iServo_nAllOn_Reply;

        public F_SERVO_ALL_ON()
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
    }
}
