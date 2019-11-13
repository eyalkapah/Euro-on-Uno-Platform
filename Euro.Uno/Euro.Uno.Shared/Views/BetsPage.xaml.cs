﻿using Euro.Core.ViewModels;
using MvvmCross.Platforms.Uap.Presenters.Attributes;
using MvvmCross.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Euro.Uno.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    [MvxRegionPresentation("FrameContent")]
    public sealed partial class BetsPage : BetRootPage
    {
        public BetsViewModel Vm => DataContext as BetsViewModel;
        private ResourceDictionary _resources;

        public BetsPage()
        {
            this.InitializeComponent();

            base.RegisterStripModule(ExampleInAppNotification);
            _resources = this.Resources;
        }

        private void ShowInAppNotification_Click(object sender, RoutedEventArgs e)
        {
            ExampleInAppNotification.Show(3000);

            //object inAppNotificationWithButtonsTemplate = null;
            //bool? isTemplatePresent = _resources?.TryGetValue("InAppNotificationWithButtonsTemplate", out inAppNotificationWithButtonsTemplate);

            //if (isTemplatePresent == true && inAppNotificationWithButtonsTemplate is DataTemplate template)
            //{
            //    ExampleInAppNotification.Show(5);
            //}
        }
    }
}