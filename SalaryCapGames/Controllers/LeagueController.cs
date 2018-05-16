using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using SalaryCapGame.Views.WebViewModels;

using SalaryCapGames.Utilities;
using SalaryCapGames.Views.WebViewModels.League;

using System.Linq;

namespace SalaryCapGame.Controllers
{

    [Authorize( Roles = Common.OwnerUser )]
    public class LeagueController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger( System.Reflection.MethodBase.GetCurrentMethod().DeclaringType );
        private readonly ILeague _leagues;
        private readonly UserManager<ApplicationUser> _userManager;

        public LeagueController( ILeague leagues, UserManager<ApplicationUser> userManager )
        {
            _leagues = leagues;
            _userManager = userManager;
        }


        //Get
        public IActionResult Index()
        {
            string userId = _userManager.GetUserId( User );
            var leagues = from l in _leagues.GetAllByOwnerId( userId ) select l;

            return View( leagues.ToList() );
        }

        //GET
        public IActionResult Create()
        {
            var leagueView = new LeagueViewModel();

            return View( leagueView );
        }

        //GET
        public IActionResult Edit( int id )
        {
            if ( id == 0 )
            {
                return NotFound();
            }

            var league = _leagues.Get( id );
            if ( league == null )
            {
                return NotFound();
            }

            return View( league );
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( LeagueViewModel league, string returnUrl = null )
        {
            ViewData[ "ReturnUrl" ] = returnUrl;

            if ( ModelState.IsValid )
            {
                var newLeague = new League
                {
                    Name = league.Name,
                    MaxNumberFranchises = league.MaxSize,
                    IsPrivate = league.IsPrivate,
                    CommissionerId = _userManager.GetUserId( User ),
                    Points = 0,
                    Value = 0
                };
                //league.CommissionerId = _owners.GetOwnerId( Convert.ToInt32( _userManager.GetUserId( User ) ) );

                _leagues.Add( newLeague );
                if ( returnUrl != null )
                    Redirect( returnUrl );
                else
                    return RedirectToAction( nameof( Index ) );


            }

            return View( league );
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( int id, League league )
        {
            if ( id != league.Id )
                return NotFound();

            if ( ModelState.IsValid )
            {


                try
                {
                    _leagues.Update( league );
                }
                catch ( DbUpdateConcurrencyException )
                {
                    if ( !LeagueExists( league.Id ) )
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            return RedirectToAction( nameof( Index ) );
        }

        //GET
        public IActionResult Delete( int id )
        {
            if ( id == 0 )
                return NotFound();

            var league = _leagues.Get( id );
            if ( league == null )
                return NotFound();
            return View( league );

        }

        //POST
        [HttpPost, ActionName( "Delete" )]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed( int id )
        {
            var league = _leagues.Get( id );
            foreach ( var item in league.Franchises )
            {
                item.League = null;
                item.LeagueId = 0;
            }
            _leagues.Delete( league );
            return RedirectToAction( nameof( Index ) );
        }

        private bool LeagueExists( int id )
        {
            return _leagues.Any( id );
        }
        //GET
        public IActionResult Details( int id )
        {
            var leagueModel = _leagues.Get( id );

            return View( leagueModel );
        }

        public IActionResult Summary( int id )
        {
            var leagueModel = _leagues.Get( id );
            var listingResult = new LeagueListingModel()
            {
                Id = leagueModel.Id,
                Name = leagueModel.Name,
                Commissioner = leagueModel.Commissioner

            };

            return View( leagueModel );
        }

    }
}
