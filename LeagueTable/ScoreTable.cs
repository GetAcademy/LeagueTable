using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueTable
{
    class ScoreTable
    {
        private Dictionary<Team, ScoreTableRow> _rows;

        public ScoreTable()
        {
            _rows = new Dictionary<Team, ScoreTableRow>();
        }

        public void AddResult(MatchResult matchResult)
        {
            var homeRow = GetOrCreateScoreTableRow(matchResult.HomeTeam);
            homeRow.Add(matchResult, true);
            var awayRow = GetOrCreateScoreTableRow(matchResult.AwayTeam);
            awayRow.Add(matchResult, false);
        }

        private ScoreTableRow GetOrCreateScoreTableRow(Team team)
        {
            if (_rows.ContainsKey(team)) return _rows[team];
            var scoreTableRow = new ScoreTableRow(team.Name);
            _rows.Add(team, scoreTableRow);
            return scoreTableRow;
        }

        public string GetDescription()
        {
            var txt = new StringBuilder();
            foreach (var row in _rows.Values)
            {
                txt.AppendLine($"{row.TeamName} - {row.GameCount} {row.ScoredGoals} {row.ConcededGoals}");
            }

            return txt.ToString();
        }
    }
}
