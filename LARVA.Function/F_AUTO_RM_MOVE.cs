using EPLE.App;
using EPLE.Core;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using EPLE.IO;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_AUTO_RM_MOVE : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nTobbabChange_Req;
        private string reply_io_name = IoNameHelper.iAuto_nTobbabChange_Reply;

        private string job_id;

        public F_AUTO_RM_MOVE()
        {
            RequestIoName = request_io_name;
            ReplyIoName = reply_io_name;
        }

        public override bool CanExecute()
        {
            return AvailableStatus();
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

        //public override string Execute(object[] args = null)
        //{
        //    JOB job = (JOB)args[0];
        //    job_id = job.ID;

        //    bool result = false;

        //    if(int.TryParse(job.ORIGIN_LOCATION, out int locationId))
        //    {
        //        DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, locationId);
        //    }  
        //    else
        //    {
        //        DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, 0);
        //    }

        //    JobManager.Instance.UpdateJobStart(job_id);


        //    if (DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.ON))
        //    {
        //        Stopwatch stopwatch = new Stopwatch();
        //        stopwatch.Start();

        //        while (true)
        //        {
        //            Thread.Sleep(100);

        //            if (Abort)
        //            {
        //                return F_RESULT_ABORT;
        //            }
        //            else if (stopwatch.ElapsedMilliseconds > TimeoutMiliseconds)
        //            {
        //                Abort = false;
        //                IsProcessing = false;
        //                DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.OFF);
        //                return this.F_RESULT_TIMEOUT;
        //            }
        //            else if (DataManager.Instance.GET_INT_DATA(reply_io_name, out result) == (int)eOnOff.ON)
        //            {
        //                Abort = false;
        //                IsProcessing = false;
        //                DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.OFF);
        //                return this.F_RESULT_SUCCESS;
        //            }
        //            else
        //            {
        //                IsProcessing = true;
        //                continue;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return this.F_RESULT_FAIIL;
        //    }
        //}

        public override void ExecuteWhenSimulate()
        {
            throw new NotImplementedException();
        }

        public override void PostExecute()
        {
            DateTime start = DateTime.Now;


            while (DataManager.Instance.GET_INT_DATA(IoNameHelper.iAuto_nTobbabChange_Busy, out bool result) == (int)eOnOff.ON)
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
