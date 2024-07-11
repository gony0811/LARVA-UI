using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using EPLE.Core.Manager;
using EPLE.IO;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ServoControlViewModel
    {
        public ServoControlViewModel() 
        {

        }

        [GenerateCommand(Name = "ServoEnableClickedCommand")]
        private void ServoEnableClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_ON");
        }

        [GenerateCommand(Name = "ServoDisableClickedCommand")]
        private void ServoDisableClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_OFF");
        }

        [GenerateCommand(Name = "ServoResetClickedCommand")]
        private void ServoResetClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_ALL_RESET");
        }

        [GenerateCommand(Name = "ServoMoveAbsClickedCommand")]
        private void ServoMoveAbsClicked(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_SERVO_X_MOVE_ABS");
        }
    }
}
