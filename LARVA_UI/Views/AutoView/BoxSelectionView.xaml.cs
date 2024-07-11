using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LARVA_UI.Views
{
    /// <summary>
    /// BoxSelectionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BoxSelectionView : UserControl
    {
        public BoxSelectionView()
        {
            InitializeComponent();
        }

        //public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("BoxSelectedItems", typeof(ObservableCollection<string>), typeof(BoxSelectionView), new PropertyMetadata(new ObservableCollection<string>()));

        //public ObservableCollection<string> BoxSelectedItems
        //{
        //    get { return (ObservableCollection<string>)GetValue(ItemsProperty); }
        //    set { SetValue(ItemsProperty, value); }
        //}
    }
}
