using DevExpress.Mvvm.CodeGenerators;
using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using LARVA_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using DevExpress.Xpf.Editors;
using EPLE.Core;
using System.Data;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class JobHistoryViewModel
    {
        private DateTime startDateTime;
        private DateTime endDateTime;
        public DelegateCommand<RoutedEventArgs> SearchJobHistoryCommand { get; private set; }
        public DelegateCommand<RoutedEventArgs> StartEditValueChangedCommand { get; private set; }
        public DelegateCommand<RoutedEventArgs> EndEditValueChangedCommand { get; private set; }

        public ObservableCollection<JOB> jobHistoryList;
        public JobHistoryViewModel()
        {
            Initialize();
        }

        public ObservableCollection<JOB> JobHistoryList
        {
            get { return jobHistoryList; }
            set
            {
                if (jobHistoryList != value)
                {
                    jobHistoryList = value;
                    OnPropertyChanged("JobHistoryList");
                }
            }
        }

        public DateTime StartDateTime
        {
            get { return startDateTime; }
            set
            {
                startDateTime = value;
                OnPropertyChanged(nameof(StartDateTime));
            }
        }

        public DateTime EndDateTime
        {
            get { return endDateTime; }
            set
            {
                endDateTime = value;
                OnPropertyChanged(nameof(EndDateTime));
            }
        }

        private void Initialize()
        {
            JobHistoryList = new ObservableCollection<JOB>();
            SearchJobHistoryCommand = new DelegateCommand<RoutedEventArgs>(ExecuteSearchJobHistoryComamnd);
            StartEditValueChangedCommand = new DelegateCommand<RoutedEventArgs>(ExecuteStartEditValueChangedCommand);
            EndEditValueChangedCommand = new DelegateCommand<RoutedEventArgs>(ExecuteEndEditValueChangedCommand);

            var CnvSTime = DateTime.Now.AddDays(-1);
            StartDateTime = new DateTime(CnvSTime.Year, CnvSTime.Month, CnvSTime.Day, CnvSTime.Hour, 0, 0);
            EndDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            JobDBSearch_Click();
        }

        private void ExecuteEndEditValueChangedCommand(RoutedEventArgs args)
        {

        }

        private void ExecuteStartEditValueChangedCommand(RoutedEventArgs args)
        {

        }

        private void ExecuteSearchJobHistoryComamnd(RoutedEventArgs args)
        {
            JobDBSearch_Click();
        }


        private void JobDBSearch_Click()
        {
            try
            {

                DateTime start_date = StartDateTime;
                DateTime end_date = EndDateTime;


                if (start_date > end_date)
                {
                    MessageBox.Show("Start date can not be equal or greater...");
                }
                else
                {
                    //CurrentJob.Clear();
                    DataTable jobHistData = JobManager.Instance.GetJobHistory(start_date, end_date);

                    if (jobHistData == null)
                        return;

                    //jobHistData.DefaultView.Sort = "UPDATETIME DESC";

                    jobHistData = jobHistData.DefaultView.ToTable(true);

                    JobHistoryList.Clear();
                    foreach (DataRow dr in jobHistData.Rows)
                    {
                        JobHistoryList.Add(new JOB()
                        {
                            ID = dr["ID"].ToString(),                            
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
