using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LARVA_UI.ViewModels
{
    public class SplashScreenViewModel
    {
        public virtual PredefinedSplashScreenType SplashScreenType { get; set; }
        public virtual WindowStartupLocation StartupLocation { get; set; }
        public virtual bool TrackOwnerPosition { get; set; }
        public virtual InputBlockMode InputBlock { get; set; }
        public virtual bool IsTrackOwnerPositionEnabled { get; set; }
        public virtual int ShowDelay { get; set; }
        public virtual int MinDuration { get; set; }



        public SplashScreenViewModel()
        {
            SplashScreenType = PredefinedSplashScreenType.Fluent;
            StartupLocation = WindowStartupLocation.CenterOwner;
            InputBlock = InputBlockMode.WindowContent;
        }
        protected void OnStartupLocationChanged()
        {
            if (StartupLocation == WindowStartupLocation.CenterOwner)
            {
                IsTrackOwnerPositionEnabled = true;
            }
            else
            {
                IsTrackOwnerPositionEnabled = false;
                TrackOwnerPosition = false;
            }
        }
    }
}
