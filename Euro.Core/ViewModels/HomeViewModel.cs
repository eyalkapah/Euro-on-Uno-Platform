using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.Core.ViewModels
{
    public class HomeViewModel : MvxNavigationViewModel
    {
        public string HelloWorld => "Hello World!!!";
        public IMvxAsyncCommand ShowSecondPageCommand { get; }

        public HomeViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowSecondPageCommand =
                new MvxAsyncCommand(async () => await NavigationService.Navigate<SecondViewModel>());
        }
    }
}