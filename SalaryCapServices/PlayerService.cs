
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data;
using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaryCapServices
{
    public class PlayerService : IPlayer
    {
        private ApplicationDbContext _context;

        public PlayerService( ApplicationDbContext context )
        {
            _context = context;
        }
        public void Add( Player newPlayer )
        {
            try
            {
                if ( !Exists( newPlayer.Id ) )
                {
                    _context.Add( newPlayer );
                    _context.SaveChanges();
                }
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( "Error Adding Hitter Stat:" + ex );
            }
        }


        public void AddHitterStats( HitterStats stats )
        {
            try
            {
                _context.HitterStats.Add( stats );
                _context.SaveChanges();
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( "Error Adding Hitter Stat:" + ex );
            }
        }

        public void AddPitcherStats( PitcherStats stats )
        {
            try
            {
                _context.PitcherStats.Add( stats );
                _context.SaveChanges();
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( "Error Adding Hitter Stat:" + ex );
            }
        }




        public void AddPlayerPosition( PlayerPosition playerPosition )
        {
            _context.PlayerPositions.Add( playerPosition );
        }

        public bool Exists( int id )
        {
            return _context.Players.Any( e => e.Id == id );
        }

        public Player Get( int PlayerId )
        {
            return (GetAll().FirstOrDefault( p => p.Id == PlayerId ));
        }

        public IEnumerable<Player> GetAll()
        {
            //return ( _context.Players.Include( p => p.Team ).Include( p => p.PlayerPosition )).OrderByDescending( s => s.InitialValue );
            return (_context.Players
                                        .Include( p => p.HitterStats )
                                        .Include( p => p.PitcherStats )
                                        .Include( p => p.Team ))
                                        .OrderByDescending( s => s.InitialValue );

        }


        public IEnumerable<Player> GetAll( int count )
        {
            return (_context.Players
                                       .Include( p => p.HitterStats )
                                        .Include( p => p.PitcherStats )
                                       .Include( p => p.Team ))
                                       .OrderByDescending( s => s.InitialValue ).Take( count );
        }

        public HitterStats GetPlayerHitterStats( int playerId )
        {
            return _context.HitterStats.FirstOrDefault( s => s.Id == playerId );
        }

        public IEnumerable<HitterStats> GetHitterStats()
        {
            return _context.HitterStats.Include( p => p.Player ).Include( t => t.Player.Team );
        }

        public PitcherStats GetPlayerPitcherStats( int playerId )
        {
            return _context.PitcherStats.FirstOrDefault( s => s.Id == playerId );
        }

        public IEnumerable<PitcherStats> GetPitcherStats()
        {
            return _context.PitcherStats
                .Include( p => p.Player )
                .Include( t => t.Player.Team )
                .OrderByDescending( pts => pts.Player.TotalPoints );
        }


        public void Update( Player player )
        {
            _context.Update( player );
            _context.SaveChanges();
        }

        public IEnumerable<HitterStats> GetHitterStats( int count )
        {
            return _context.HitterStats.Include( p => p.Player )
                                .Include( t => t.Player.Team )
                                .OrderByDescending( pts => pts.Player.TotalPoints )
                                .Take( count );
        }

        public IEnumerable<PitcherStats> GetPitcherStats( int count )
        {
            return _context.PitcherStats
                                .Include( p => p.Player )
                                .Include( t => t.Player.Team )
                                .OrderByDescending( pts => pts.Player.TotalPoints )
                                .Take( count );
        }

        public void DraftPlayer( PlayerAssignment player )
        {

            try
            {
                _context.PlayerAssignments.Add( player );
                _context.SaveChanges();
            }
            catch ( Exception e )
            {
                ;
            }
        }

        public IEnumerable<PlayerAssignment> GetFranchisePlayers( int franchiseId )
        {
            return _context.PlayerAssignments
                               .Include( p => p.Player.HitterStats )
                               .Include( p => p.Player.PitcherStats )
                                .Where( p => p.FranchiseId == franchiseId );
        }

        //public IEnumerable<PlayerAssignment> GetFranchisePlayers( int franchiseId )
        //{
        //    return _context.FranchisePlayers.Where( f => f.FranchiseId == franchiseId );
        //}
    }
}
