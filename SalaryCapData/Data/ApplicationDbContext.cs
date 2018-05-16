using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SalaryCapData.Data.Models;

namespace SalaryCapData.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options )
            : base( options )
        {
        }

        public DbSet<League> Leagues { get; set; }
        // public DbSet<Owner> Owners { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAssignment> PlayerAssignments { get; set; }
        public DbSet<PlayerAssignmentDate> PlayerAssignmentDates { get; set; }
        public DbSet<PlayerValue> PlayerValues { get; set; }
        public DbSet<PlayerTransactions> PlayerTrades { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<PitcherStats> PitcherStats { get; set; }
        public DbSet<HitterStats> HitterStats { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating( builder );
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
