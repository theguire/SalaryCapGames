using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryCapData.Data.Models
{
    public class PlayerAssignment
    {
        public int Id { get; set; }
        [Required]
        public int FranchiseId { get; set; }
        [Required]
        public int PlayerId { get; set; }
        //       [Required]
        //public PlayerPosition PlayerPosition { get; set; }
        public string PlayerPosition { get; set; }
        [Required]
        public DateTime DateDrafted { get; set; }
        public DateTime DateDropped { get; set; }
    }
}
