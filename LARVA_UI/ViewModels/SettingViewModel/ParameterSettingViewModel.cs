using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.XtraRichEdit.Layout;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.IO;
using System;
using System.ComponentModel;
using System.Windows;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ParameterSettingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [GenerateProperty]
        private double flipLimitMinus;
        [GenerateProperty]
        private double flipLimitPlus;
        [GenerateProperty]
        private double flipAxisMoveVelocity;
        [GenerateProperty]
        private double xAxisMoveVelocity;
        [GenerateProperty]
        private double yAxisMoveVelocity;
        [GenerateProperty]
        private double zAxisMoveVelocity;

        [GenerateProperty]
        private int flipImpactDuration;
        [GenerateProperty]
        private int flipOutConveyorDuration;
        [GenerateProperty]
        private int flipSwingDuration;
        [GenerateProperty]
        private int tobbabSupplyWeight;
        [GenerateProperty]
        private int tobbabSupplyTimeout;
        [GenerateProperty]
        private int washingDurationTime;
        [GenerateProperty]
        private int mistSupplyDuration;
        [GenerateProperty]
        private int flatDuration;
        [GenerateProperty]
        private int blowDuration;
        [GenerateProperty]
        private double hvacTargetTemperature;
        [GenerateProperty]
        private double hvacTargetHumidity;

        [GenerateProperty]
        private double boxFaceUpAngle;
        [GenerateProperty]
        private double boxFaceDownAngle;

        // 대기위치 추가_mh.yun_240226
        [GenerateProperty]
        private double xAxisStandbyPosition;
        [GenerateProperty]
        private double yAxisStandbyPosition;
        [GenerateProperty]
        private double zAxisStandbyPosition;

        [GenerateProperty]
        private double xAxisJogFastVelocity;
        [GenerateProperty]
        private double xAxisJogSlowVelocity;
        [GenerateProperty]
        private double yAxisJogFastVelocity;
        [GenerateProperty]
        private double yAxisJogSlowVelocity;
        [GenerateProperty]
        private double zAxisJogFastVelocity;
        [GenerateProperty]
        private double zAxisJogSlowVelocity;
        [GenerateProperty]
        private double flipAxisJogFastVelocity;
        [GenerateProperty]
        private double flipAxisJogSlowVelocity;

        // 축인터락 추가_mh.yun_240627
        [GenerateProperty]
        private bool isXAxisInterlockStatus;
        [GenerateProperty]
        private bool isYAxisInterlockStatus;
        [GenerateProperty]
        private bool isZAxisInterlockStatus;
        [GenerateProperty]
        private bool isFlipAxisInterlockStatus;
        [GenerateProperty]
        private bool isTurnAxisInterlockStatus;
        [GenerateProperty]
        private bool isAllInterlockStatus;

        // 홈 속도 추가_mh.yun_240701
        [GenerateProperty]
        private double xAxisHomeVelocity; 
        [GenerateProperty]
        private double yAxisHomeVelocity;
        [GenerateProperty]
        private double zAxisHomeVelocity;
        [GenerateProperty]
        private double flipAxisHomeVelocity;


        public ParameterSettingViewModel()
        {
            InitializeParameter();
        }

        private void InitializeParameter()
        {
            bool result = false;

            TobbabSupplyWeight = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nTobbab_Weight, out result);
            TobbabSupplyTimeout = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nTobbab_Timeout, out result);
            MistSupplyDuration = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nMist_Duration, out result);
            FlipImpactDuration = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nBoxImpact_Duration, out result);
            FlipSwingDuration = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nFlipSwing_Duration, out result);
            FlipOutConveyorDuration = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nOutConv_Duration, out result);
            FlipLimitPlus = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipSwing_PlusAngle, out result);
            FlipLimitMinus = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipSwing_MinusAngle, out result);

            BoxFaceUpAngle = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceUp, out result);
            BoxFaceDownAngle = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceDown, out result);
            WashingDurationTime = DataManager.Instance.GET_INT_DATA(IoNameHelper.oParam_nWash_Duration, out result);
            HvacTargetTemperature = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetTemp, out result);
            HvacTargetHumidity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetHumidity, out result);

            XAxisMoveVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveVel_Set, out result);
            YAxisMoveVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveVel_Set, out result);
            ZAxisMoveVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveVel_Set, out result);
            FlipAxisMoveVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dFlipMoveVel_Set, out result);

            // 대기위치 추가_mh.yun_240226
            XAxisStandbyPosition = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dXAxis_WaitPos, out result);
            YAxisStandbyPosition = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dYAxis_WaitPos, out result);
            ZAxisStandbyPosition = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oParam_dZAxis_WaitPos, out result);

            // Jog Fast/Slow 추가
            XAxisJogFastVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogXFastVel_Set, out result);
            XAxisJogSlowVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogXSlowVel_Set, out result);

            YAxisJogFastVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogYFastVel_Set, out result);
            YAxisJogSlowVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogYSlowVel_Set, out result);

            ZAxisJogFastVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogZFastVel_Set, out result);
            ZAxisJogSlowVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogZSlowVel_Set, out result);

            FlipAxisJogFastVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogFlipFastVel_Set, out result);
            FlipAxisJogSlowVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dJogFlipSlowVel_Set, out result);

            // 홈 속도 추가_mh.yun_20240627
            XAxisHomeVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dXHomeVel_Set, out result);
            YAxisHomeVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYHomeVel_Set, out result);
            ZAxisHomeVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZHomeVel_Set, out result);
            FlipAxisHomeVelocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dFlipHomeVel_Set, out result);
           
            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nAll_OnOff, out result) == eOnOff.ON) 
                IsAllInterlockStatus = true; 
            else 
                IsAllInterlockStatus = false;

            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nXAxis_OnOff, out result) == eOnOff.ON)
               IsXAxisInterlockStatus = true;
            else
                IsXAxisInterlockStatus = false;

            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nYAxis_OnOff, out result) == eOnOff.ON)
                IsYAxisInterlockStatus = true;
            else
                IsYAxisInterlockStatus = false;

            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nZAxis_OnOff, out result) == eOnOff.ON)
                IsZAxisInterlockStatus = true;
            else
                IsZAxisInterlockStatus = false;


            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nFlipAxis_OnOff, out result) == eOnOff.ON)
                IsFlipAxisInterlockStatus = true;
            else
                IsFlipAxisInterlockStatus = false;

            if ((eOnOff)DataManager.Instance.GET_INT_DATA(IoNameHelper.oInterlock_nTRHand_OnOff, out result) == eOnOff.ON)
                IsTurnAxisInterlockStatus = true;
            else
                IsTurnAxisInterlockStatus = false;
        }
        
        [GenerateCommand]
        private void XAxisJogFastVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogXFastVel_Set, XAxisJogFastVelocity, true);
        }

        [GenerateCommand]
        private void YAxisJogFastVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogYFastVel_Set, YAxisJogFastVelocity, true);
        }

        [GenerateCommand]
        private void ZAxisJogFastVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogZFastVel_Set, ZAxisJogFastVelocity, true);
        }

        [GenerateCommand]
        private void FlipAxisJogFastVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogFlipFastVel_Set, FlipAxisJogFastVelocity, true);
        }

        [GenerateCommand]
        private void XAxisJogSlowVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogXSlowVel_Set, XAxisJogSlowVelocity, true);
        }

        [GenerateCommand]
        private void YAxisJogSlowVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogYSlowVel_Set, YAxisJogSlowVelocity, true);
        }

        [GenerateCommand]
        private void ZAxisJogSlowVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogZSlowVel_Set, ZAxisJogSlowVelocity, true);
        }

        [GenerateCommand]
        private void FlipAxisJogSlowVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dJogFlipSlowVel_Set, FlipAxisJogSlowVelocity, true);
        }

        // 홈 속도 추가_mh.yun_240701
        [GenerateCommand]
        private void XAxisHomeVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dXHomeVel_Set, XAxisHomeVelocity, true);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dXHomeVel_Set, XAxisHomeVelocity);
        }
        [GenerateCommand]
        private void YAxisHomeVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dYHomeVel_Set, YAxisHomeVelocity, true);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dYHomeVel_Set, YAxisHomeVelocity);
        }
        [GenerateCommand]
        private void ZAxisHomeVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dZHomeVel_Set, ZAxisHomeVelocity, true);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dZHomeVel_Set, ZAxisHomeVelocity);
        }
        [GenerateCommand]
        private void FlipAxisHomeVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dFlipHomeVel_Set, FlipAxisHomeVelocity, true);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dFlipHomeVel_Set, FlipAxisHomeVelocity);
        }



        [GenerateCommand]
        private void FlipAxisJogSlowVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("FLIP축 Jog Slow 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipAxisJogSlowVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipAxisJogSlowVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void FlipAxisJogFastVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("FLIP축 Jog Fast 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipAxisJogFastVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipAxisJogFastVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void ZAxisJogSlowVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis Jog Slow 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", ZAxisJogSlowVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                ZAxisJogSlowVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void ZAxisJogFastVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis Jog Fast 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", ZAxisJogFastVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                ZAxisJogFastVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void YAxisJogSlowVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis Jog Slow 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", YAxisJogSlowVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                YAxisJogSlowVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void YAxisJogFastVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis Jog Fast 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", YAxisJogFastVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                YAxisJogFastVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void XAxisJogSlowVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis Jog Slow 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", XAxisJogSlowVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                XAxisJogSlowVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void XAxisJogFastVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis Jog Fast 속도 설정 입력");
            numericPad.txtInput.Text = string.Format("{0:N2}", XAxisJogFastVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                XAxisJogFastVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void TobbabSupplyWeightClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("톱밥 공급 무게 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", TobbabSupplyWeight);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TobbabSupplyWeight = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        

        [GenerateCommand]
        private void FlipImpactDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("박스타격 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", FlipImpactDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipImpactDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void TobbabSupplyTimeoutClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("톱밥공급 타임아웃 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", TobbabSupplyTimeout);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                TobbabSupplyTimeout = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void MistSupplyDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("수분공급 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", MistSupplyDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                MistSupplyDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }
        [GenerateCommand]
        private void FlatDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("톱밥평탄화 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", FlatDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlatDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }
        [GenerateCommand]
        private void BlowDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("톱밥평탄화 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", BlowDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                BlowDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void WashingDurationTimeClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("세정 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", WashingDurationTime);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                WashingDurationTime = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void FlipSwingDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("박스 스윙 시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", FlipSwingDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipSwingDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void FlipOutConveyorDurationClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("분변 배출 컨베이어 가동시간 설정 입력");
            numericPad.txtInput.Text = string.Format("{0}", FlipOutConveyorDuration);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipOutConveyorDuration = Convert.ToInt32(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void XAxisMoveVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis 이동 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", XAxisMoveVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                XAxisMoveVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void YAxisMoveVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis 이동 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", YAxisMoveVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                YAxisMoveVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void ZAxisMoveVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis 이동 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", ZAxisMoveVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                ZAxisMoveVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void FlipAxisMoveVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Flip-Axis 이동 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipAxisMoveVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipAxisMoveVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void XAxisStandbyPositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis 대기 위치 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", XAxisStandbyPosition);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                XAxisStandbyPosition = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void YAxisStandbyPositionClick(RoutedEventArgs args)
        { 
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis 대기 위치 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", YAxisStandbyPosition);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                YAxisStandbyPosition = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void ZAxisStandbyPositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis 대기 위치 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", ZAxisStandbyPosition);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                ZAxisStandbyPosition = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void FlipLimitPlusClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Flip 제한 +각도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipLimitPlus);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipLimitPlus = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void FlipLimitMinusClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Flip 제한 -각도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipLimitMinus);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipLimitMinus = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void BoxFaceUpAngleClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Box Face Up 각도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", BoxFaceUpAngle);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                BoxFaceUpAngle = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void BoxFaceDownAngleClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Box Face Down 각도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", BoxFaceDownAngle);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                BoxFaceDownAngle = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void HvacTargetTemperatureClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("항온항습기 목표 온도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", HvacTargetTemperature);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                HvacTargetTemperature = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }
        [GenerateCommand]
        private void HvacTargetHumidityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("항온항습기 목표 습도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", HvacTargetHumidity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                HvacTargetHumidity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        // 홈 속도 추가_mh.yun_20240701
        [GenerateCommand]
        private void XAxisHomeVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis 홈 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", XAxisHomeVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                XAxisHomeVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void YAxisHomeVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis 홈 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", YAxisHomeVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                YAxisHomeVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void ZAxisHomeVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis 홈 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", ZAxisHomeVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                ZAxisHomeVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void FlipAxisHomeVelocityClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Flip-Axis 홈 속도 설정");
            numericPad.txtInput.Text = string.Format("{0:N2}", FlipAxisHomeVelocity);


            DXDialog dialog = new DXDialog
            {
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                FontSize = 24
            };

            dialog.Width = 400;
            dialog.Height = 500;

            dialog.Left = Application.Current.MainWindow.ActualWidth / 2;
            dialog.Top = Application.Current.MainWindow.ActualHeight / 2;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                FlipAxisHomeVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }


        [GenerateCommand]
        private void FlipAxisMoveVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dFlipMoveVel_Set, FlipAxisMoveVelocity, true);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dFlipMoveVel_Set, FlipAxisMoveVelocity);

        }

        [GenerateCommand]
        private void XAxisMoveVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveVel_Set, XAxisMoveVelocity);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dXMoveVel_Set, XAxisMoveVelocity);

        }

        [GenerateCommand]
        private void YAxisMoveVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveVel_Set, YAxisMoveVelocity);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dYMoveVel_Set, YAxisMoveVelocity);
        }

        [GenerateCommand]
        private void ZAxisMoveVelocitySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveVel_Set, ZAxisMoveVelocity);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oServo_dZMoveVel_Set, ZAxisMoveVelocity);
        }

        [GenerateCommand]
        private void FlipImpactDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nBoxImpact_Duration, FlipImpactDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nBoxImpact_Duration, FlipImpactDuration);
        }

        [GenerateCommand]
        private void FlipOutConveyorDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nOutConv_Duration, FlipOutConveyorDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nOutConv_Duration, FlipOutConveyorDuration);
        }

        [GenerateCommand]
        private void FlipSwingDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nFlipSwing_Duration, FlipSwingDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nFlipSwing_Duration, FlipSwingDuration);
        }

        [GenerateCommand]
        private void TobbabSupplyWeightSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTobbab_Weight, TobbabSupplyWeight);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nTobbab_Weight, TobbabSupplyWeight);
        }

        [GenerateCommand]
        private void TobbabSupplyTimeoutSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTobbab_Timeout, TobbabSupplyTimeout);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nTobbab_Timeout, TobbabSupplyTimeout);
        }

        [GenerateCommand]
        private void WashingDurationTimeSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nWash_Duration, WashingDurationTime);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nWash_Duration, WashingDurationTime);
        }

        [GenerateCommand]
        private void MistSupplyDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nMist_Duration, MistSupplyDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nMist_Duration, MistSupplyDuration);
        }
        [GenerateCommand]
        private void FlatDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nFlat_Duration, FlatDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nFlat_Duration, FlatDuration);
        }
        [GenerateCommand]
        private void BlowDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nBlow_Duration, BlowDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nBlow_Duration, BlowDuration);
        }
        [GenerateCommand]
        private void HvacTargetTemperatureSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetTemp, HvacTargetTemperature);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_fHvac_TargetTemp, HvacTargetTemperature);
        }

        [GenerateCommand]
        private void HvacTargetHumiditySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetHumidity, HvacTargetHumidity);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_fHvac_TargetHumidity, HvacTargetHumidity);
        }

        [GenerateCommand]
        private void FlipLimitMinusSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dFlipSwing_MinusAngle, FlipLimitMinus);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dFlipSwing_MinusAngle, FlipLimitMinus);
        }

        [GenerateCommand]
        private void FlipLimitPlusSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dFlipSwing_PlusAngle, FlipLimitPlus);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dFlipSwing_PlusAngle, FlipLimitPlus);
        }

        [GenerateCommand]
        private void BoxFaceUpClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceUp, BoxFaceUpAngle);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceUp, BoxFaceUpAngle);
        }

        [GenerateCommand]
        private void BoxFaceDownClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceDown, BoxFaceDownAngle);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dFlipPos_BoxFaceDown, BoxFaceDownAngle);
        }

        // 대기위치 추가_mh.yun_240226
        [GenerateCommand]
        private void XAxisStandbyPositionSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dXAxis_WaitPos, XAxisStandbyPosition);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dXAxis_WaitPos, XAxisStandbyPosition);
        }
        [GenerateCommand]
        private void YAxisStandbyPositionSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dYAxis_WaitPos, YAxisStandbyPosition);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dYAxis_WaitPos, YAxisStandbyPosition);
        }
        [GenerateCommand]
        private void ZAxisStandbyPositionSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_dZAxis_WaitPos, ZAxisStandbyPosition);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_dZAxis_WaitPos, ZAxisStandbyPosition);
        }

        // 축인터락 추가_mh.yun_20240627
        [GenerateCommand]
        private void XAxisInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nXAxis_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void XAxisInterlockOffChecked(RoutedEventArgs args) 
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nXAxis_OnOff, (int)eOnOff.OFF, false);
        }

        [GenerateCommand]
        private void YAxisInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nYAxis_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void YAxisInterlockOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nYAxis_OnOff, (int)eOnOff.OFF, false);
        }

        [GenerateCommand]
        private void ZAxisInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nZAxis_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void ZAxisInterlockOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nZAxis_OnOff, (int)eOnOff.OFF, false);
        }

        [GenerateCommand]
        private void FlipAxisInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nFlipAxis_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void FlipAxisInterlockOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nFlipAxis_OnOff, (int)eOnOff.OFF, false);
        }

        [GenerateCommand]
        private void TurnAxisInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nTRHand_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void TurnAxisInterlockOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nTRHand_OnOff, (int)eOnOff.OFF, false);
        }

        [GenerateCommand]
        private void AllInterlockOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nAll_OnOff, (int)eOnOff.ON, true);
        }
        [GenerateCommand]
        private void AllInterlockOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oInterlock_nAll_OnOff, (int)eOnOff.OFF, false);
        }
    }
}


