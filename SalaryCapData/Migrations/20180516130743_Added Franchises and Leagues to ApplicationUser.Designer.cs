﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalaryCapData.Data;
using System;

namespace SalaryCapData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180516130743_Added Franchises and Leagues to ApplicationUser")]
    partial class AddedFranchisesandLeaguestoApplicationUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("LockoutReason");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("NumberAvailFranchises");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbbreviatedName")
                        .HasMaxLength(10);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("LeagueId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("NumberOfTrades");

                    b.Property<string>("OwnerId");

                    b.Property<long>("Points");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Franchises");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.HitterStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AtBats");

                    b.Property<float>("Average");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Doubles");

                    b.Property<int>("ExtraBases");

                    b.Property<int>("GamesPlayed");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<bool>("IsCumulative");

                    b.Property<int>("PlayerId");

                    b.Property<int>("RBI");

                    b.Property<int>("Runs");

                    b.Property<int>("Sacrifices");

                    b.Property<int>("StolenBases");

                    b.Property<int>("Strikeouts");

                    b.Property<int>("TotalBases");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("HitterStats");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommissionerId")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsPrivate");

                    b.Property<int>("MaxNumberFranchises");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Points");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CommissionerId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PitcherStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompleteGames");

                    b.Property<DateTime>("Date");

                    b.Property<float>("ERA");

                    b.Property<int>("EarnedRunsAllowed");

                    b.Property<int>("GamesFinished");

                    b.Property<int>("HitsAllowed");

                    b.Property<int>("Holds");

                    b.Property<float>("InningsPitched");

                    b.Property<bool>("IsCumulative");

                    b.Property<int>("Loses");

                    b.Property<int>("PitcherWalks");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Saves");

                    b.Property<int>("Strikeouts");

                    b.Property<float>("WHIP");

                    b.Property<int>("Wins");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("PitcherStats");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.Player", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("InitialValue");

                    b.Property<bool>("IsRookie");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.Property<int>("TeamId");

                    b.Property<int>("TotalPoints");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateDrafted");

                    b.Property<DateTime>("DateDropped");

                    b.Property<int>("FranchiseId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("PlayerPosition");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("PlayerAssignments");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerAssignmentDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatePlayerDrafted");

                    b.Property<DateTime>("DatePlayerDropped");

                    b.HasKey("Id");

                    b.ToTable("PlayerAssignmentDates");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlayerId");

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedCount");

                    b.Property<int>("DroppedCount");

                    b.Property<int>("PlayerId");

                    b.Property<DateTime>("TradeDate");

                    b.HasKey("Id");

                    b.ToTable("PlayerTrades");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Date");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.ToTable("PlayerValues");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.Team", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Abbrev");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.Franchise", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.League", "League")
                        .WithMany("Franchises")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser", "Owner")
                        .WithMany("Franchises")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.HitterStats", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.Player", "Player")
                        .WithOne("HitterStats")
                        .HasForeignKey("SalaryCapData.Data.Models.HitterStats", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.League", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.ApplicationUser", "Commissioner")
                        .WithMany("Leagues")
                        .HasForeignKey("CommissionerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PitcherStats", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.Player", "Player")
                        .WithOne("PitcherStats")
                        .HasForeignKey("SalaryCapData.Data.Models.PitcherStats", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.Player", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalaryCapData.Data.Models.PlayerAssignment", b =>
                {
                    b.HasOne("SalaryCapData.Data.Models.Franchise")
                        .WithMany("Players")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
