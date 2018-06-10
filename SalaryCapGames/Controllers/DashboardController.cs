using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using SalaryCapGame.Views.WebViewModels;
using SalaryCapGame.Views.WebViewModels.DashboardIndexViewModel;
using SalaryCapGame.Views.WebViewModels.Franchise;

using System.Linq;

namespace SalaryCapGames.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IFranchise _franchises;
        private readonly IPlayer _players;
        private readonly ILeague _leagues;
        private readonly UserManager<ApplicationUser> _userManager;

        public DashboardController( IFranchise franchises, IPlayer player, ILeague leagues, UserManager<ApplicationUser> userManager )
        {
            _franchises = franchises;
            _leagues = leagues;
            _userManager = userManager;
            _players = player;

        }

        //GET
        //public IActionResult DashboardFranchiseIndex()
        //{
        //    string userId = _userManager.GetUserId( User );
        //    var franchises = from f in _franchises.GetAllByOwnerId( userId ) select f;
        //    var franchiseModelList = franchises.Select( f => new FranchiseIndexListingModel
        //    {
        //        Id = f.Id,
        //        Nickname = f.AbbreviatedName,
        //        Points = f.Points,
        //        Value = f.Value,
        //        NumberOfTrades = f.NumberOfTrades,
        //        League = f.League,


        //    } ).ToList();
        //    //var model = new FranchiseIndexModel()
        //    //{ Franchises = franchiseModelList };

        //    return View( franchiseModelList );
        //}

        public IActionResult Index( int id )
        {
            string userId = _userManager.GetUserId( User );
            var franchises = from f in _franchises.GetAllByOwnerId( userId ) select f;
            var franchiseModelList = franchises.Select( f => new FranchiseIndexListingModel
            {
                Id = f.Id,
                Nickname = f.AbbreviatedName,
                Points = f.Points,
                Value = f.Value,
                NumberOfTrades = f.NumberOfTrades,
                League = f.League,


            } ).ToList();



            var franchiseModel = new FranchiseIndexModel()
            { Franchises = franchiseModelList };


            if ( id != 0 )
            {
                ViewBag.FranchiseId = id;
                var playerAssignments = from pa in _players.GetFranchisePlayers( id ) select pa;
                var playersList = playerAssignments.Select( pa => new Player
                {
                    Age = pa.Player.Age,
                    FirstName = pa.Player.FirstName,
                    LastName = pa.Player.LastName,
                    HitterStats = pa.Player.HitterStats,
                    PitcherStats = pa.Player.PitcherStats,
                    Position = pa.PlayerPosition,
                    Team = pa.Player.Team,

                } ).ToList();
                franchiseModel.FranchisePlayers = playersList.ToList();
            }
            else
                franchiseModel.FranchisePlayers = null;


            var hitters = _players.GetHitterStats();
            var pitchers = _players.GetPitcherStats();
            var model = new DashboardIndexViewModel
            {
                FranchiseModel = franchiseModel,
                HittingFreeAgents = hitters,
                PitcherFreeAgents = pitchers,
                SelectedFranchiseId = franchiseModel.Franchises.First().Id

            };
            //var players = _players.GetAll();
            //var model = new DashboardIndexViewModel
            //{
            //    FranchiseModel = franchiseModel,
            //    Players = players.ToList()
            //};
            return View( model );
        }

        //public IActionResult _DashboardMyTeamTabsPartial( int franchiseId )
        //{
        //    var franchisePlayers = _players.GetFranchisePlayers( franchiseId );
        //    return View( franchisePlayers );
        //}

    }
}