using Euro.Core.Data;
using Euro.Core.Models.Domain;
using Euro.Core.Services;
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
using Uno.UI.Common;
using Windows.UI.Xaml.Data;

namespace Euro.Core.ViewModels
{
    public class BetsViewModel : MvxNavigationViewModel
    {
        private readonly IUserNotificationService _userNotificationService;
        private List<Bet> _bets;

        private CollectionViewSource _collectionViewSource;

        public ICollectionView BetsView
        {
            get
            {
                if (_collectionViewSource == null)
                {
                    _collectionViewSource = new CollectionViewSource
                    {
                        Source = GroupedBets
                    };
                }

                _collectionViewSource.IsSourceGrouped = true;

                return _collectionViewSource.View;
            }
        }

        public IOrderedEnumerable<IGrouping<DateTime, Bet>> GroupedBets { get; private set; }
        public ICommand SaveCommand { get; set; }

        public BetsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserNotificationService userNotificationService) : base(logProvider, navigationService)
        {
            SaveCommand = new MvxCommand(Save);
            _userNotificationService = userNotificationService;
        }

        public override Task Initialize()
        {
            _bets = DummyBets.GetDummyBets();

            GroupedBets = from m in _bets
                          group m by m.Match.PlayDateTime into g
                          orderby g.Key
                          select g;

            return Task.CompletedTask;
        }

        private void Save()
        {
            _userNotificationService.Show("Successfully saved.");
        }
    }
}