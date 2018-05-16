using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data;
using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using System.Collections.Generic;
using System.Linq;

namespace SalaryCapServices
{
    public class LeagueService : ILeague
    {
        private ApplicationDbContext _leagues;

        public LeagueService( ApplicationDbContext context )
        {
            _leagues = context;
        }

        public void Add( League newLeague )
        {
            _leagues.Add( newLeague );
            _leagues.SaveChanges();
        }

        public League Get( int id )
        {
            return (GetAll().FirstOrDefault( f => f.Id == id ));
        }

        public IEnumerable<League> GetAll()
        {
            return (_leagues.Leagues
                                .Include( l => l.Franchises )
                                .Include( f => f.Commissioner )).OrderBy( l => l.Name );
        }

        public void AssignFranchiseLeagues( IEnumerable<Franchise> franchises )
        {
            foreach ( Franchise f in franchises )
            {
                f.League = Get( f.LeagueId );
            }
        }
        public string Name( int id )
        {
            return (Get( id ).Name);
        }

        //public Owner Commissioner( int id )
        //{
        //    return ( Get( id ).Commissioner );
        //}

        public ApplicationUser Commissioner( int id )
        {
            return (Get( id ).Commissioner);
        }


        public IEnumerable<Franchise> Franchises( int id )
        {
            return (Get( id ).Franchises);
        }

        public void Update( League league )
        {
            _leagues.Update( league );
            _leagues.SaveChanges();
        }

        public bool Any( int id )
        {
            return Get( id ) != null;
        }

        public void Delete( League league )
        {
            _leagues.Remove( league );
            _leagues.SaveChanges();
        }

        public IEnumerable<League> GetAllByOwnerId( string ownerId )
        {
            return (GetAll().Where( l => l.CommissionerId.Equals( ownerId ) ));
        }
    }
}
