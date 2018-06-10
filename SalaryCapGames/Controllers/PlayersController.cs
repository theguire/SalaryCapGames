using Microsoft.AspNetCore.Mvc;

using SalaryCapData.Data.Models;

using SalaryCapData.Interfaces;

using SalaryCapGame.Views.WebViewModels.DashboardIndexViewModel;

using System;
using System.Linq;

namespace SalaryCapGame.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayer _players;
        private readonly ITeam _teams;

        public PlayersController( IPlayer players, ITeam teams )
        {
            _players = players;
            _teams = teams;
        }

        //public IActionResult Index()
        //{
        //    var players = _players.GetAll();
        //    var results = players.Select( p => new PlayerIndexListingModel
        //    {
        //        PlayerId = p.Id,
        //        FirstName = p.FirstName,
        //        LastName = p.LastName,
        //        Position = p.Position,
        //        Team = p.Team,
        //        Value = p.InitialValue


        //    } ).ToList();

        //    var model = new PlayerIndexModel { Players = results };

        //    return View( model );
        //}

        public IActionResult ViewPitchers()
        {
            var model = new DashboardIndexViewModel
            {
                FranchiseModel = null,
                PitcherFreeAgents = _players.GetPitcherStats().ToList(),
                SelectedFranchiseId = 1

            };

            return View( model );
        }

        public IActionResult ViewHitters()
        {

            var model = new DashboardIndexViewModel
            {
                FranchiseModel = null,
                HittingFreeAgents = _players.GetHitterStats().ToList(),
                SelectedFranchiseId = 1

            };

            return View( model );
        }

        public IActionResult ViewMyHitters( int franchiseId )
        {
            var players = _players.GetHitterStats( franchiseId ).ToList();
            return View( players );
        }

        //        private StatsIndexListModel GetAllStats()
        //        {

        //            IEnumerable<HitterStats> hitterStats = _players.GetHitterStats( 25 );
        //            IEnumerable<PitcherStats> pitcherStats = _players.GetPitcherStats( 25 );

        //            StatsIndexListModel statsModel = new StatsIndexListModel
        //            {
        //                HitterStats = hitterStats,
        //                PitcherStats = pitcherStats
        //            };

        //            return (statsModel);
        //        }

        //        //List<PlayerIndexListingModel> playersModel = GetPlayersIndexListingModel( id );
        //        StatsIndexListModel statsIndexListModel = GetAllStats();
        //        			foreach (var p in statsIndexListModel.HitterStats )
        //        			{
        //        				p.Player.TotalPoints = p.Player.GetHitterPoints();
        //        			}

        //        			foreach (var p in statsIndexListModel.PitcherStats )
        //        			{
        //        				p.Player.TotalPoints = p.Player.GetPitcherPoints();
        //        			}
        //        			// var playerModel = new PlayerIndexModel { Players = playersModel };
        //        			//var dashboardModel = new DashboardViewModel
        //        			//{
        //        			//	OwnerIndex = ownerModel,
        //        			//	PlayerStats = statsIndexListModel,
        //        			//};

        //        			return View( "List" );
        //        			//return View( "List", dashboardModel );
        //        		}

        //        		private StatsIndexListModel GetAllStats()
        //{

        //    IEnumerable<HitterStats> hitterStats = _players.GetHitterStats( 25 );
        //    IEnumerable<PitcherStats> pitcherStats = _players.GetPitcherStats( 25 );

        //    StatsIndexListModel statsModel = new StatsIndexListModel
        //    {
        //        HitterStats = hitterStats,
        //        PitcherStats = pitcherStats
        //    };

        //    return (statsModel);
        //}

        public IActionResult AddHitter( int franchiseId, int playerId )
        {
            AddPlayer( franchiseId, playerId );
            return RedirectToAction( "ViewHitters", "Players" );
        }

        public IActionResult AddPitcher( int franchiseId, int playerId )
        {
            AddPlayer( franchiseId, playerId );
            return RedirectToAction( "ViewPitchers", "Players" );
        }

        private void AddPlayer( int franchiseId, int playerId )
        {

            var player = _players.Get( playerId );
            if ( player != null )
            {

                PlayerAssignment playerAssign = new PlayerAssignment
                {
                    FranchiseId = franchiseId,
                    PlayerId = playerId,

                    DateDrafted = DateTime.Now,
                    PlayerPosition = player.Position,
                };

                _players.DraftPlayer( playerAssign );
            }


            // return RedirectToAction( "Details", "Owners", new { id = ownerId } );
        }

    }
}
