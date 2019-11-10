using Euro.Core.Data;
using Euro.Core.Models.Domain;
using Euro.Core.Models.UI;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Euro.Core.ViewModels
{
    public class MatchesViewModel : MvxNavigationViewModel
    {
        private List<Match> _matches;

        public IOrderedEnumerable<IGrouping<DateTime, Match>> GroupedMatches { get; private set; }
        public CollectionViewSource GroupedMatchesCVS { get; set; }

        public MatchesViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public override Task Initialize()
        {
            _matches = DummyMatches.GetDummyMatches();

            GroupedMatches = from m in _matches
                             group m by m.PlayDateTime into g
                             orderby g.Key
                             select g;

            //GroupedMatchesCVS = new CollectionViewSource
            //{
            //    Source = GroupedMatches,
            //    IsSourceGrouped = true
            //};

            return Task.CompletedTask;
        }
    }
}