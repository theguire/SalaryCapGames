

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalaryCapData.Data.Models
{
    public class League
    {
        public int Id { get; set; }

        [Required]
        [StringLength( 50, MinimumLength = 5,
                    ErrorMessage = "League name must be between 5 - 50 characters." )]
        [RegularExpression( @"^[A-Za-z0-9-]*$" )]
        public string Name { get; set; }

        [Required]
        public string CommissionerId { get; set; }
        public ApplicationUser Commissioner { get; set; }

        //public int CommissionerId { get; set; }
        //public Owner Commissioner { get; set; }

        //public int AppUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }


        [Display( Name = "League Size" )]
        [Range( 6, 20 )]
        public int MaxNumberFranchises { get; set; }
        public bool IsPrivate { get; set; }

        public int Points { get; set; }
        public decimal Value { get; set; }


        public virtual IEnumerable<Franchise> Franchises { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
