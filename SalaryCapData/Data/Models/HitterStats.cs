using System;

using static SalaryCapData.ConsumeJson.Models.Game.HitterPoints;

namespace SalaryCapData.Data.Models
{
    public class HitterStats
    {


        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public float Average { get; set; }
        public int GamesPlayed { get; set; }
        public int AtBats { get; set; }
        public bool IsCumulative { get; set; }

        public DateTime Date { get; set; }
        public int Runs { get; set; }
        public int Hits { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int RBI { get; set; }
        public int Walks { get; set; }
        public int StolenBases { get; set; }
        public int Sacrifices { get; set; }
        public int ExtraBases { get; set; }
        public int TotalBases { get; set; }
        public int Strikeouts { get; set; }


        public int GetHitterPoints()
        {
            if ( this != null )
            {
                int hitPoints = this.Hits * (int)HitterPointValues.Hit;
                int runPoints = this.Runs * (int)HitterPointValues.Run;
                int doublePoints = this.Doubles * (int)HitterPointValues.Double;
                int triplePoints = this.Triples * (int)HitterPointValues.Triple;
                int homeRunPoints = this.HomeRuns * (int)HitterPointValues.HomeRun;
                int rbiPoints = this.RBI * (int)HitterPointValues.RBI;
                int walkPoints = this.Walks * (int)HitterPointValues.Walk;
                int stolenBasePoints = this.StolenBases * (int)HitterPointValues.StolenBase;
                int strikeoutPoints = this.Strikeouts * (int)HitterPointValues.Strikeout;
                int sacrificePoints = this.Sacrifices;

                return (hitPoints
                        + runPoints
                        + doublePoints
                        + triplePoints
                        + homeRunPoints
                        + rbiPoints
                        + walkPoints
                        + stolenBasePoints
                        + sacrificePoints
                        + strikeoutPoints);
            }
            else
                return 0;

        }
    }
}
