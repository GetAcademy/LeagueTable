using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueTable
{
    class MatchResult
    {
        public Team HomeTeam { get; }
        public Team AwayTeam { get; }
        public int HomeGoals { get; }
        public int AwayGoals { get; }

        public MatchResult(Team homeTeam, Team awayTeam, int homeGoals, int awayGoals)
        {
            AwayGoals = awayGoals;
            HomeGoals = homeGoals;
            AwayTeam = awayTeam;
            HomeTeam = homeTeam;
        }
    }
}
