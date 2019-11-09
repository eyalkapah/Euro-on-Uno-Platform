using Euro.Core.Models.UI;
using Euro.Core.Utils;
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
        private bool _navigated = false;
        private List<NavigationItem> _navigationItems;
        private NavigationItem _selectedNavigationItem;
        public string HelloWorld => "Hello World!!!";

        public List<NavigationItem> NavigationItems
        {
            get => _navigationItems;
            set => SetProperty(ref _navigationItems, value);
        }

        public NavigationItem SelectedNavigationItem
        {
            get => _selectedNavigationItem;
            set => SetProperty(ref _selectedNavigationItem, value, () => OnSelectedNavigationItem(value));
        }

        public IMvxAsyncCommand ShowSecondPageCommand { get; }

        public HomeViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public override Task Initialize()
        {
            NavigationItems = new List<NavigationItem>
            {
                new NavigationItem
                {
                    Title = "Home",
                    Glyph = IconsHelper.Home,
                    TargetType = typeof(HomeViewModel)
                },
                new NavigationItem
                {
                    Title = "Standings",
                    Glyph = IconsHelper.Group,
                    TargetType = typeof(StandingsViewModel)
                },
                new NavigationItem
                {
                    Title = "Matches",
                    Glyph = IconsHelper.Play,
                    TargetType = typeof(MatchesViewModel)
                }
            };

            SelectedNavigationItem = NavigationItems.First();

            return Task.CompletedTask;
        }

        private async void OnSelectedNavigationItem(NavigationItem value)
        {
            if (!_navigated)
            {
                _navigated = true;
                return;
            }

            await NavigationService.Navigate(value.TargetType);
        }
    }
}