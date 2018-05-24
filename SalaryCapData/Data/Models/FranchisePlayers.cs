namespace SalaryCapData.Data.Models
{
    public class FranchisePlayers
    {
        public int Id { get; set; }
        public int FranchiseId { get; set; }
        public PlayerAssignment Catcher { get; set; }
        public PlayerAssignment FirstBase { get; set; }
        public PlayerAssignment SecondBase { get; set; }
        public PlayerAssignment ThirdBase { get; set; }
        public PlayerAssignment ShortStop { get; set; }
        public PlayerAssignment Outfield1 { get; set; }
        public PlayerAssignment Outfield2 { get; set; }
        public PlayerAssignment Outfield3 { get; set; }
        public PlayerAssignment DesignatedHitter { get; set; }
        public PlayerAssignment Pitcher1 { get; set; }
        public PlayerAssignment Pitcher2 { get; set; }
        public PlayerAssignment Pitcher3 { get; set; }
        public PlayerAssignment Pitcher4 { get; set; }
    }
}
