using SalaryCapData.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCapData.Interfaces
{
    public interface ILeague
    {
        IEnumerable<League> GetAll();
        League Get( int id );
        IEnumerable<League> GetAllByOwnerId( string ownerId );

        void Add( League newLeague );
        void Update( League league );
        bool Any( int id );

        string Name( int id );

        void Delete( League league );

        ApplicationUser Commissioner( int id );

        void AssignFranchiseLeagues( IEnumerable<Franchise> franchises );

        IEnumerable<Franchise> Franchises( int id );

    }
}
