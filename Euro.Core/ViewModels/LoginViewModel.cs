using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Euro.Core.ViewModels
{
    public class LoginViewModel : MvxNavigationViewModel
    {
        public ICommand CancelCommand { get; set; }

        public LoginViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            CancelCommand = new MvxCommand(Cancel);
        }

        private void Cancel()
        {
            NavigationService.Close(this);
        }
    }
}