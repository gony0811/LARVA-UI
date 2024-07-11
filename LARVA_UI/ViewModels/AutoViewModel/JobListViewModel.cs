using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.XtraPrinting.Native;
using EPLE.App;
using EPLE.Core;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using EPLE.IO;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;
using LARVA_UI.Models;
using LARVA_UI.Views;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class JobListViewModel
    {

        private ObservableCollection<JOB> _JobList;
        public JobListViewModel()
        {
            Initialize();
        }

        public ObservableCollection<JOB> JobList
        {
            get { return _JobList; }
            set
            {
                if (_JobList != value)
                {
                    _JobList = value;
                    OnPropertyChanged("JobList");
                }
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Initialize()
        {

            _JobList = new ObservableCollection<JOB>();

            UpdateJobListDisplay();
        }

        private void UpdateJobListDisplay()
        {
            List<JOB> jobList = JobManager.Instance.GetJobListAll();
            ObservableCollection<JOB> jobLists = new ObservableCollection<JOB>();

            foreach (var job in jobList)
            {
                if (job != null)
                {
                    //bool jobValue = JobManager.Instance.GET_BOOL_DATA(String.Format("iJob.{0}", job.ID), out bool result);

                    //if (result && !jobValue)
                    //{
                    //    JobManager.Instance.ResetAlarm(alarm.ID);
                    //    continue;
                    //}

                    jobLists.Add(new JOB()
                    {
                        ID = job.ID,
                        PRIORITY = job.PRIORITY,
                        STATE = job.STATE,
                        JOB_TYPE = job.JOB_TYPE,
                        CARRIER_ID = job.CARRIER_ID,
                        STEP_ID = job.STEP_ID,
                        ORIGIN_LOCATION = job.ORIGIN_LOCATION,
                        CREATED_TIME = job.CREATED_TIME,
                        QUEUED_TIME = job.QUEUED_TIME,
                        STARTED_TIME = job.STARTED_TIME,
                        COMPLETED_TIME = job.COMPLETED_TIME,
                        CREATOR = job.CREATOR,
                    });


                }
                else
                {
                    continue;
                }
            }

            JobList = jobLists;
        }
    }
}