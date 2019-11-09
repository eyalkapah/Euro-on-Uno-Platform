using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.Core.Models.Domain
{
    public class Match
    {
        public int GuestScored { get; set; }
        public string GuestTeamFlag { get; set; }
        public string GuestTeamName { get; set; }
        public int HostScored { get; set; }
        public string HostTeamFlag { get; set; }
        public string HostTeamName { get; set; }
        public int MatchId { get; set; }
        public DateTime PlayDateTime { get; set; }

        public string Result => $"{HostScored}-{GuestScored}";
    }
}