using Microsoft.AspNetCore.Identity;

namespace SalaryCapData.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string LockoutReason { get; set; }
    }
}
