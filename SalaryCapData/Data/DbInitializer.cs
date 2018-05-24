﻿//using Microsoft.AspNetCore.Identity;
//using SalaryCapGame.
//using SalaryCapData.Data;
//using SalaryCapData.Data.Models;

//using System.Linq;

//namespace SalaryCapData
//{
//    public static class DbInitializer
//    {
//        public static void Initialize( ApplicationDbContext context, UserManager<ApplicationUser> userManager )
//        {

//            //if ( context.Owners.Any() )
//            //{
//            //    return;
//            //}
//            System.Diagnostics.Debug.WriteLine( "Seeding the data models.  Please wait..." );

//            System.Diagnostics.Debug.WriteLine( "1 of 3" );
//            //var owners = OwnersSeed( context );
//            var owners = RegisterSomeUsers( context );
//            System.Diagnostics.Debug.Write( "\r2 of 3" );
//            var leagues = LeagueSeed( context, owners );
//            System.Diagnostics.Debug.Write( "\r3 of 3" );
//            var franchises = FranchiseSeed( context, owners, leagues );
//            System.Diagnostics.Debug.Write( "\rDone...." );

//        }



//        private static RegisterViewModel[] RegisterSomeUsers( ApplicationDbContext context, UserManager<ApplicationUser> userManager )
//        {

//        }
//        private static Owner[] OwnersSeed( ApplicationDbContext context, UserManager<ApplicationUser> userManager )
//        {
//            Owner[] owners = new Owner[ 6 ];

//            for ( int i = 0; i < owners.Length; i++ )
//            {
//                var user = new ApplicationUser
//                {
//                    UserName = "dumbo" + i + "@gmail.com",
//                    Email = "dumbo" + i + "@gmail.com",
//                };
//                var result = userManager.CreateAsync( user, "N0str0m0!" );
//                owners.Append(

//                    new Owner
//                    {
//                        AppUserId = user.Id,
//                        Franchises = null,
//                        Leagues = null,
//                        ImageUrl = ""
//                    } );
//            }

//            foreach ( Owner o in owners )
//            {
//                context.Owners.Add( o );
//            }
//            context.SaveChanges();

//            return (owners);
//        }

//        private static League[] LeagueSeed( ApplicationDbContext context, Owner[] owners, UserManager<ApplicationUser> userManager )
//        {
//            League[] leagues = new League[ 6 ];
//            for ( int i = 0; i < leagues.Length; i++ )
//            {
//                var email = await userManager.GetEmailAsync( owners[ i ].AppUserId ).;
//                new League
//                {
//                    Name = "Fun League",
//                    CommissionerId = owners.First(),
//                    MaxNumberFranchises = 10,
//                    IsPrivate = false,
//                },
//                new League
//                {
//                    Name = "Dopy League",
//                    CommissionerId = owners.Single( o => o.LastName == "Jumbo" ).Id,
//                    MaxNumberFranchises = 20,
//                    IsPrivate = false,
//                },
//                new League
//                {
//                    Name = "Goofy League",
//                    CommissionerId = owners.Single( o => o.LastName == "Wingie" ).Id,
//                    MaxNumberFranchises = 15,
//                    IsPrivate = false,
//                },
//                new League
//                {
//                    Name = "Sleepy League",
//                    CommissionerId = owners.Single( o => o.LastName == "Jenkins" ).Id,
//                    MaxNumberFranchises = 10,
//                    IsPrivate = true,
//                },
//                new League
//                {
//                    Name = "Sneezy League",
//                    CommissionerId = owners.Single( o => o.LastName == "Jenkins" ).Id,
//                    MaxNumberFranchises = 15,
//                    IsPrivate = false,
//                },
//                new League
//                {
//                    Name = "Stupid League",
//                    CommissionerId = owners.Single( o => o.LastName == "Wingie" ).Id,
//                    MaxNumberFranchises = 12,
//                    IsPrivate = false,
//                },
//            };

//            foreach ( League l in leagues )
//            {
//                context.Leagues.Add( l );
//            }
//            context.SaveChanges();

//            return leagues;
//        }

//        private static Franchise[] FranchiseSeed( ApplicationDbContext context, Owner[] owners, League[] leagues )
//        {
//            var franchises = new Franchise[]
//            {
//                new Franchise
//                {
//                    Name = "Franchise Wingie One",
//                    ImageUrl = "images/b5.png",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Wingie" ).Id,
//                    Points = 10201,
//                    Value = 75911,
//                    NumberOfTrades = 1
//                },
//                new Franchise
//                {
//                    Name = "Franchise Wingie Two",
//                    ImageUrl = "images/pi-1.jpg",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Wingie" ).Id,
//                    Points = 7201,
//                    Value = 76000,
//                    NumberOfTrades = 9
//                },
//                new Franchise
//                {
//                    Name = "Franchise Wingie Three",
//                    ImageUrl = "images/t.png",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Wingie" ).Id,
//                    Points = 15350,
//                    Value = 70900,
//                    NumberOfTrades = 2
//                },
//                new Franchise
//                {
//                    Name = "Franchise Jumbo One",
//                    ImageUrl = "images/theta4.png",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Jumbo" ).Id,
//                    Points = 11000,
//                    Value = 76770,
//                    NumberOfTrades= 6
//                },
//                new Franchise
//                {
//                    Name = "Franchise Dippy One",
//                    ImageUrl = "images/tt.png",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Dippy" ).Id,
//                    Points = 60321,
//                    Value = 55550,
//                    NumberOfTrades = 0
//                },
//                new Franchise
//                {
//                    Name = "Franchise Jenkins One",
//                    ImageUrl = "images/theta-3.png",
//                    LeagueId = leagues.Single( l => l.Name == "Sneezy League" ).Id,
//                    OwnerId = owners.Single( o => o.LastName == "Jenkins" ).Id,
//                    Points = 9000,
//                    Value = 78200,
//                    NumberOfTrades = 4
//                },
//            };
//            foreach ( Franchise f in franchises )
//            {
//                context.Add( f );
//            }
//            context.SaveChanges();

//            return franchises;
//        }
//    }
//}
