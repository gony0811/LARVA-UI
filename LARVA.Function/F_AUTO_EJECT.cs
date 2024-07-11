using EPLE.App;
using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using EPLE.IO;
using LARVA.Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LARVA.Scheduler;
using System.Threading;

namespace LARVA.Function
{
    public class F_AUTO_EJECT : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nEject_Req;
        private string reply_io_name = IoNameHelper.iAuto_nEject_Reply;
        private string job_id;

        public F_AUTO_EJECT()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }


        public override string Execute(object[] args)
        {
            JOB job = (JOB)args[0];
            job_id = job.ID;

            LOCATION_INFO info = LocationManager.Instance.GetLocationList().Find((loc) => { return (loc.LOCATION_NAME == job.ORIGIN_LOCATION); });

            if (info != null)
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, Convert.ToInt32(info.LOCATION_ID));
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, 0);
            }

            return base.Execute(args);
        }

        public override void PostExecute()
        {
            DateTime start = DateTime.Now;


            while (DataManager.Instance.GET_INT_DATA(IoNameHelper.iAuto_nEject_Busy, out bool result) == (int)eOnOff.ON)
            {
                TimeSpan elipsed = DateTime.Now - start;

                if (elipsed > new TimeSpan(0, 10, 0))
                {
                    return;
                }

                Thread.SpinWait(100);
            }

            JobManager.Instance.UpdateJobComplete(job_id);
        }

    }
}
