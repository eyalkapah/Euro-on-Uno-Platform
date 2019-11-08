using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.Extensions;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Euro.Uno
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App
    {
        public App()
        {
#if __WASM__
            Windows.UI.Core.CoreDispatcher.HasThreadAccessOverride = true;
            MvxSetupSingleton.SupportsMultiThreadedStartup = false;
#endif

            ConfigureFilters(LogExtensionPoint.AmbientLoggerFactory);
            InitializeComponent();

            UnhandledException += App_UnhandledException;
        }

        private void App_UnhandledException(object sender, Windows.UI.Xaml.UnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("Unhandled exception:" + e.Message + "|" + e.Exception?.Message);
            Debug.WriteLine("Stack:" + e.Exception?.StackTrace);
            Debug.WriteLine("Inner exception:" + e.Exception?.InnerException?.Message);
            Debug.WriteLine("Inner stack:" + e.Exception?.InnerException?.StackTrace);
        }

        static void ConfigureFilters(ILoggerFactory factory)
        {
            using (var logFactory = new LoggerFactory())
            {
                logFactory.WithFilter(new FilterLoggerSettings
                {
                    { "Uno", LogLevel.Warning },
                    { "Windows", LogLevel.Warning },

                    // Debug JS interop
                    // { "Uno.Foundation.WebAssemblyRuntime", LogLevel.Debug },

                    // Generic Xaml events
                    // { "Windows.UI.Xaml", LogLevel.Debug },
                    // { "Windows.UI.Xaml.VisualStateGroup", LogLevel.Debug },
                    // { "Windows.UI.Xaml.StateTriggerBase", LogLevel.Debug },
                    // { "Windows.UI.Xaml.UIElement", LogLevel.Debug },

                    // Layouter specific messages
                    // { "Windows.UI.Xaml.Controls", LogLevel.Debug },
                    // { "Windows.UI.Xaml.Controls.Layouter", LogLevel.Debug },
                    // { "Windows.UI.Xaml.Controls.Panel", LogLevel.Debug },
                    // { "Windows.Storage", LogLevel.Debug },

                    // Binding related messages
                    // { "Windows.UI.Xaml.Data", LogLevel.Debug },

                    // DependencyObject memory references tracking
                    // { "ReferenceHolder", LogLevel.Debug },
                }
                );
            }
        }
    }

    public abstract class StarterApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}