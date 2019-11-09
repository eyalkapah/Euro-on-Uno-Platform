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

namespace Euro.Core.ViewModels
{
    public class MatchesViewModel : MvxNavigationViewModel
    {
        private List<Match> _matches;

        public IOrderedEnumerable<IGrouping<DateTime, Match>> GroupedMatches { get; private set; }

        public MatchesViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public override Task Initialize()
        {
            _matches = new List<Match>
            {
                new Match
                {
                    HostTeamName = "England",
                    HostTeamFlag = Flags.England,
                    GuestTeamName = "Czech Repulibc",
                    GuestTeamFlag = Flags.CzechRepublic,
                    HostScored = 5,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 22)
                },
                new Match
                {
                    HostTeamName = "Bulgaria",
                    HostTeamFlag = Flags.Bulgaria,
                    GuestTeamName = "Montenegro",
                    GuestTeamFlag = Flags.Montenegro,
                    HostScored = 1,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 22)
                }
            };

            GroupedMatches = from m in _matches
                             group m by m.PlayDateTime into g
                             orderby g.Key
                             select g;

            return Task.CompletedTask;
        }
    }
}