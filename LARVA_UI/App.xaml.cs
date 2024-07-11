using DevExpress.Data.Browsing;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using LARVA_UI.ViewModels.SettingViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using DevExpress.Office.Utils;

namespace LARVA_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Assembly assembly = System.Reflection.Assembly.GetCallingAssembly();
        public App()
        {
            ShowSplashScreenView();
        }

        public async void ShowSplashScreenView()
        {
            bool isFluent = true;
            string version = assembly.GetName().Version.ToString();
            var viewModel = new DXSplashScreenViewModel()
            {
                Logo = new Uri(String.Format(@"pack://application:,,,/Resources/larva.png")), //, AssemblyInfo.VersionShort)),
                Status = "Starting...",
                Title = "곤충 스마트팜 제어 프로그램",
                Subtitle = "Powered by INNO Robotics",
                Copyright = GetCopyright(),
                IsIndeterminate = isFluent
            };


            SplashScreenManager manager;
            if (isFluent)
                manager = SplashScreenManager.CreateFluent(viewModel, true);
            else
                manager = SplashScreenManager.CreateWaitIndicator(viewModel);

            manager.Show(0, 1000, null, WindowStartupLocation.CenterScreen, true, InputBlockMode.Owner);

            string basePath = AppDomain.CurrentDomain.BaseDirectory;


            viewModel.Status = "Loading data...";
            EPLE.App.Engine.Instance.ConfigFilePath = @"./config/Server.Config.ini";
            EPLE.App.Engine.Instance.DbFilePath = @"./config/db_io.mdb";
            EPLE.App.Engine.Instance.Inialize();
            EPLE.App.Engine.Instance.Start();
            
            LARVA.Scheduler.JobManager.Instance.Initialize(@"./config/db_io.mdb");

            while (!EPLE.IO.DataManager.Instance.Initialized)
            {
                viewModel.Status = "Finishing...";
                await Task.Delay(100);
            }
  
            manager.Close();
        }

        //public static void Test_SplashScreenManager_GeneratedInAppFluentSplashScreen()
        //{
        //    Test_SplashScreenManagerCore(() => new CustomFluentSplashScreen());
        //}

        //public static void Test_SplashScreenManagerCore(Func<Window> splashScreenFactory)
        //{
        //    SplashScreenManager.Create(() => {
        //        var w = splashScreenFactory();
        //        w.ContentRendered += (s, e) => {
        //            Timer.Stop();
        //            App.Current.Dispatcher.InvokeAsync(() => {
        //                App.Current.MainWindow.Title = $"SplashScreen Startup Time: {Timer.ElapsedMilliseconds} ms";
        //            });
        //        };
        //        return w;
        //    }, new DXSplashScreenViewModel()
        //    {
        //        Title = "SplashScreen Test",
        //        Subtitle = null,
        //    }).ShowOnStartup();
        //}

        string GetCopyright()
        {

            
            List<Attribute> attributes = assembly.GetCustomAttributes().ToList();

            AssemblyCopyrightAttribute attr = (AssemblyCopyrightAttribute)attributes[9];

            return attr.Copyright + (attr.Copyright.Contains("All rights reserved") ? "" : "\nAll rights reserved");
        }

    }
}
