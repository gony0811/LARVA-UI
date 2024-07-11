using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
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
using System.Xml.Linq;
using DevExpress.Xpf.Core;
using EPLE.App;
using EPLE.IO;
using LARVA_UI.UserControls;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for DigitalIoPage.xaml
    /// </summary>
    public partial class DiagnosticPage : UserControl
    {
        private ObservableCollection<DigitalIndicator> DigitalInputs = new ObservableCollection<DigitalIndicator>();
        private ObservableCollection<DigitalIndicator> DigitalOutputs = new ObservableCollection<DigitalIndicator>();
        private System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public DiagnosticPage()
        {
            InitializeComponent();

        }

        #region Page Init and End
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Data> ioList = new List<Data>(DataManager.Instance.GET_DATA_BY_MODULE("PIO"));

            foreach (Data data in ioList)
            {
                if (data.Direction == eDirection.IN)
                {
                    DigitalIndicator LED = new DigitalIndicator();
                    LED.IoName = data.Name;
                    LED.Caption = "[" + data.Name + "] " + data.Description;
                    //LED.DigitalIndicatorClicked += DigitalIndicator_Clicked;
                    DigitalInputs.Add(LED);
                }
                else if (data.Direction == eDirection.OUT)
                {
                    DigitalIndicator LED = new DigitalIndicator();
                    LED.IoName = data.Name;
                    LED.Caption = "[" + data.Name + "] " + data.Description;
                    LED.DigitalIndicatorClicked += DigitalOutput_Clicked;
                    DigitalOutputs.Add(LED);
                }
            }

            int st, ed, inc;
            st = 0;
            inc = 48;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent1.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent1.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent2.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent2.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent3.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent3.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent4.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent4.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent5.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent5.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent6.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent6.Children.Add(DigitalInputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalInputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DiContent7.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalInputs.Count; i++)
                {
                    DiContent7.Children.Add(DigitalInputs[i]);
                }
            }

            st = 0;
            inc = 48;
            ed = st + inc;

            if (DigitalOutputs.Count >= ed)
            {
                for (int i = st; i < ed; i++)
                {
                    DoContent1.Children.Add(DigitalOutputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalOutputs.Count; i++)
                {
                    DoContent1.Children.Add(DigitalOutputs[i]);
                }
            }

            st = ed;
            ed = st + inc;

            if (DigitalOutputs.Count >= st)
            {
                for (int i = st; i < ed; i++)
                {
                    DoContent2.Children.Add(DigitalOutputs[i]);
                }
            }
            else
            {
                for (int i = st; i < DigitalOutputs.Count; i++)
                {
                    DoContent2.Children.Add(DigitalOutputs[i]);
                }
            }

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        #endregion

        #region Timer poll

        #endregion

        private void DigitalOutput_Clicked(object sender, DigitalIndicator.DigitalIndicationEventArgs e)
        {
            DigitalIndicator digitalOutput = (DigitalIndicator)sender;

            int value = digitalOutput.State > 0 ? 0 : 1; // value change as true or false

            DataManager.Instance.SET_INT_DATA(digitalOutput.IoName, value);
        }

        public void MainContent_SelectionChanged(object sender, DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs e)
        {

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < DigitalOutputs.Count; i++)
            {
                DigitalOutputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalOutputs[i].IoName, out bool result);
            }
            for (int i = 0; i < DigitalInputs.Count; i++)
            {
                DigitalInputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalInputs[i].IoName, out bool result);
            }

            //for (int i = 0; i < DigitalOutputs.Count; i++)
            //{
            //    DigitalOutputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalOutputs[i].IoName, out bool result);
            //}
        }
    }
}
