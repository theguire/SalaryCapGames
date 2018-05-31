namespace SalaryCapData.Data.Models
{
    public class FranchisePlayers
    {
        public int Id { get; set; }
        public int FranchiseId { get; set; }
        public HitterStats Catcher { get; set; }
        public HitterStats FirstBase { get; set; }
        public HitterStats SecondBase { get; set; }
        public HitterStats ThirdBase { get; set; }
        public HitterStats ShortStop { get; set; }
        public HitterStats Outfield1 { get; set; }
        public HitterStats Outfield2 { get; set; }
        public HitterStats Outfield3 { get; set; }
        public HitterStats DesignatedHitter { get; set; }
        public PitcherStats Pitcher1 { get; set; }
        public PitcherStats Pitcher2 { get; set; }
        public PitcherStats Pitcher3 { get; set; }
        public PitcherStats Pitcher4 { get; set; }
    }
}
