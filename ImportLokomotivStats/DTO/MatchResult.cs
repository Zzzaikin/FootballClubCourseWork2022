using System;

namespace ImportLokomotivStats.DTO
{
    internal class MatchResult
    {
        internal int Id { get; set; }

        internal DateTime Date { get; set; }

        internal string HomeTeamName { get; set; }

        internal string VisitorTeamName { get; set; }

        internal int HomeTeamGolasCountInMatch { get; set; }

        internal int VisitorTeamGolasCountInMatch { get; set; }

        internal int HomeTeamGoalsCountInGeneral { get; set; }

        internal int VizitorTeamGoalsCountInGeneral { get; set; }

        internal string CityName { get; set; }
    }
}
