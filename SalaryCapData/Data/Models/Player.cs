using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryCapData.Data.Models
{
    public class Player
    {
        [DatabaseGenerated( DatabaseGeneratedOption.None )]
        public int Id { get; set; }
        //public string PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public bool IsRookie { get; set; }
        public string Position { get; set; }
        public decimal InitialValue { get; set; }
        public int TotalPoints { get; set; }
        //{
        //	get { return TotalPoints; }
        //	set
        //	{
        //		TotalPoints = GetHitterPoints();

        //	}
        //}
        //public decimal CurrentValue { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public HitterStats HitterStats { get; set; }
        public PitcherStats PitcherStats { get; set; }
        //public IEnumerable<PlayerPosition> PlayerPositions { get; set; }




    }


}
