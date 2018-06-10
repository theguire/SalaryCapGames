using SalaryCapData.ConsumeJson.Models.Game;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryCapData.Data.Models
{
    public class PitcherStats
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public DateTime Date { get; set; }
        public bool IsCumulative { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Saves { get; set; }
        public int Holds { get; set; }
        [DisplayFormat( DataFormatString = "{0:0.0}" )]
        public float InningsPitched { get; set; }
        public int HitsAllowed { get; set; }
        public int PitcherWalks { get; set; }
        public int EarnedRunsAllowed { get; set; }
        [DisplayFormat( DataFormatString = "{0:0.00}" )]
        public float ERA { get; set; }
        public int CompleteGames { get; set; }
        public int Strikeouts { get; set; }
        public int GamesFinished { get; set; }
        [DisplayFormat( DataFormatString = "{0:0.00}" )]
        public float WHIP { get; set; }


        public int GetPitcherPoints()
        {
            if ( this != null )
            {
                int hitsPoints = this.HitsAllowed * (int)GamePoints.PitcherPointValues.Hit;
                int runPoints = this.EarnedRunsAllowed * (int)GamePoints.PitcherPointValues.Run;
                int WinsPoints = this.Wins * (int)GamePoints.PitcherPointValues.Win;
                int completeGamesPoints = this.CompleteGames * (int)GamePoints.PitcherPointValues.CompleteGamne;
                int LosesPoints = this.Loses * (int)GamePoints.PitcherPointValues.Loss;
                int HoldsPoints = this.Holds * (int)GamePoints.PitcherPointValues.Hold;
                int walkPoints = this.PitcherWalks * (int)GamePoints.PitcherPointValues.Walk;
                int IPPoints = (int)this.InningsPitched * (int)GamePoints.PitcherPointValues.InningPitched;
                int strikeoutPoints = this.Strikeouts * (int)GamePoints.PitcherPointValues.SO;

                return (hitsPoints
                        + runPoints
                        + WinsPoints
                        + completeGamesPoints
                        + LosesPoints
                        + walkPoints
                        //+ IPPoints
                        + strikeoutPoints);
            }
            else
                return 0;

        }

    }
}
