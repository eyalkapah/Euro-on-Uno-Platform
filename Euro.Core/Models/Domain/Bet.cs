using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.Core.Models.Domain
{
    public class Bet
    {
        public int BetId { get; set; }
        public int GuestTeamScore { get; set; }
        public int HostTeamScore { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}