﻿using Newtonsoft.Json;

using SalaryCapData.ConsumeJson.Models.PlayerStats;
using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using System;
using System.IO;

namespace SalaryCapData.ConsumeJson.Models.Cumulative
{
    public class CumulativePlayerStats
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger( System.Reflection.MethodBase.GetCurrentMethod().DeclaringType );
        public void ReadJsonDeserialize( string fileName, IPlayer _context, DateTime date )
        {

            if ( !File.Exists( fileName ) )
                return;
            int i = 0;
            int j = 0;
            Random rnd = new Random();
            SaveStats playerStats = new SaveStats();
            try
            {
                Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>( File.ReadAllText( fileName ) );
                foreach ( var p in rootObject.cumulativeplayerstats.playerstatsentry )
                {
                    System.Diagnostics.Debug.Write( "#: " + i++ + " Id: " + p.player.ID + " " + p.player.LastName );
                    //First check to see if the player is in the Player table
                    SalaryCapData.Data.Models.Player player = _context.Get( Convert.ToInt32( p.player.ID ) );
                    if ( player == null )
                        continue;


                    player.TotalPoints = rnd.Next( 15, 3000 );
                    System.Diagnostics.Debug.Write( " " + j++ + " Saved " );
                    if ( p.player.Position == "P" )
                    {
                        BuildPitcherStatModel( Convert.ToInt32( p.player.ID ), p.stats, _context, date );
                    }
                    else
                    {
                        BuildHitterMStatModel( Convert.ToInt32( p.player.ID ), p.stats, _context, date );
                    }

                    System.Diagnostics.Debug.WriteLine( "\n" );
                }
            }
            catch ( Exception ex )
            {
                string errorMessage = string.Format( "Error saving player stats: " + ex );
                System.Diagnostics.Debug.WriteLine( errorMessage );
                log.Info( errorMessage );
            }
            System.Diagnostics.Debug.WriteLine( i + " Cumulative Records Read.  " + j + " Saved.  Delta: " + (i - j) );
        }


        public void BuildPitcherStatModel( int id, Stats stats, IPlayer _context, DateTime date )
        {
            try
            {

                PitcherStats playerStats = new PitcherStats
                {
                    PlayerId = id,
                    EarnedRunsAllowed = Convert.ToInt32( stats.EarnedRunsAllowed.text ),
                    HitsAllowed = Convert.ToInt32( stats.HitsAllowed.text ),
                    CompleteGames = Convert.ToInt32( stats.CompletedGames.text ),
                    Holds = Convert.ToInt32( stats.Holds.text ),
                    InningsPitched = (float)Convert.ToDouble( stats.InningsPitched.text ),
                    Loses = Convert.ToInt32( stats.Losses.text ),
                    Saves = Convert.ToInt32( stats.Saves.text ),
                    PitcherWalks = Convert.ToInt32( stats.PitcherWalks.text ),
                    Wins = Convert.ToInt32( stats.Wins.text ),
                    Strikeouts = Convert.ToInt32( stats.PitcherStrikeouts.text ),
                    GamesFinished = Convert.ToInt32( stats.GamesFinished.text ),
                    WHIP = (float)Convert.ToDouble( stats.WalksAndHitsPerInningPitched.text ),
                    ERA = (float)Convert.ToDouble( stats.EarnedRunAvg.text ),

                    IsCumulative = true,
                    Date = DateTime.Today
                };
                _context.AddPitcherStats( playerStats );
            }
            catch ( Exception ex )
            {
                string errorMessage = string.Format( "Error saving player stats: " + ex );
                System.Diagnostics.Debug.WriteLine( errorMessage );
                log.Info( errorMessage );
            }


        }


        public void BuildHitterMStatModel( int id, Stats stats, IPlayer _context, DateTime date )
        {
            HitterStats playerStats = new HitterStats
            {
                PlayerId = id,
                GamesPlayed = Convert.ToInt32( stats.GamesPlayed.text ),
                AtBats = Convert.ToInt32( stats.AtBats.text ),
                Doubles = Convert.ToInt32( stats.SecondBaseHits.text ),
                ExtraBases = Convert.ToInt32( stats.ExtraBaseHits.text ),
                Hits = Convert.ToInt32( stats.Hits.text ),
                HomeRuns = Convert.ToInt32( stats.Homeruns.text ),
                RBI = Convert.ToInt32( stats.RunsBattedIn.text ),
                Runs = Convert.ToInt32( stats.Runs.text ),
                Sacrifices = Convert.ToInt32( stats.BatterSacrificeBunts.text )
                                + Convert.ToInt32( stats.BatterSacrificeFlies.text ),
                TotalBases = Convert.ToInt32( stats.TotalBases.text ),
                StolenBases = Convert.ToInt32( stats.StolenBases.text ),
                Triples = Convert.ToInt32( stats.ThirdBaseHits.text ),
                Walks = Convert.ToInt32( stats.BatterWalks.text ),
                Strikeouts = Convert.ToInt32( stats.BatterWalks.text ),
                Average = (float)Convert.ToDouble( stats.BattingAvg.text ),
                IsCumulative = true,
                Date = DateTime.Today
            };

            _context.AddHitterStats( playerStats );

        }

    }

}
