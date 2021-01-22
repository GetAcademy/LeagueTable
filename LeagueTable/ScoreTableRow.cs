using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueTable
{
    class ScoreTableRow
    {
        public string TeamName { get; }
        public int GameCount { get; private set; }
        public int ScoredGoals { get; private set; }
        public int ConcededGoals { get; private set; }


        public ScoreTableRow(string teamName)
        {
            TeamName = teamName;
        }

        public void Add(MatchResult matchResult, bool isHomeTeam)
        {
            GameCount++;
            ScoredGoals += isHomeTeam ? matchResult.HomeGoals : matchResult.AwayGoals;
            ConcededGoals += !isHomeTeam ? matchResult.HomeGoals : matchResult.AwayGoals;
        }
    }
}
