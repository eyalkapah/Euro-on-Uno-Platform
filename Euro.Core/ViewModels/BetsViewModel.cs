using Euro.Core.Data;
using Euro.Core.Models.Domain;
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
    public class BetsViewModel : MvxNavigationViewModel
    {
        private List<Bet> _bets;

        public IOrderedEnumerable<IGrouping<DateTime, Bet>> GroupedBets { get; private set; }

        public BetsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
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
    }
}