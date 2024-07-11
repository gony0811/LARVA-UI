using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EPLE.IO;
using EPLE.App;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;
using System.Timers;
using DevExpress.Xpf.WindowsUI;
using System.Windows.Threading;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.Core.Manager;
using DevExpress.Mvvm;
using LARVA_UI.ViewModels.SettingViewModel;
using System.Threading.Tasks;

namespace LARVA_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private DispatcherTimer timer;



        public MainWindow()
        {
            InitializeComponent();

            


            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);     
            timer.Tick += Timer_Elapsed;
            timer.Start();
            //LARVA.Scheduler.JobManager.Instance.CreateNewJob("TOBBAB_CHANGE", 10, "SEAN", "HOME");
        }



        public bool AvailableStatus()
        {
            bool result = false;
            int available = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result);
            int accessMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);
            int runStatus = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nRun_Status, out result);
            int alarmStatus = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAlarm_Status, out result);
            int doorLockStatus = DataManager.Instance.GET_INT_DATA(IoNameHelper.iMain_nDoor_Open, out result);
            int jobSchedulerStatus = DataManager.Instance.GET_INT_DATA(IoNameHelper.vSys_nJobScheduler_RunStop, out result);


            if (!result 
                || available == (int)eAvailable.DOWN 
                || accessMode != (int)eAccessMode.AUTO 
                || runStatus != (int)eRunStatus.IDLE 
                || jobSchedulerStatus != (int)eRunStop.RUN)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void Timer_Elapsed(object sender, EventArgs e)
        {
            DispatcherTimer timer = (DispatcherTimer)sender;

            if (!AvailableStatus())
            {          
                return;
            }


            timer.Stop();

            JOB selectedJob = null;

            foreach(JOB needConfirmJob in JobManager.Instance.SearchTaskByState("QUEUED"))
            {
                if (needConfirmJob != null)
                {
                    if (selectedJob == null)
                    {
                        selectedJob = needConfirmJob;
                    }
                    else if (selectedJob.PRIORITY <  needConfirmJob.PRIORITY)
                    {
                        selectedJob = needConfirmJob;
                    }
                    else
                    {
                        continue;
                    }
                }
            }


            if (selectedJob != null)
            {
                object[] args = null;
                string msg = string.Format("{0}에 대하여 {1}을 진행 하시겠습니까?", selectedJob.ORIGIN_LOCATION, selectedJob.JOB_TYPE);
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show(msg, "자동 공정", MessageBoxButton.YesNoCancel, MessageBoxImage.Information, MessageBoxResult.Yes, MessageBoxOptions.None);
                if (messageBoxResult != MessageBoxResult.Yes)
                {
                    timer.Start();
                    return;
                }

                switch (selectedJob.JOB_TYPE)
                {
                    case "TOBBAB_CHANGE":
                        
                        JobManager.Instance.UpdateJobStart(selectedJob.ID);
                        args = new object[] { selectedJob };
                        FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_AUTO_TOBBAB_CHANGE", args, TobbabChangeResultCallback);
                        
                        break;
                    case "EJECT":
                        JobManager.Instance.UpdateJobStart(selectedJob.ID);
                        args = new object[] { selectedJob };
                        FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_AUTO_EJECT", args, EjectResultCallback);
                        break;
                }

                
            }

            timer.Start();
        }
        private void TobbabChangeResultCallback(string functionName, object result)
        {
            
        }

        private void EjectResultCallback(string functionName, object result)
        {

        }

        /*
        private void navi_diagnostic_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new DiagnosticPage());
        }

        private void navi_main_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Views.MainView());
        }
        */

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
