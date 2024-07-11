using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core;
using LARVA.Scheduler.Model;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using System.Data;
using EPLE.IO;

namespace LARVA.Scheduler
{
    public class ScheduleQueueJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JOB executeJob = null;

            List<JOB> jobs = new List<JOB>();

            jobs = JobManager.Instance.SearchTaskByState("CREATED");

            foreach (JOB job in jobs)
            {
                if (job.STATE == "COMPLETED")
                {
                    JobManager.Instance.DeleteJob(job.ID);        
                }
                else if (job.STATE == "CREATED")
                {
                    LOCATION_INFO location = LocationManager.Instance.GetLocationByName(job.ORIGIN_LOCATION);
                     // FRONT에 위치한 BOX라면 QUEUED로 변경하여 실행
                    JobManager.Instance.UpdateJobStateQueued(job.ID);
                }              
            }




            //if (executingJob != null)
            //{
            //    switch(executingJob.JOB_TYPE)
            //    {
            //        case "TOBBAB_CHANGE":

            //            JobManager.Instance.UpdateJobStart(executingJob.ID);
            //            object[] args = new object[] { executingJob };                
            //            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_AUTO_TOBBAB_CHANGE", args, TobbabChangeResultCallback);
            //            break;
            //    }
            //}


            await Task.CompletedTask;
        } 

        private void TobbabChangeResultCallback(string functionName, object result)
        {
            
        }
    }
}
