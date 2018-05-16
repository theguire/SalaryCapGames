using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;
using SalaryCapGames.Utilities;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace SalaryCapGames.Controllers
{
    [Authorize( Roles = Common.AdminUser )]
    public class UsersController : Controller
    {

        private readonly IUser _users;

        public UsersController( IUser users )
        {

            _users = users;

        }

        //GET
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst( System.Security.Claims.ClaimTypes.NameIdentifier );
            var claimValue = claim.Value;
            IEnumerable<ApplicationUser> users = _users.GetAllFilteredByClaim( claim.Value );

            return (View( users ));
        }

        //GET
        public IActionResult Edit( string Id )
        {
            var user = _users.Get( Id );
            if ( user == null )
                return NotFound();
            return (View( user ));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( string id, ApplicationUser user )
        {
            if ( !id.Equals( user.Id ) )
            {
                return NotFound();
            }

            if ( ModelState.IsValid )
            {

                try
                {
                    _users.UpdateAsync( user );
                }
                catch ( DbUpdateConcurrencyException )
                {
                    if ( !UserExists( id ) )
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
            return View( user );

        }



        //GET
        public IActionResult Lock( string Id )
        {
            var user = _users.Get( Id );
            if ( user == null )
                return NotFound();
            user.LockoutEnd = DateTime.Now.AddYears( 100 );
            return (View( user ));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Lock( string id, ApplicationUser user )
        {
            if ( !id.Equals( user.Id ) )
            {
                return NotFound();
            }

            if ( ModelState.IsValid )
            {

                try
                {

                    _users.UpdateAsync( user );
                }
                catch ( DbUpdateConcurrencyException )
                {
                    if ( !UserExists( id ) )
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
            return View( user );

        }

        private bool UserExists( string id )
        {
            return _users.Any( id );
        }
    }
}
