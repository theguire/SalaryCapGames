using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data;
using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaryCapServices
{
    public class FranchiseService : IFranchise
    {

        private ApplicationDbContext _context;

        public FranchiseService( ApplicationDbContext context )
        {
            _context = context;
        }

        public void Add( Franchise newFranchise )
        {
            _context.Add( newFranchise );
            _context.SaveChanges();
        }

        public Franchise Get( int id )
        {
            return (GetAll().FirstOrDefault( f => f.Id == id ));
        }

        public IEnumerable<Franchise> GetAll()
        {
            return (_context.Franchises.Include( f => f.League )
                                .Include( f => f.League )
                                .Include( f => f.Owner )).OrderBy( f => f.Id );

        }

        public void Update( Franchise franchise )
        {
            _context.Update( franchise );
            _context.SaveChanges();
        }

        public ApplicationUser Owner( int id )
        {
            return (Get( id ).Owner);
        }



        public League League( int id )
        {
            return (Get( id ).League);
        }

        public string Name( int id )
        {
            return (Get( id ).Name);
        }

        public string AbbrevName( int id )
        {
            return (Get( id ).AbbreviatedName);
        }

        public string ImageUrl( int id )
        {
            return (Get( id ).ImageUrl);
        }

        public string OwnerId( int id )
        {
            return Get( id ).OwnerId;
        }

        public int LeagueId( int id )
        {
            return Get( id ).LeagueId;
        }

        public bool Any( int id )
        {
            return Get( id ) != null;
        }

        public long PointTotal( int id )
        {
            return Get( id ).Points;
        }

        public decimal FranchiseValue( int id )
        {
            return Get( id ).Value;
        }

        public int NumberOfTrades( int id )
        {
            return Get( id ).NumberOfTrades;
        }

        public IEnumerable<Franchise> GetAllByOwnerId( string ownerId )
        {
            return (GetAll()
                        .Where( f => f.OwnerId.Equals( ownerId )));
        }

        public IEnumerable<PlayerAssignment> GetPlayers( int id )
        {
            return (Get( id ).Players);
        }

        //public void AddPlayer( int franchiseId, int playerId )
        //{
        //    PlayerAssignment playerAssign = new PlayerAssignment
        //    {
        //        FranchiseId = franchiseId,
        //        PlayerId = playerId,
        //        DateDrafted = DateTime.Now,
        //        PlayerPosition = 
        //    };
        //    try
        //    {
        //        _context.PlayerAssignments.Add( playerAssign );
        //        _context.SaveChanges();
        //    }
        //    catch ( Exception e )
        //    {
        //        ;
        //    }
        //}

        public void Droplayer( int franchiseId, int playerId )
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Player> IFranchise.GetPlayers( int id )
        {
            throw new System.NotImplementedException();
        }


    }
}
