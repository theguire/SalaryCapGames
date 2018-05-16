
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using SalaryCapGame.Views.WebViewModels;

using SalaryCapGames.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalaryCapGame.Controllers
{
    [Authorize( Roles = Common.OwnerUser )]
    public class FranchisesController : Controller
    {
        private readonly IFranchise _franchises;
        private readonly ILeague _leagues;
        private readonly UserManager<ApplicationUser> _userManager;

        public FranchisesController( IFranchise franchises, ILeague leagues, UserManager<ApplicationUser> userManager )
        {
            _franchises = franchises;
            _leagues = leagues;
            _userManager = userManager;

        }

        // GET: Franchises
        public IActionResult Index( string ownerId = null )
        {

            string userId = _userManager.GetUserId( User );
            var franchises = from f in _franchises.GetAllByOwnerId( userId ) select f;

            return View( franchises.ToList() );
        }

        public IEnumerable<PlayerAssignment> Players( int id )
        {
            IEnumerable<PlayerAssignment> players = _franchises.Get( id ).Players;

            return players;
        }

        // GET: Franchises/Details/5
        public IActionResult Details( int id )
        {
            if ( id == 0 )
            {
                return NotFound();
            }

            var franchise = _franchises.Get( id );

            if ( franchise == null )
            {
                return NotFound();
            }

            return View( franchise );
        }

        // GET: Franchises/Create
        public IActionResult Create()
        {
            var ownerId = _userManager.GetUserId( User );
            Franchise franchise = new Franchise();
            franchise.OwnerId = ownerId;

            PopulateLegauesDropDownList();
            return View( franchise );
        }

        // POST: Franchises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync( Franchise franchise )
        {
            if ( ModelState.IsValid )
            {
                var ownerId = _userManager.GetUserId( User );
                if ( ownerId == null )
                {
                    throw new ApplicationException( $"Unable to load user with ID '{_userManager.GetUserId( User )}'." );
                }
                franchise.ImageUrl = "";
                franchise.OwnerId = ownerId;
                franchise.Owner = await _userManager.GetUserAsync( User );
                //franchise.LeagueId = selectedLeagueId;
                franchise.League = _leagues.Get( franchise.LeagueId );
                Random rnd = new Random();
                franchise.NumberOfTrades = rnd.Next( 0, 4 );
                franchise.Value = (decimal)rnd.Next( 25, 50 );
                franchise.Points = rnd.Next( 0, 20000 );

                _franchises.Add( franchise );
                return RedirectToAction( nameof( Index ) );
            }

            return View( franchise );
        }

        // GET: Franchises/Edit/5
        public IActionResult Edit( int id )
        {
            if ( id == 0 )
            {
                return NotFound();
            }

            var franchise = _franchises.Get( id );
            if ( franchise == null )
            {
                return NotFound();
            }

            PopulateLegauesDropDownList();
            //ViewData[ "LeagueId" ] = new SelectList( _leagues.GetAll(), "Id", "Name", franchise.LeagueId );
            // ViewData["OwnerId"] = new SelectList(_franchises.Owners, "Id", "Email", franchise.OwnerId);
            return View( franchise );
        }

        // POST: Franchises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( int id, Franchise franchise )
        {
            if ( id != franchise.Id )
            {
                return NotFound();
            }

            if ( ModelState.IsValid )
            {

                try
                {
                    _franchises.Update( franchise );
                }
                catch ( DbUpdateConcurrencyException )
                {
                    if ( !FranchiseExists( franchise.Id ) )
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction( nameof( Index ) );
            }
            ViewData[ "LeagueId" ] = new SelectList( _leagues.GetAll(), "Id", "Name", franchise.LeagueId );
            // ViewData["OwnerId"] = new SelectList(_franchises.Owners, "Id", "Email", franchise.OwnerId);
            return View( franchise );
        }


        private void PopulateLegauesDropDownList( object selectedLeague = null )
        {
            var leagues = from l in _leagues.GetAll() orderby l.Name select l;
            var selectLeagues = leagues.Select( l => new LeagueListingModel
            {
                Id = l.Id,
                NumberOfFranchises = l.Franchises.Count(),
                MaxLeagueSize = 10,
                Commissioner = l.Commissioner,
                CommissionerId = l.CommissionerId,
                Name = l.Name + " " + l.Franchises.Count().ToString() + " / " + "10 "
            } ).ToList();
            ViewData[ "LeagueId" ] = new SelectList( selectLeagues, "Id", "Name", selectedLeague );
        }

        private IEnumerable<LeagueListingModel> BuildLeaguesList( object selectedLeague = null )
        {
            var leagues = from l in _leagues.GetAll() orderby l.Name select l;
            var selectLeagues = leagues.Select( l => new LeagueListingModel
            {
                Id = l.Id,
                NumberOfFranchises = l.Franchises.Count(),
                MaxLeagueSize = 10,
                Commissioner = l.Commissioner,
                CommissionerId = l.CommissionerId,
                Name = l.Name
            } ).ToList();

            return (selectLeagues);

        }


        private bool FranchiseExists( int id )
        {
            return _franchises.Any( id );
        }
        public ActionResult AddPlayerToFranchise( int franchiseId, int playerId, int ownerId )
        {
            var j = franchiseId;
            var k = playerId;

            _franchises.AddPlayer( franchiseId, playerId );
            return RedirectToAction( "Details", "Owners", new { id = ownerId } );
        }

        public IActionResult Dashboard()
        {
            string ownerId = _userManager.GetUserId( User );
            IEnumerable<Franchise> franchises = _franchises.GetAllByOwnerId( ownerId );

            return View( franchises );
        }
    }


}
