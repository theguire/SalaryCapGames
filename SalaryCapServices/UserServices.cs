using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCapServices
{
    public class UserServices : IUser
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserServices( UserManager<ApplicationUser> userManager )
        {
            _userManager = userManager;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _userManager.Users;

        }

        public ApplicationUser Get( string id )
        {
            return (GetAll().FirstOrDefault( f => f.Id.Equals( id ) ));
        }

        public async Task UpdateAsync( ApplicationUser user )
        {
            await _userManager.UpdateAsync( user );
        }

        public bool Any( string id )
        {
            return Get( id ) != null;
        }

        public IEnumerable<ApplicationUser> GetAllFilteredByClaim( string claimIdentity )
        {
           return GetAll().Where( u => u.Id != claimIdentity );
        }
    }
}
