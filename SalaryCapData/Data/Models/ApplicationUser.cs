using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace SalaryCapData.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string LockoutReason { get; set; }
        public int NumberAvailFranchises { get; set; }

        public IEnumerable<Franchise> Franchises { get; set; }
        public IEnumerable<League> Leagues { get; set; }
    }
}
