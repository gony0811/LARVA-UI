﻿using EPLE.Core;
using LARVA.Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using System.Collections;
using Quartz.Logging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using EPLE.Core.Manager.Model;

namespace LARVA.Scheduler
{
    public class JobManager
    {
        public static readonly JobManager Instance = new JobManager();
        public JobScheduler Scheduler { get; private set; }
        private string _dbPath;
        public JobManager() 
        {   
            Scheduler = new JobScheduler();
        }

        public string DatabaseFilePath { set { _dbPath = value; } }

        public void Initialize(string dbPath)
        {
            _dbPath = Path.GetFullPath(dbPath);
            Task task = Scheduler.Start();
        }



        public void CreateNewJob(string jobType, int priority, string creator, string origin_location)
        {
            string dbFilePath = _dbPath;

            string queryCommand = @"INSERT INTO sys_job_info([ID],[PRIORITY],[JOBTYPE],[STATE],[ORIGIN_LOCATION],[CREATEDTIME],[QUEUEDTIME],[CREATOR]) VALUES (@ID, @PRIORITY, @JOBTYPE, @STATE, @ORIGIN_LOCATION, @CREATEDTIME, @QUEUEDTIME, @CREATOR)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@ID"] = Guid.NewGuid().ToString().ToUpper();
            parameters["@PRIORITY"] = priority.ToString();
            parameters["@JOBTYPE"] = jobType;
            //parameters["@CARRIERID"] = "";
            //parameters["@STEPID"] = "";
            parameters["@STATE"] = "CREATED";

            
            parameters["@ORIGIN_LOCATION"] = origin_location;
            parameters["@CREATEDTIME"] = DateTime.Now;
            parameters["@QUEUEDTIME"] = DateTime.Now;

            //parameters["@STARTEDTIME"] = DateTime.Now;
            //parameters["@COMPLETEDTIME"] = DateTime.Now;
            parameters["@CREATOR"] = creator;

            DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);
        }

        public List<JOB> SearchJobInfoByName(string locationName)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"SELECT * FROM sys_job_info WHERE ORIGIN_LOCATION = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@ORIGIN_LOCATION"] = locationName;

            List<JOB> jobList = new List<JOB>();
            DataTable dt = DbHandler.Instance.ExecuteQuery(dbFilePath, queryCommand, parameters);


            foreach (DataRow dr in dt.Rows)
            {
                JOB job = new JOB();

                job.ID = dr["ID"] as string;
                job.PRIORITY = (dr["PRIORITY"] as long?) ?? 0;
                job.STATE = dr["STATE"] as string;
                job.JOB_TYPE = dr["JOBTYPE"] as string;
                job.CARRIER_ID = dr["CARRIERID"] as string;
                job.ORIGIN_LOCATION = dr["ORIGIN_LOCATION"] as string;
                job.CREATED_TIME = (dr["CREATEDTIME"] as DateTime?) ?? DateTime.Now;
                job.QUEUED_TIME = (dr["QUEUEDTIME"] as DateTime?) ?? DateTime.Now;
                job.STARTED_TIME = (dr["STARTEDTIME"] as DateTime?) ?? DateTime.Now;
                job.COMPLETED_TIME = (dr["COMPLETEDTIME"] as DateTime?) ?? DateTime.Now;
                job.CREATOR = dr["CREATOR"] as string;

                jobList.Add(job);
            }

            return jobList;
        }

        public void UpdateJobStateQueued(string job_id, string carrierId = "", string stepId = "")
        {
            string dbFilePath = _dbPath;

            string queryCommand = @"UPDATE sys_job_info SET STATE = ?, CARRIERID = ?, STEPID = ?, STARTEDTIME = ? WHERE ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@STATE"] = "QUEUED";
            parameters["@CARRIERID"] = carrierId;
            parameters["@STEPID"] = stepId;
            parameters["@STARTEDTIME"] = DateTime.Now;
            parameters["@JOBID"] = job_id;

            DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);
        }

        public void UpdateJobStart(string job_id, string carrierId = "", string stepId = "")
        {
            string dbFilePath = _dbPath;

            string queryCommand = @"UPDATE sys_job_info SET STATE = ?, CARRIERID = ?, STEPID = ?, STARTEDTIME = ? WHERE ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@STATE"] = "RUNNING";
            parameters["@CARRIERID"] = carrierId;
            parameters["@STEPID"] = stepId;
            parameters["@STARTEDTIME"] = DateTime.Now;
            parameters["@JOBID"] = job_id;

            DbHandler.Instance.ExecuteNonQuery (dbFilePath, queryCommand, parameters);
        }

        public void UpdateJobComplete(string job_id)
        {
            string dbFilePath = _dbPath;

            string queryCommand = @"UPDATE sys_job_info SET  STATE = ?, COMPLETEDTIME = ? WHERE ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@STATE"] = "COMPLETED";
            parameters["@COMPLETEDTIME"] = DateTime.Now;
            parameters["@JOBID"] = job_id;

            DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);
        }


        public void DeleteJob(string job_id)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"DELETE FROM sys_job_info WHERE ID = @JOBID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@JOBID", job_id);

            DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);
        }

        public List<JOB> SearchTaskByState(string state)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"SELECT * FROM sys_job_info WHERE STATE = ?";
            List<JOB> jobList = new List<JOB>();

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@STATE", state);

            DataTable dt = DbHandler.Instance.ExecuteQuery(dbFilePath, queryCommand, parameters);



            foreach (DataRow dr in dt.Rows)
            {
                JOB job = new JOB();

                job.ID = dr["ID"] as string;
                job.PRIORITY = (dr["PRIORITY"] as long?) ?? 0;
                job.STATE = dr["STATE"] as string;
                job.JOB_TYPE = dr["JOBTYPE"] as string;
                job.CARRIER_ID = dr["CARRIERID"] as string;
                job.ORIGIN_LOCATION = dr["ORIGIN_LOCATION"] as string;
                job.CREATED_TIME = (dr["CREATEDTIME"] as DateTime?) ?? DateTime.Now;
                job.QUEUED_TIME = (dr["QUEUEDTIME"] as DateTime?) ?? DateTime.Now;
                job.STARTED_TIME = (dr["STARTEDTIME"] as DateTime?) ?? DateTime.Now;
                job.COMPLETED_TIME = (dr["COMPLETEDTIME"] as DateTime?) ?? DateTime.Now;
                job.CREATOR = dr["CREATOR"] as string;

                jobList.Add(job);
            }

            return jobList;
        }

        public List<JOB> GetJobListAll()
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"SELECT * FROM sys_job_info";

            List<JOB> jobList = new List<JOB>();

            DataTable dt = DbHandler.Instance.ExecuteQuery(dbFilePath, queryCommand);

            foreach (DataRow dr in dt.Rows)
            {
                JOB job = new JOB();

                job.ID = dr["ID"] as string;
                job.PRIORITY = (dr["PRIORITY"] as long?)?? 0;
                job.STATE = dr["STATE"] as string;
                job.JOB_TYPE = dr["JOBTYPE"] as string;
                job.CARRIER_ID = dr["CARRIERID"] as string;
                job.ORIGIN_LOCATION = dr["ORIGIN_LOCATION"] as string;
                job.CREATED_TIME = (dr["CREATEDTIME"] as DateTime?) ?? DateTime.Now;
                job.QUEUED_TIME = (dr["QUEUEDTIME"] as DateTime?) ?? DateTime.Now;
                job.STARTED_TIME = (dr["STARTEDTIME"] as DateTime?) ?? DateTime.Now;
                job.COMPLETED_TIME = (dr["COMPLETEDTIME"] as DateTime?) ?? DateTime.Now;
                job.CREATOR = dr["CREATOR"] as string;

                jobList.Add(job);
            }

            return jobList;
        }

        // 2024.03.04 mh.yun : GetJobHistory 추가
        public DataTable GetJobHistory(DateTime fromDate, DateTime toDate)
        {
            string sql_SelectJobHist = @"SELECT * FROM sys_job_history WHERE UPDATETIME BETWEEN @FROM AND @TO ORDER BY UPDATETIME DESC";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@FROM", fromDate.ToString("yyyy-MM-dd HH:mm:ss"));
            param.Add("@TO", toDate.ToString("yyyy-MM-dd HH:mm:ss"));
            DataTable jobHistData = DbHandler.Instance.ExecuteQuery(_dbPath, sql_SelectJobHist, param);
            LogHelper.Instance.DBManagerLog.DebugFormat("[INFO] Get Job History Success.");
            return jobHistData;
        }
    }
}
