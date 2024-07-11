using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_UNIT_FLIP : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oFlip_nProc_Req;
        private string reply_io_name = IoNameHelper.iFlip_nProc_Reply;

        public F_UNIT_FLIP()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
