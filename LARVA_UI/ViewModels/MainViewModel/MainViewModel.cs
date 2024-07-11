using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.IO;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class MainViewModel : INotifyPropertyChanged
    {
        [GenerateProperty]
        Visibility settingsViewVisibility;
        [GenerateProperty]
        Visibility autoViewVisibility;
        [GenerateProperty]
        Visibility manualViewVisibility;
        [GenerateProperty]
        Visibility ioMonitoringViewVisibility;
        [GenerateProperty]
        Visibility alarmResetVisibility;
        [GenerateProperty]
        Visibility buzzerOffVisibility;
        [GenerateProperty]
        Visibility servoControlViewVisibility;

        [GenerateProperty]
        string _Status;
        [GenerateProperty]
        string _UserName;

        [GenerateProperty]
        string doorText;

        [GenerateCommand]
        void Login() => Status = "User: " + UserName;
        bool CanLogin() => !string.IsNullOrEmpty(UserName);

        //public DelegateCommand<RoutedEventArgs> ModeChangeCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> BuzzerOffCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetCommand { get; private set; }

        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchDownCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchUpCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchDownCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchUpCommand { get; private set; }

        public string _modeTxt {  get; private set; }

        private EventHandler<DataChangedEventHandlerArgs> DataChangedEvent;

        public string ModeTxt
        {
            get { return _modeTxt; }
            set
            {
                _modeTxt = value;
                OnPropertyChanged(nameof(ModeTxt));
            }
        }
        public MainViewModel()
        {
            DataChangedEvent = new EventHandler<DataChangedEventHandlerArgs>(OnDataChanged);
            DataManager.Instance.DataAccess.DataChangedEvent += DataChangedEvent;
            int nMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out bool result);
           

            if (result)
            {
                switch(nMode)
                {
                    case (int)eAccessMode.MANUAL:
                        {
                            ModeTxt = "수동";
                            SettingsViewVisibility = Visibility.Visible;
                            ServoControlViewVisibility = Visibility.Visible;
                            IoMonitoringViewVisibility = Visibility.Visible;
                            ManualViewVisibility = Visibility.Visible;
                            AutoViewVisibility = Visibility.Hidden;
                        }
                        break;
                    case (int)eAccessMode.AUTO:
                        {
                            ModeTxt = "자동";
                            SettingsViewVisibility = Visibility.Hidden;
                            ServoControlViewVisibility = Visibility.Hidden;
                            IoMonitoringViewVisibility = Visibility.Hidden;
                            ManualViewVisibility = Visibility.Hidden;
                            AutoViewVisibility = Visibility.Visible;
                        }
                        break;
                    default:
                        {
                            ModeTxt = "알수없음";
                            SettingsViewVisibility = Visibility.Visible;
                            SettingsViewVisibility = Visibility.Visible;
                            ServoControlViewVisibility = Visibility.Visible;
                            IoMonitoringViewVisibility = Visibility.Visible;
                            ManualViewVisibility = Visibility.Visible;
                            AutoViewVisibility = Visibility.Hidden;
                        }
                        break;

                }
            }

            bool bOpen = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iMain_nDoor_Open, out result);

            if (bOpen)
            {
                DoorText = "해제";
            }
            else
            {
                DoorText = "잠김";
            }

            int nAlarm = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAlarm_Status, out result);

            if (nAlarm != (int)eAlarm.NO_ALARM)
            {
                AlarmResetVisibility = Visibility.Visible;
                BuzzerOffVisibility = Visibility.Visible;
            }
            else
            {
                AlarmResetVisibility = Visibility.Hidden;
                BuzzerOffVisibility = Visibility.Hidden;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnDataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = (Data)e.Data;

            if (Application.Current == null) return;

            if (data.Name == IoNameHelper.iEqp_nOp_Mode)
            {
                if (Convert.ToInt32(data.Value) == (int)eAccessMode.AUTO)
                {
                    ModeTxt = "자동";
                    SettingsViewVisibility = Visibility.Hidden;
                    ServoControlViewVisibility = Visibility.Hidden;
                    IoMonitoringViewVisibility = Visibility.Hidden;
                    ManualViewVisibility = Visibility.Hidden;
                    AutoViewVisibility = Visibility.Visible;
                }
                else if (Convert.ToInt32(data.Value) == (int)eAccessMode.MANUAL)
                {
                    ModeTxt = "수동";
                    SettingsViewVisibility = Visibility.Visible;
                    ServoControlViewVisibility = Visibility.Visible;
                    IoMonitoringViewVisibility = Visibility.Visible;
                    ManualViewVisibility = Visibility.Visible;
                    AutoViewVisibility = Visibility.Hidden;
                }
            }
            else if (data.Name == IoNameHelper.iMain_nDoor_Open)
            {
                if (Convert.ToInt32(data.Value) == (int)eOpenClose.OPEN)
                {
                    DoorText = "해제";
                }
                else
                {
                    DoorText = "잠김";
                }
            }
            else if (data.Name == IoNameHelper.iEqp_nAlarm_Status)
            {
                if (Convert.ToInt32(data.Value) == (int)eAlarm.NO_ALARM)
                {
                    AlarmResetVisibility = Visibility.Hidden;
                    BuzzerOffVisibility = Visibility.Hidden;
                }
                else
                {
                    AlarmResetVisibility = Visibility.Visible;
                    BuzzerOffVisibility = Visibility.Visible;
                }
            }

            //Application.Current.Dispatcher.Invoke(() =>
            //{


            //});
        }

        [GenerateCommand(Name = "DoorOpenCommand")]
        private void DoorOpen()
        {
            if (DoorText.Equals("잠김"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oMain_nDoor_OpnCls, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oMain_nDoor_OpnCls, (int)eOnOff.OFF);
            }
            
        }

        [GenerateCommand]
        private void ModeChange(RoutedEventArgs args)
        {
            int tmp = 0;
            tmp = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out bool result);
            if (tmp == (int)eAccessMode.MANUAL)
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oEqp_nOp_Mode, (int)eAccessMode.AUTO);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oEqp_nOp_Mode, (int)eAccessMode.MANUAL);
            }
        }
        [GenerateCommand]
        private void AlarmResetTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, false);
        }

        [GenerateCommand]
        private void AlarmResetTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, true);
            AlarmManager.Instance.ResetAlarmAll();
        }

        [GenerateCommand]
        private void BuzzerOffTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
        }

        [GenerateCommand]
        private void BuzzerOffTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
        }

        [GenerateCommand]
        private void AlarmReset(RoutedEventArgs args)
        {
            if (args is MouseEventArgs)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)args;

                if (mouseEventArgs.LeftButton == MouseButtonState.Pressed)
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, true);
                }
                else
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, false);
                }
            }
        }

        [GenerateCommand]
        private void BuzzerOff(RoutedEventArgs args)
        {
            if (args is MouseEventArgs)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)args;

                if (mouseEventArgs.LeftButton == MouseButtonState.Pressed)
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
                }
                else
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
                }
            }
        }

        public void MainContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
