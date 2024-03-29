﻿using Euro.Core.Models.Domain;
using Euro.Core.Models.UI;
using System;
using System.Collections.Generic;

namespace Euro.Core.Data
{
    public static class DummyMatches
    {
        public static List<Match> GetDummyMatches()
        {
            return new List<Match>
            {
                new Match
                {
                    MatchId = 1,
                    HostTeamName = "England",
                    HostTeamFlag = Flags.England,
                    GuestTeamName = "Czech Repulibc",
                    GuestTeamFlag = Flags.CzechRepublic,
                    HostScored = 5,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 22),
                    Group = 'A'
                },
                new Match
                {
                    MatchId = 2,
                    HostTeamName = "Bulgaria",
                    HostTeamFlag = Flags.Bulgaria,
                    GuestTeamName = "Montenegro",
                    GuestTeamFlag = Flags.Montenegro,
                    HostScored = 1,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 22),
                    Group = 'A'
                },
                new Match
                {
                    MatchId = 3,
                    HostTeamName = "Kazakhstan",
                    HostTeamFlag = Flags.Kazakhstan,
                    GuestTeamName = "Scotland",
                    GuestTeamFlag = Flags.Scotland,
                    HostScored = 3,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'I'
                },
                new Match
                {
                    MatchId = 4,
                    HostTeamName = "Cyprus",
                    HostTeamFlag = Flags.Cyprus,
                    GuestTeamName = "San Marino",
                    GuestTeamFlag = Flags.SanMarino,
                    HostScored = 5,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 22),
                    Group = 'I'
                },
                new Match
                {
                    MatchId = 5,
                    HostTeamName = "Northern Ireland",
                    HostTeamFlag = Flags.NorthernIreland,
                    GuestTeamName = "Estonia",
                    GuestTeamFlag = Flags.Estonia,
                    HostScored = 2,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'C'
                },
                new Match
                {
                    MatchId = 6,
                    HostTeamName = "Netherlands",
                    HostTeamFlag = Flags.Netherlands,
                    GuestTeamName = "Belarus",
                    GuestTeamFlag = Flags.Belarus,
                    HostScored = 4,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'C'
                },
                new Match
                {
                    MatchId = 7,
                    HostTeamName = "Slovakia",
                    HostTeamFlag = Flags.Slovakia,
                    GuestTeamName = "Hungary",
                    GuestTeamFlag = Flags.Hungary,
                    HostScored = 2,
                    GuestScored = 0,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'E'
                },
                new Match
                {
                    MatchId = 8,
                    HostTeamName = "Croatia",
                    HostTeamFlag = Flags.Croatia,
                    GuestTeamName = "Azerbaijan",
                    GuestTeamFlag = Flags.Azerbaijan,
                    HostScored = 2,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'E'
                },
                new Match
                {
                    MatchId = 9,
                    HostTeamName = "Israel",
                    HostTeamFlag = Flags.Israel,
                    GuestTeamName = "Slovenia",
                    GuestTeamFlag = Flags.Slovenia,
                    HostScored = 1,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'G'
                },
                new Match
                {
                    MatchId = 10,
                    HostTeamName = "North Macedonia",
                    HostTeamFlag = Flags.NorthMacedonia,
                    GuestTeamName = "Latvia",
                    GuestTeamFlag = Flags.Latvia,
                    HostScored = 3,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'G'
                },
                new Match
                {
                    MatchId = 11,
                    HostTeamName = "Austria",
                    HostTeamFlag = Flags.Austria,
                    GuestTeamName = "Poland",
                    GuestTeamFlag = Flags.Poland,
                    HostScored = 0,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'G'
                },
                new Match
                {
                    MatchId = 12,
                    HostTeamName = "Belgium",
                    HostTeamFlag = Flags.Belgium,
                    GuestTeamName = "Russia",
                    GuestTeamFlag = Flags.Russia,
                    HostScored = 3,
                    GuestScored = 1,
                    PlayDateTime = new DateTime(2019, 3, 21),
                    Group = 'I'
                },
            };
        }
    }
}