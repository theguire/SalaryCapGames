using SalaryCapData.Data.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCapData.Interfaces
{
    public interface IUser
    {
        IEnumerable<ApplicationUser> GetAll();
        IEnumerable<ApplicationUser> GetAllFilteredByClaim( string claimIdentity );
        ApplicationUser Get( string Id );
        


        Task UpdateAsync( ApplicationUser user );

        bool Any( string id );
    }
}
