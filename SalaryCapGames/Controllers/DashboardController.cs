using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using SalaryCapGame.Views.WebViewModels;

using System.Linq;

namespace SalaryCapGames.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IFranchise _franchises;
        private readonly ILeague _leagues;
        private readonly UserManager<ApplicationUser> _userManager;

        public DashboardController( IFranchise franchises, ILeague leagues, UserManager<ApplicationUser> userManager )
        {
            _franchises = franchises;
            _leagues = leagues;
            _userManager = userManager;

        }

        //GET
        public IActionResult DashboardFranchiseIndex()
        {
            string userId = _userManager.GetUserId( User );  
            var franchises = from f in _franchises.GetAllByOwnerId( userId ) select f;
            var franchiseModelList = franchises.Select( f => new FranchiseIndexListingModel
            {
                Nickname = f.AbbreviatedName,
                Points = f.Points,
                Value = f.Value,
                NumberOfTrades = f.NumberOfTrades,
                League = f.League,


            } ).ToList();
            //var model = new FranchiseIndexModel()
            //{ Franchises = franchiseModelList };

            return View( franchiseModelList );
        }

    }
}