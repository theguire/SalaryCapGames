using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using SalaryCapData;
using SalaryCapData.Data;

using SalaryCapServices;

using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace SalaryCapGames
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    BuildWebHost(args).Run();
        //}

        //public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .Build();
        public static void Main( string[] args )
        {
            XmlDocument log4netConfig = new XmlDocument();

            log4netConfig.Load( File.OpenRead( "log4net.config" ) );
            var repo = log4net.LogManager.CreateRepository( Assembly.GetEntryAssembly(), typeof( log4net.Repository.Hierarchy.Hierarchy ) );
            log4net.Config.XmlConfigurator.Configure( repo, log4netConfig[ "log4net" ] );

            var host = BuildWebHost( args );
            using ( var scope = host.Services.CreateScope() )
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    DbInitializer.Initialize( context );
                    JsonService jsonService = new JsonService( context );
                    jsonService.UpdatePlayerRoster();
                    jsonService.UpdateDailyStats();
                    jsonService.LoadCumulativePlayerStats();

                }
                catch ( Exception ex )
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError( ex, "An error occurred seeding the DB." );
                }
                host.Run();
            }



        }

        public static IWebHost BuildWebHost( string[] args )
        {
            return (new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot( Directory.GetCurrentDirectory() )
                        .UseIISIntegration()
                        .UseStartup<Startup>()
                        .UseDefaultServiceProvider( options => options.ValidateScopes = false )
                        .UseApplicationInsights()
                        .Build());
        }
    }
}
