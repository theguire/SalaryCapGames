

using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryCapData.Data.Models
{
    public class Franchise
    {
        public int Id { get; set; }

        [Required]
        [Display( Name = "Franchise Name" )]
        [StringLength( 50, MinimumLength = 5,
             ErrorMessage = "Franchise name must be between 5 - 50 characters." )]
        [RegularExpression( @"^[A-Za-z0-9-]*$" )]
        public string Name { get; set; }

        [Display( Name = "Nickname" )]
        [StringLength( 10, MinimumLength = 5,
             ErrorMessage = "Nickname name must be between 5 - 10 characters." )]
        [RegularExpression( @"^[A-Za-z0-9-]*$" )]
        public string AbbreviatedName { get; set; }

        public string ImageUrl { get; set; }

        public int LeagueId { get; set; }
        public virtual League League { get; set; }

        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [Display( Name = "Point Total" )]
        [DisplayFormat( DataFormatString = "{0:N}" )]
        public long Points { get; set; }

        [DisplayFormat( DataFormatString = "{0:C}" )]
        public decimal Value { get; set; }

        [Display( Name = "# of Trades" )]
        public int NumberOfTrades { get; set; }




    }
}
