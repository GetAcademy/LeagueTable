using System;

namespace LeagueTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: Hvilke klasser VET vi at vi trenger
            // 2: Skrive hardkoder scenario
            // 3: Implementere bit for bit av funksjonaliteten

            var t1 = new Team("Team 1");
            var t2 = new Team("Team 2");
            var t3 = new Team("Team 3");
            var scoreTable = new ScoreTable();
            var matchResult = new MatchResult(t1, t2, 2, 1);
            scoreTable.AddResult(matchResult);
            var matchResult2 = new MatchResult(t1, t3, 0, 1);
            scoreTable.AddResult(matchResult2);
            var matchResult3 = new MatchResult(t2, t3, 1, 1);
            scoreTable.AddResult(matchResult3);

            Console.WriteLine(scoreTable.GetDescription());

        }
    }
}
