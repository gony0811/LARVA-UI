using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Utils.About;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.PivotGrid.Printing.TypedStyles;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Mouse;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using EPLE.IO;
using LARVA_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static DevExpress.Utils.Diagnostics.GUIResources;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class TeachingViewModel : INotifyPropertyChanged
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
        private bool isTransferHandStatus;
        [GenerateProperty]
        private bool isTransferClampStatus;
        [GenerateProperty]
        private bool isUpperCoverStatus;

        // 트랜스퍼 실린더 티칭 동작 추가_mh.yun_240709
        [GenerateProperty]
        private bool isBoxHandStatus;
        [GenerateProperty]
        private bool isBoxUpperClampStatus;
        [GenerateProperty]
        private bool isBoxClampStatus;
        [GenerateProperty]
        private bool isFlipClampStatus;
        [GenerateProperty]
        private bool isHandTurnStatus;
        [GenerateProperty]
        private bool isBoxGuideStatus;
        [GenerateProperty]
        private bool isBoxCoverStatus;
        [GenerateProperty]
        private bool isBoxCoverVacStatus;



        [GenerateProperty]
        private List<string> transferHandItems = new List<string>();
        [GenerateProperty]
        private List<string> locationTypeItems = new List<string>();



        [GenerateProperty]
        private long selectedLocationIndex;

        [GenerateProperty]
        private double teaching_X_Position;
        [GenerateProperty]
        private double teaching_Y_In_Position;
        [GenerateProperty]
        private double teaching_Y_Out_Position;
        [GenerateProperty]
        private double teaching_Z_Up_Position;
        [GenerateProperty]
        private double teaching_Z_Down_Position;
        [GenerateProperty]
        private string teaching_Transfer_Hand;
        [GenerateProperty]
        private string teaching_Location_Type;
        [GenerateProperty]
        private double actual_X_Position;
        [GenerateProperty]
        private double actual_Y_Position;
        [GenerateProperty]
        private double actual_Z_Position;


        public ObservableCollection<string> LocationItems { get; set; }

        public TeachingViewModel()
        {
            Initialize();
            UpdateLocationItems();

            
        }

        private void Initialize()
        {
            bool result = false;
            double dVal;
            int nVal;

            DataManager.Instance.DataAccess.DataChangedEvent += DataChanged;

            selectedLocationIndex = 0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Pos, out result);
            if (result)
                Actual_X_Position = dVal;
            else
                Actual_X_Position = 0.0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Pos, out result);
            if (result)
                Actual_Y_Position = dVal;
            else
                Actual_Y_Position = 0.0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Pos, out result);
            if (result)
                Actual_Z_Position = dVal;
            else
                Actual_Z_Position = 0.0;

            nVal = DataManager.Instance.GET_INT_DATA(IoNameHelper.iTrans_nHandLeft_FwdBwd, out result);
            if (result && nVal == 1)
                IsTransferHandStatus = true;
            else
                isTransferHandStatus = false;

            transferHandItems.Add("LEFT");
            transferHandItems.Add("RIGHT");

            locationTypeItems.Add("PROCESS");
            locationTypeItems.Add("STOCKER");
            locationTypeItems.Add("LD/ULD");
            locationTypeItems.Add("BUFFER");
        }

        private void DataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = (Data)e.Data;

            switch (data.Name)
            {
                case "iXAxis.dAct.Pos":
                    Actual_X_Position = (double)data.Value;
                    break;
                case "iYAxis.dAct.Pos":
                    Actual_Y_Position = (double)data.Value;
                    break;
                case "iZAxis.dAct.Pos":
                    Actual_Z_Position = (double)data.Value;
                    break;
            }
        }

        private void UpdateLocationTeachingData(long locationId)
        {
            LOCATION_INFO info = LocationManager.Instance.GetLocationList().Find((item) => { return item.LOCATION_ID == locationId; });

            Teaching_X_Position = info.X_POS;
            Teaching_Y_In_Position = info.Y_IN_POS;
            Teaching_Y_Out_Position = info.Y_OUT_POS;
            Teaching_Z_Up_Position = info.Z_UP_POS;
            Teaching_Z_Down_Position = info.Z_DOWN_POS;
            Teaching_Transfer_Hand = info.TRANSFER_HAND;
            Teaching_Location_Type = info.LOCATION_TYPE;
        }

        public void UpdateLocationItems()
        {
            LocationItems = new ObservableCollection<string>();
            List<string> keys = LocationManager.Instance.GetLocationKeys();

            foreach (string item in keys)
            {
                LocationItems.Add(item);
            }
        }

        [GenerateCommand]
        private void Teaching_X_PositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("X-Axis Teaching 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", Teaching_X_Position);


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
                Teaching_X_Position = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void Teaching_Y_In_PositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis IN Teaching 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", Teaching_Y_In_Position);


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
                Teaching_Y_In_Position = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void Teaching_Y_Out_PositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Y-Axis OUT Teaching 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", Teaching_Y_Out_Position);


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
                Teaching_Y_Out_Position = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void Teaching_Z_Up_PositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis UP Teaching 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", Teaching_Z_Up_Position);


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
                Teaching_Z_Up_Position = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void Teaching_Z_Down_PositionClick(RoutedEventArgs args)
        {
            UserControls.NumericPad numericPad = new UserControls.NumericPad("Z-Axis DOWN Teaching 위치 입력");
            numericPad.txtInput.Text = string.Format("{0:N3}", Teaching_Z_Down_Position);


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
                Teaching_Z_Down_Position = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        [GenerateCommand]
        private void TransferHandRightChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.BACKWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERHAND, true);
        }

        [GenerateCommand]
        private void TransferHandLeftChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.FORWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERHAND, true);
        }

        [GenerateCommand]
        private void TransferClampLockChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.LOCK);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCLAMP, true);
        }

        [GenerateCommand]
        private void TransferClampUnlockChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.UNLOCK);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCLAMP, true);
        }

        [GenerateCommand]
        private void UpperCoverUpChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.UP);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPUPPERCOVER, true);
        }

        [GenerateCommand]
        private void UpperCoverDownChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.DOWN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_FLIPUPPERCOVER, true);
        }

        // 트랜스퍼 실린더 티칭 동작 추가_mh.yun_240709
        // 박스핸드 = TRSHandCommand
        [GenerateCommand]
        private void BoxHandFwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eLeftRight.RIGHT);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERHAND, true);
        }
        [GenerateCommand]
        private void BoxHandBwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eLeftRight.LEFT);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERHAND, true);
        }

        // 박스 상단 클램프 = TRSClampCylinderFwdBwdCommand
        [GenerateCommand]
        private void BoxUpperClampFwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_FwdBwd, (int)eFwdBwd.FORWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TransferClampCylinder_FwdBwd, true);
        }
        [GenerateCommand]
        private void BoxUpperClampBwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_FwdBwd, (int)eFwdBwd.BACKWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TransferClampCylinder_FwdBwd, true);
        }

        // 박스 클램프 = TRSClampCylinderUpDownCommand
        [GenerateCommand]
        private void BoxClampUpChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_UpDown, (int)eUpDown.UP);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransferClimpCylinder_UpDown, true);
        }
        [GenerateCommand]
        private void BoxClampDownChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nClampCyl_UpDown, (int)eUpDown.DOWN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransferClimpCylinder_UpDown, true);
        }

        // 박스 반전 클램프 = TRSFlipClampCommand
        [GenerateCommand]
        private void BoxFlipClampUpChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nFlipClampCyl_UpDown, (int)eUpDown.UP);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_FlipClimpCylinder, true);
        }
        [GenerateCommand]
        private void BoxFlipClampDownChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nFlipClampCyl_UpDown, (int)eUpDown.DOWN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_FlipClimpCylinder, true);
        }

        // 박스 회전 = TRSHandTurnCommand
        [GenerateCommand]
        private void HandTurnRightChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHandTurn_LeftRight, (int)eLeftRight.RIGHT);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_FlipClimpCylinder, true);
        }
        [GenerateCommand]
        private void HandTurnLeftChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHandTurn_LeftRight, (int)eLeftRight.LEFT);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_FlipClimpCylinder, true);
        }

        // 박스 가이드 = TRSBoxGuideCommand
        [GenerateCommand]
        private void BoxGuideFwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxGuide_FwdBwd, (int)eFwdBwd.FORWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_Guide, true);
        }
        [GenerateCommand]
        private void BoxGuideBwdChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxGuide_FwdBwd, (int)eFwdBwd.BACKWARD);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_nTransfer_Guide, true);
        }

        // 박스 덮개 실린더 = TRSCoverCommand
        [GenerateCommand]
        private void BoxCoverUpChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.UP);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVER, true);
        }
        [GenerateCommand]
        private void BoxCoverDownChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.DOWN);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVER, true);
        }

        // 박스 덮개 Air = TRSCoverVacCommand
        [GenerateCommand]
        private void UpperCoverVacOnChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.ON);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVAC, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);
        }
        [GenerateCommand]
        private void UpperCoverVacOffChecked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.OFF);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.ON);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVAC, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);

            DateTime st = DateTime.Now;
            Task task = Task.Factory.StartNew(() =>
            {
                bool run = true;
                while (run)
                {
                    TimeSpan ts = DateTime.Now - st;

                    if (ts.Milliseconds > 1000)
                    {
                        DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oExec_TRANSFERCOVERVACEJECT, true);
                        run = false;
                        return;
                    }
                }
            });


        }




        [GenerateCommand]
        private void SelectionChanged(RoutedEventArgs args)
        {
            SelectionChangedEventArgs eventArgs = args as SelectionChangedEventArgs;

            if (eventArgs != null)
            {
                char[] sep = { ':' };
                string[] arrStr = eventArgs.AddedItems[0].ToString().Split(sep);
                selectedLocationIndex = long.Parse(arrStr[0]);

                UpdateLocationTeachingData(selectedLocationIndex);
            }

        }

        [GenerateCommand]
        private void TeachingXPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateXPosition(selectedLocationIndex, Teaching_X_Position);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetXPosition((int)selectedLocationIndex, Teaching_X_Position, true);
        }

        [GenerateCommand]
        private void TeachingYInPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateYInPosition(selectedLocationIndex, Teaching_Y_In_Position);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetYInPosition((int)selectedLocationIndex, Teaching_Y_In_Position, true);
        }

        [GenerateCommand]
        private void TeachingYOutPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateYOutPosition(selectedLocationIndex, Teaching_Y_Out_Position);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetYOutPosition((int)selectedLocationIndex, Teaching_Y_Out_Position, true);
        }

        [GenerateCommand]
        private void TeachingZUpPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateZUpPosition(selectedLocationIndex, Teaching_Z_Up_Position);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetZUpPosition((int)selectedLocationIndex, Teaching_Z_Up_Position, true);
        }
        [GenerateCommand]
        private void TeachingZDownPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateZDownPosition(selectedLocationIndex, Teaching_Z_Down_Position);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetZDownPosition((int)selectedLocationIndex, Teaching_Z_Down_Position, true);
        }

        [GenerateCommand]
        private void TeachingTransferHandSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateTransferHand(selectedLocationIndex, Teaching_Transfer_Hand);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetTransferHand((int)selectedLocationIndex, Teaching_Transfer_Hand, true);
        }

        [GenerateCommand]
        private void TeachingLocationTypeSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateLocationType(selectedLocationIndex, Teaching_Location_Type);
            //UpdateLocationTeachingData(selectedLocationIndex);
            SetLocationType((int)selectedLocationIndex, Teaching_Location_Type, true);
        }

        [GenerateCommand]
        private void JogXAxisPlusFast(RoutedEventArgs args)
        {

            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisPlusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisMinusFast(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisMinusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogXAxisStop(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisPlusFast(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisPlusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisMinusFast(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisMinusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogYAxisStop(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }



        [GenerateCommand]
        private void JogZAxisPlusFast(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisPlusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_PLUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisMinusFast(RoutedEventArgs args)
        {
            bool bFastMode = true;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisMinusSlow(RoutedEventArgs args)
        {
            bool bFastMode = false;
            object[] argument = new object[] { bFastMode };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_JOG_MINUS", argument);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogZAxisStop(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_JOG_STOP");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void ApplyButtonClick(RoutedEventArgs args)
        {
            bool result = false;
            List<Data> teachingList = DataManager.Instance.GET_DATA_BY_MODULE("TEACHING").ToList();
     

            foreach (Data io in teachingList)
            {
                string[] arrStr = io.Name.Split(new char[] { '.' });

                int id = Convert.ToInt32(arrStr[2]);

                if (id == 246)
                {

                }

                if (arrStr[1].Equals("dXPos"))
                {
                    double dXPos = DataManager.Instance.GET_DOUBLE_DATA(io.Name, out result);

                    if (result)
                    {
                        Teaching_X_Position = dXPos;
                        LocationManager.Instance.UpdateXPosition(id, Teaching_X_Position);
                    }        
                }
                else if (arrStr[1].Equals("dYInPos"))
                {
                    double dYInPos = DataManager.Instance.GET_DOUBLE_DATA(io.Name, out result);

                    if (result)
                    {
                        Teaching_Y_In_Position = dYInPos;
                        LocationManager.Instance.UpdateYInPosition(id, Teaching_Y_In_Position);
                    }                  
                }
                else if (arrStr[1].Equals("dYOut"))
                {
                    double dYOut = DataManager.Instance.GET_DOUBLE_DATA(io.Name, out result);

                    if (result)
                    {
                        Teaching_Y_Out_Position = dYOut;
                        LocationManager.Instance.UpdateYInPosition(id, Teaching_Y_Out_Position);
                    }
                }
                else if (arrStr[1].Equals("dZUp"))
                {
                    double dZUp = DataManager.Instance.GET_DOUBLE_DATA(io.Name, out result);

                    if (result)
                    {
                        Teaching_Z_Up_Position = dZUp;
                        LocationManager.Instance.UpdateZUpPosition(id, Teaching_Z_Up_Position);
                    }
                }
                else if (arrStr[1].Equals("dZDown"))
                {
                    double dZDown = DataManager.Instance.GET_DOUBLE_DATA(io.Name, out result);

                    if (result)
                    {
                        Teaching_Z_Down_Position = dZDown;
                        LocationManager.Instance.UpdateZUpPosition(id, Teaching_Z_Down_Position);
                    }
                }
                else if (arrStr[1].Equals("nHand"))
                {
                    int nHand = DataManager.Instance.GET_INT_DATA(io.Name, out result);

                    if (!result) return;

                    if (nHand == (int)eLeftRight.LEFT)
                    {
                        Teaching_Transfer_Hand = "LEFT";
                       
                    }
                    else if (nHand == (int) eLeftRight.RIGHT)
                    {
                        Teaching_Transfer_Hand = "RIGHT";
                    }
                    else
                    {
                        Teaching_Transfer_Hand = "UNKNOWN";
                    }

                    LocationManager.Instance.UpdateTransferHand(id, Teaching_Transfer_Hand);
                }
                else if (arrStr[1].Equals("nType"))
                {
                    int nType = DataManager.Instance.GET_INT_DATA(io.Name, out result);

                    if (!result) return;

                    if (nType == (int)eLocationType.STOCKER)
                    {
                        Teaching_Location_Type = "STOCKER";
                        
                    }
                    else if (nType == (int)eLocationType.PROCESS)
                    {
                        Teaching_Location_Type = "PROCESS";
                    }
                    else if ((nType == (int)eLocationType.LOADER))
                    {
                        Teaching_Location_Type = "LOADER";
                    }
                    else if ((nType == (int)eLocationType.BUFFER))
                    {
                        Teaching_Location_Type = "BUFFER";
                    }
                    else
                    {
                        Teaching_Location_Type = "UNKNOWN";
                    }

                    LocationManager.Instance.UpdateLocationType(id, Teaching_Location_Type);
                }
                else
                {
                    continue;
                }
            }
        }

        [GenerateCommand]
        private void TeachingXPositionMoveClick(RoutedEventArgs args)
        {
            double X_Velocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dXMoveVel_Set, out bool result);

            if (!result) return;

            object[] argument = { X_Velocity, Teaching_X_Position }; 

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_X_MOVE_ABS", argument);

            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Pos, Teaching_X_Position);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TeachingYInPositionMoveClick(RoutedEventArgs args)
        {
            double Y_Velocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveVel_Set, out bool result);

            if (!result) return;

            object[] argument = { Y_Velocity, Teaching_Y_In_Position };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_MOVE_ABS", argument);

            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, Teaching_Y_In_Position);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TeachingYOutPositionMoveClick(RoutedEventArgs args)
        {
            double Y_Velocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dYMoveVel_Set, out bool result);

            if (!result) return;

            object[] argument = { Y_Velocity, Teaching_Y_Out_Position };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Y_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, Teaching_Y_Out_Position);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TeachingZUpPositionMoveClick(RoutedEventArgs args)
        {
            double Z_Velocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveVel_Set, out bool result);

            if (!result) return;

            object[] argument = { Z_Velocity, Teaching_Z_Up_Position };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, Teaching_Z_Up_Position);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TeachingZDownPositionMoveClick(RoutedEventArgs args)
        {
            double Z_Velocity = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.oServo_dZMoveVel_Set, out bool result);

            if (!result) return;

            object[] argument = { Z_Velocity, Teaching_Z_Down_Position };

            FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_SERVO_Z_MOVE_ABS", argument);
            //DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, Teaching_Z_Down_Position);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, false);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TeachingXPositionStopClick(RoutedEventArgs args)
        { 
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Halt, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_MoveABS, false);
        }

        [GenerateCommand]
        private void TeachingYPositionStopClick(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Y_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveABS, false);
        }

        [GenerateCommand]
        private void TeachingZPositionStopClick(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_Z_HALT");
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, true);
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveABS, false);
        }

        private void SetXPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dXPos.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            } 
        }

        private void SetYInPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dYInPos.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetYOutPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dYOut.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);
            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }          
        }

        private void SetZUpPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dZUp.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetZDownPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dZDown.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);
            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetTransferHand(int location_id, string leftRight, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.nHand.{0:000}", location_id);
            int nHand = 0;

            if (leftRight.StartsWith("L"))
            {
                nHand = 1;
            }
            else
            {
                nHand = 2;
            }

            DataManager.Instance.SET_INT_DATA(ioName, nHand);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, nHand);
            }
            
        }

        private void SetLocationType(int location_id, string loc_type, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.nType.{0:000}", location_id);
            int nType = 0;

            if (loc_type.StartsWith("S"))
            {
                nType = 1;
            }
            else if (loc_type.StartsWith("P"))
            {
                nType = 2;
            }
            else if (loc_type.StartsWith("L"))
            {
                nType = 3;
            }
            else if (loc_type.StartsWith("B"))
            {
                nType = 4;
            }
            else
            {
                nType = 0;
            }

            DataManager.Instance.SET_INT_DATA(ioName, nType);       

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, nType);
            }
        }
    }
}
