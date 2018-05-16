using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SalaryCapData.Data;
using SalaryCapData.Data.Models;
using SalaryCapData.Interfaces;

using SalaryCapServices;
using SalaryCapServices.EmailServices;

namespace SalaryCapGames
{
    public class Startup
    {
        public Startup( IHostingEnvironment env )
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath( env.ContentRootPath )
                .AddJsonFile( "appsettings.json", optional: false, reloadOnChange: true )
                .AddJsonFile( $"appsettings.{env.EnvironmentName}.json", optional: true )
                .AddEnvironmentVariables(); // could add connection strings here.
                                            // here it is.q
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddSingleton( Configuration );
            services.AddScoped<IFranchise, FranchiseService>();

            // services.AddScoped<IOwner, OwnerService>();
            services.AddScoped<ILeague, LeagueService>();
            services.AddScoped<ITeam, TeamService>();
            services.AddScoped<IUser, UserServices>();
            services.AddScoped<IPlayer, PlayerService>();
            services.AddDbContext<ApplicationDbContext>( options =>
                 options.UseSqlServer( Configuration.GetConnectionString( "DefaultConnection" ) ) );

            services.AddIdentity<ApplicationUser, IdentityRole>(
                    options =>
                    {
                        options.Lockout.AllowedForNewUsers = true;
                        options.Lockout.MaxFailedAccessAttempts = 3;
                    } )
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if ( env.IsDevelopment() )
            {
                TelemetryConfiguration.Active.DisableTelemetry = true;
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseStatusCodePages();
                app.UseStaticFiles();
            }
            else
            {
                app.UseExceptionHandler( "/Home/Error" );
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc( routes =>
             {
                 routes.MapRoute(
                     name: "default",
                     template: "{controller=Home}/{action=Index}/{id?}" );
             } );
        }
    }
}
