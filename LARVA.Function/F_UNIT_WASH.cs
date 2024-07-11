using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_UNIT_WASH : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oWash_nProc_Req;
        private string reply_io_name = IoNameHelper.iWash_nProc_Reply;

        public F_UNIT_WASH()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
