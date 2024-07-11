using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_UNIT_TOBBAB : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oTob_nProc_Req;
        private string reply_io_name = IoNameHelper.iTob_nProc_Reply;

        public F_UNIT_TOBBAB()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
