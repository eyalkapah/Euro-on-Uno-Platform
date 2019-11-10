using Euro.Core.Models.Domain;
using System.Collections.Generic;

namespace Euro.Core.Data
{
    public static class DummyBets
    {
        public static List<Bet> GetDummyBets()
        {
            var matches = DummyMatches.GetDummyMatches();

            return new List<Bet>
            {
                new Bet
                {
                    BetId = 1,
                    MatchId = 1,
                    Match = matches.Find(m => m.MatchId == 1),
                    HostTeamScore = 1,
                    GuestTeamScore = 1
                },
                new Bet
                {
                    BetId = 2,
                    MatchId = 2,
                    Match = matches.Find(m => m.MatchId == 2),
                    HostTeamScore = 2,
                    GuestTeamScore = 2
                },
                new Bet
                {
                    BetId = 3,
                    MatchId = 3,
                    Match = matches.Find(m => m.MatchId == 3),
                    HostTeamScore = 3,
                    GuestTeamScore = 3
                }
            };
        }
    }
}