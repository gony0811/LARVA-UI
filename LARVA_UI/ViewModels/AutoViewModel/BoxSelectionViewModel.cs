using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using EPLE.IO;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class BoxSelectionViewModel
    {

        [GenerateCommand]
        private void BoxSelectionClick(RoutedEventArgs args)
        {
            SimpleButton button = args.Source as SimpleButton;

            string[] name = button.Content.ToString().Split('\n');

            if (button.IsChecked == true)
            {
                this.BoxSelectedItems.Add(name[0]);
            }
                
            else
                this.BoxSelectedItems.Remove(name[0]);

            if(this.BoxSelectedItems.Count > 0)
            {
                this.IsEnabled_btn_larva_level_0 = true;
                this.IsEnabled_btn_larva_level_1 = true;
                this.IsEnabled_btn_larva_level_2 = true;
                this.IsEnabled_btn_larva_level_3 = true;
                this.IsEnabled_btn_larva_level_4 = true;
                this.IsEnabled_btn_larva_level_5 = true;
                this.IsEnabled_btn_larva_level_6 = true;
                this.IsEnabled_btn_larva_level_7 = true;
            }
            else
            {
                this.IsEnabled_btn_larva_level_0 = false;
                this.IsEnabled_btn_larva_level_1 = false;
                this.IsEnabled_btn_larva_level_2 = false;
                this.IsEnabled_btn_larva_level_3 = false;
                this.IsEnabled_btn_larva_level_4 = false;
                this.IsEnabled_btn_larva_level_5 = false;
                this.IsEnabled_btn_larva_level_6 = false;
                this.IsEnabled_btn_larva_level_7 = false;
            }
        }

        [GenerateCommand]
        private void SelectionChanged(RoutedEventArgs args)
        {
            SelectionChangedEventArgs eventArgs = args as SelectionChangedEventArgs;

            //if (eventArgs != null)
            //{
            //    char[] sep = { ':' };
            //    string[] arrStr = eventArgs.AddedItems[0].ToString().Split(sep);
            //    selectedLocationIndex = long.Parse(arrStr[0]);

            //    UpdateLocationTeachingData(selectedLocationIndex);
            //}

        }

        [GenerateCommand]
        private void LarvaLevel_0_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "");
            }

            InitializeButtonStatus();
            
        }

        [GenerateCommand]
        private void LarvaLevel_1_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "성충");
            }

            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_2_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "알");
            }
            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_3_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "1~2령");
            }
            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_4_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "3령");
            }
            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_5_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "3령 금식");
            }
            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_6_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "3령 출하");
            }
            InitializeButtonStatus();
        }

        [GenerateCommand]
        private void LarvaLevel_7_Clicked(RoutedEventArgs args)
        {
            if (this.BoxSelectedItems.Count == 0)
                return;

            foreach (var item in this.BoxSelectedItems)
            {
                string[] name = item.Split('\n');
                LOCATION_INFO info = LocationManager.Instance.GetLocationByName(name[0]);
                LocationManager.Instance.UpdateLocationLevel(info.LOCATION_ID, "코쿤");
            }
            InitializeButtonStatus();
        }
    }
}
