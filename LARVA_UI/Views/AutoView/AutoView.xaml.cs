using LARVA_UI.ViewModels;
using LARVA_UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using DevExpress.Utils.Extensions;
using EPLE.App;
using EPLE.IO;
using DevExpress.Xpf.WindowsUI;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for AutoView.xaml
    /// </summary>
    public partial class AutoView : UserControl
    {
        public AutoView()
        {
            InitializeComponent();
        }

        public event EventHandler TobbabSupplyClicked;
        public event EventHandler TobbabChangeClicked;
        public event EventHandler JellySupplyClicked;
        public event EventHandler ShipmentClicked;
        public event EventHandler RiceSupplyClicked;
        public event EventHandler MistSupplyClicked;
        public event EventHandler VisionClicked;
        public event EventHandler EjectClicked;
        public event EventHandler LoadingClicked;
        public event EventHandler EmergncyControlClicked;
        public event EventHandler AccessSelectClicked;
        public event EventHandler AccessInClicked;
        public event EventHandler AccessOutClicked;
        public event EventHandler StopClicked;
        public event EventHandler AlarmClicked;
        public event EventHandler ManualControlClicked;
        public event EventHandler BugsFarmSetClicked;
        public event EventHandler DeveloperSetClicked;

        private void ZoneButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            // 모든 버튼을 기본 색상으로 초기화
            btnZone_1.Background = Brushes.Transparent;
            btnZone_2.Background = Brushes.Transparent;
            btnZone_3.Background = Brushes.Transparent;
            btnZone_4.Background = Brushes.Transparent;
            btnZone_5.Background = Brushes.Transparent;
            btnZone_6.Background = Brushes.Transparent;
            btnZone_7.Background = Brushes.Transparent;
            btnZone_8.Background = Brushes.Transparent;

            // 클릭된 버튼의 색상을 변경
            if (sender is Button clickedButton)
            {
                clickedButton.Background = Brushes.SkyBlue;
            }
            

            // ViewModel의 인스턴스를 얻음
            if (this.DataContext is AutoViewModel viewModel)
            {
                // 선택된 박스들 초기화
                viewModel.ClearSelectedBoxes();

                // ToggleButton의 IsChecked 속성 강제로 false로 설정
                foreach (var control in BoxGroup_1.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }
                foreach (var control in BoxGroup_2.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }
                foreach (var control in BoxGroup_3.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }

            }
            */
        }

        private void BoxLevelButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            // ViewModel의 인스턴스를 얻음
            if (this.DataContext is AutoViewModel viewModel)
            {
                var popup = new BoxLevelWindow();
                if (popup.ShowDialog() == true)
                {
                    string selectedStage = popup.SelectedStage; // 사용자가 선택한 박스 레벨

                    foreach (var control in BoxGroup_1.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                    foreach (var control in BoxGroup_2.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                    foreach (var control in BoxGroup_3.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                }
            }
            */
        }

        private string ReplaceBoxStage(string currentContent, string newStage)
        {
            // 현재 Content에서 마지막 줄(현재 박스 레벨)을 찾아서 새로운 레벨로 교체
            var lines = currentContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length > 1)
            {
                lines[lines.Length - 1] = newStage; // 마지막 줄을 새로운 레벨로 교체
                return string.Join("\n", lines);
            }
            else
            {
                return currentContent + newStage;
            }
        }

        //톹밥담기
        private void TobbabSupply_Click(object sender, RoutedEventArgs e)
        {
            TobbabSupplyClicked?.Invoke(sender, e);

        }


        //톱밥교체
        private void TobbabChange_Click(object sender, RoutedEventArgs e)
        {
            TobbabChangeClicked?.Invoke(sender, e);
        }

        //젤리공급
        private void JellySupply_Click(object sender, RoutedEventArgs e)
        {
            JellySupplyClicked?.Invoke(sender, e);
        }

        //출하공정
        private void Shipment_Click(object sender, RoutedEventArgs e)
        {
            ShipmentClicked?.Invoke(sender, e);
        }

        //쌀가루공급
        private void RiceSupply_Click(object sender, RoutedEventArgs e)
        {
            RiceSupplyClicked?.Invoke (sender, e);
        }

        //수분보충
        private void MistSupply_Click(object sender, RoutedEventArgs e)
        {
            MistSupplyClicked?.Invoke(sender, e);
        }

        //비전촬영
        private void Vision_Click(object sender, RoutedEventArgs e)
        {
            VisionClicked?.Invoke(sender, e);
        }

        //배출공정
        private void Eject_Click(object sender, RoutedEventArgs e)
        {
            EjectClicked?.Invoke(sender, e);
        }

        //투입공정
        private void Loading_Click(object sender, RoutedEventArgs e)
        {
            LoadingClicked?.Invoke(sender, e);
        }

        //긴급제어
        private void EmergncyControl_Click(object sender, RoutedEventArgs e)
        {
            EmergncyControlClicked?.Invoke(sender, e);
        }

        //투입구선택
        private void AccessSelect_Click(object sender, RoutedEventArgs e)
        {
            AccessSelectClicked?.Invoke(sender, e);
        }

        //투입구IN
        private void AccessIn_Click(object sender, RoutedEventArgs e)
        {
            AccessInClicked?.Invoke(sender, e);
        }

        //투입구OUT
        private void AccessOut_Click(object sender, RoutedEventArgs e)
        {
            AccessOutClicked?.Invoke(sender, e);
        }

        //정지
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopClicked?.Invoke(sender, e);
        }

        //알람
        private void Alarm_Click(object sender, RoutedEventArgs e)
        {
            AlarmClicked?.Invoke(sender, e);
        }

        //수동조작
        private void ManualControl_Click(object sender, RoutedEventArgs e)
        {
            ManualControlClicked?.Invoke(sender, e);
        }

        //벅스팜설정
        private void BugsFarmSet_Click(object sender, RoutedEventArgs e)
        {
            BugsFarmSetClicked?.Invoke(sender, e);
        }

        //개발자설정
        private void DeveloperSet_Click(object sender, RoutedEventArgs e)
        {
            DeveloperSetClicked?.Invoke(sender, e);
        }

        private void MainViewNavigationButton(object sender, MouseButtonEventArgs e)
        {

        }

        private void ManualViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("수동 모드로 변경 하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void ManualViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 수동 조작 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void MainViewNavigationButton(object sender, TouchEventArgs e)
        {

        }

        private void SettingsViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 설정 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void SettingsViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 설정 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void IoMonitoringViewNavigationButton(object sender, MouseButtonEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 I/O 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        private void IoMonitoringViewNavigationButton(object sender, TouchEventArgs e)
        {
            bool result = false;
            int mode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);

            if (mode == (int)eAccessMode.AUTO)
            {
                MessageBoxResult messageBoxResult = WinUIMessageBox.Show("자동 모드에서 I/O 화면에 접근할 수 없습니다. \n 수동 모드로 전환하십시오.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.None);
                e.Handled = true;
            }
        }

        //// Flat Motor standby
        //nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.oTBS_nFlatMotorStandby_OnOff, out result);
        //    if (nVal == (int) eOnOff.ON)
        //{
        //    vm.FlatMotorOnBG = new SolidColorBrush(Colors.LightGreen);
        //    vm.FlatMotorOffBG = new SolidColorBrush(Colors.Transparent);
        //}
        //    else if (nVal == (int) eOnOff.OFF)
        //{
        //    vm.FlatMotorOnBG = new SolidColorBrush(Colors.Transparent);
        //    vm.FlatMotorOffBG = new SolidColorBrush(Colors.LightGreen);
        //}
        //    else
        //    {
        //        vm.FlatMotorOnBG = new SolidColorBrush(Colors.Transparent);
        //vm.FlatMotorOffBG = new SolidColorBrush(Colors.Transparent);
    }


}

