using Euro.Core.Services;
using Euro.Uno.Shared.CustomControls.InAppNotification;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Euro.Uno.Shared.Views
{
    public class BetRootPage : MvxWindowsPage
    {
        private IUserNotificationService _notificationService;

        public InAppNotification StripModule { get; private set; }

        public BetRootPage()
        {
            _notificationService = Mvx.IoCProvider.Resolve<IUserNotificationService>();
            _notificationService.Notify += UserNotificationService_Notify;
        }

        private void UserNotificationService_Notify(object sender, string message)
        {
            var textBlock = StripModule.Content as TextBlock;
            textBlock.Text = message;
            StripModule.Show(3000);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _notificationService.Notify -= UserNotificationService_Notify;

            base.OnNavigatedFrom(e);
        }

        internal void RegisterStripModule(InAppNotification stripModule)
        {
            StripModule = stripModule;
        }
    }
}