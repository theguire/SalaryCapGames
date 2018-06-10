﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

using System;

namespace SalaryCapData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>( nullable: false ),
                    ConcurrencyStamp = table.Column<string>( nullable: true ),
                    Name = table.Column<string>( maxLength: 256, nullable: true ),
                    NormalizedName = table.Column<string>( maxLength: 256, nullable: true )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetRoles", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>( nullable: false ),
                    AccessFailedCount = table.Column<int>( nullable: false ),
                    ConcurrencyStamp = table.Column<string>( nullable: true ),
                    Email = table.Column<string>( maxLength: 256, nullable: true ),
                    EmailConfirmed = table.Column<bool>( nullable: false ),
                    LockoutEnabled = table.Column<bool>( nullable: false ),
                    LockoutEnd = table.Column<DateTimeOffset>( nullable: true ),
                    NormalizedEmail = table.Column<string>( maxLength: 256, nullable: true ),
                    NormalizedUserName = table.Column<string>( maxLength: 256, nullable: true ),
                    PasswordHash = table.Column<string>( nullable: true ),
                    PhoneNumber = table.Column<string>( nullable: true ),
                    PhoneNumberConfirmed = table.Column<bool>( nullable: false ),
                    SecurityStamp = table.Column<string>( nullable: true ),
                    TwoFactorEnabled = table.Column<bool>( nullable: false ),
                    UserName = table.Column<string>( maxLength: 256, nullable: true )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetUsers", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "PlayerAssignmentDates",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    DatePlayerDrafted = table.Column<DateTime>( nullable: false ),
                    DatePlayerDropped = table.Column<DateTime>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PlayerAssignmentDates", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "PlayerPositions",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    PlayerId = table.Column<int>( nullable: false ),
                    Position = table.Column<string>( nullable: true )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PlayerPositions", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "PlayerTrades",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    AddedCount = table.Column<int>( nullable: false ),
                    DroppedCount = table.Column<int>( nullable: false ),
                    PlayerId = table.Column<int>( nullable: false ),
                    TradeDate = table.Column<DateTime>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PlayerTrades", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "PlayerValues",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    Date = table.Column<int>( nullable: false ),
                    PlayerId = table.Column<int>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PlayerValues", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false ),
                    Abbrev = table.Column<string>( nullable: true ),
                    City = table.Column<string>( nullable: true ),
                    Name = table.Column<string>( nullable: true )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Teams", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    ClaimType = table.Column<string>( nullable: true ),
                    ClaimValue = table.Column<string>( nullable: true ),
                    RoleId = table.Column<string>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetRoleClaims", x => x.Id );
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    ClaimType = table.Column<string>( nullable: true ),
                    ClaimValue = table.Column<string>( nullable: true ),
                    UserId = table.Column<string>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetUserClaims", x => x.Id );
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>( nullable: false ),
                    ProviderKey = table.Column<string>( nullable: false ),
                    ProviderDisplayName = table.Column<string>( nullable: true ),
                    UserId = table.Column<string>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey } );
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>( nullable: false ),
                    RoleId = table.Column<string>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetUserRoles", x => new { x.UserId, x.RoleId } );
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>( nullable: false ),
                    LoginProvider = table.Column<string>( nullable: false ),
                    Name = table.Column<string>( nullable: false ),
                    Value = table.Column<string>( nullable: true )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name } );
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    CommissionerId = table.Column<string>( nullable: false ),
                    DateCreated = table.Column<DateTime>( nullable: false ),
                    DateModified = table.Column<DateTime>( nullable: false ),
                    IsPrivate = table.Column<bool>( nullable: false ),
                    MaxNumberFranchises = table.Column<int>( nullable: false ),
                    Name = table.Column<string>( maxLength: 50, nullable: false ),
                    Points = table.Column<int>( nullable: false ),
                    Value = table.Column<decimal>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Leagues", x => x.Id );
                    table.ForeignKey(
                        name: "FK_Leagues_AspNetUsers_CommissionerId",
                        column: x => x.CommissionerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false ),
                    Age = table.Column<int>( nullable: false ),
                    FirstName = table.Column<string>( nullable: true ),
                    InitialValue = table.Column<decimal>( nullable: false ),
                    IsRookie = table.Column<bool>( nullable: false ),
                    LastName = table.Column<string>( nullable: true ),
                    Position = table.Column<string>( nullable: true ),
                    TeamId = table.Column<int>( nullable: false ),
                    TotalPoints = table.Column<int>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Players", x => x.Id );
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Franchises",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    AbbreviatedName = table.Column<string>( maxLength: 10, nullable: true ),
                    DateCreated = table.Column<DateTime>( nullable: false ),
                    DateModified = table.Column<DateTime>( nullable: false ),
                    ImageUrl = table.Column<string>( nullable: true ),
                    LeagueId = table.Column<int>( nullable: false ),
                    Name = table.Column<string>( maxLength: 50, nullable: false ),
                    NumberOfTrades = table.Column<int>( nullable: false ),
                    OwnerId = table.Column<string>( nullable: true ),
                    Points = table.Column<long>( nullable: false ),
                    Value = table.Column<decimal>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Franchises", x => x.Id );
                    table.ForeignKey(
                        name: "FK_Franchises_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                    table.ForeignKey(
                        name: "FK_Franchises_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict );
                } );

            migrationBuilder.CreateTable(
                name: "HitterStats",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    AtBats = table.Column<int>( nullable: false ),
                    Average = table.Column<float>( nullable: false ),
                    Date = table.Column<DateTime>( nullable: false ),
                    Doubles = table.Column<int>( nullable: false ),
                    ExtraBases = table.Column<int>( nullable: false ),
                    GamesPlayed = table.Column<int>( nullable: false ),
                    Hits = table.Column<int>( nullable: false ),
                    HomeRuns = table.Column<int>( nullable: false ),
                    IsCumulative = table.Column<bool>( nullable: false ),
                    PlayerId = table.Column<int>( nullable: false ),
                    RBI = table.Column<int>( nullable: false ),
                    Runs = table.Column<int>( nullable: false ),
                    Sacrifices = table.Column<int>( nullable: false ),
                    StolenBases = table.Column<int>( nullable: false ),
                    Strikeouts = table.Column<int>( nullable: false ),
                    TotalBases = table.Column<int>( nullable: false ),
                    Triples = table.Column<int>( nullable: false ),
                    Walks = table.Column<int>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_HitterStats", x => x.Id );
                    table.ForeignKey(
                        name: "FK_HitterStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "PitcherStats",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    CompleteGames = table.Column<int>( nullable: false ),
                    Date = table.Column<DateTime>( nullable: false ),
                    ERA = table.Column<float>( nullable: false ),
                    EarnedRunsAllowed = table.Column<int>( nullable: false ),
                    GamesFinished = table.Column<int>( nullable: false ),
                    HitsAllowed = table.Column<int>( nullable: false ),
                    Holds = table.Column<int>( nullable: false ),
                    InningsPitched = table.Column<float>( nullable: false ),
                    IsCumulative = table.Column<bool>( nullable: false ),
                    Loses = table.Column<int>( nullable: false ),
                    PitcherWalks = table.Column<int>( nullable: false ),
                    PlayerId = table.Column<int>( nullable: false ),
                    Saves = table.Column<int>( nullable: false ),
                    Strikeouts = table.Column<int>( nullable: false ),
                    WHIP = table.Column<float>( nullable: false ),
                    Wins = table.Column<int>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PitcherStats", x => x.Id );
                    table.ForeignKey(
                        name: "FK_PitcherStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "PlayerAssignments",
                columns: table => new
                {
                    Id = table.Column<int>( nullable: false )
                        .Annotation( "SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn ),
                    DateDrafted = table.Column<DateTime>( nullable: false ),
                    DateDropped = table.Column<DateTime>( nullable: false ),
                    FranchiseId = table.Column<int>( nullable: false ),
                    PlayerId = table.Column<int>( nullable: false ),
                    PlayerPosition = table.Column<int>( nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_PlayerAssignments", x => x.Id );
                    table.ForeignKey(
                        name: "FK_PlayerAssignments_Franchises_FranchiseId",
                        column: x => x.FranchiseId,
                        principalTable: "Franchises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId" );

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL" );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId" );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId" );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId" );

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail" );

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL" );

            migrationBuilder.CreateIndex(
                name: "IX_Franchises_LeagueId",
                table: "Franchises",
                column: "LeagueId" );

            migrationBuilder.CreateIndex(
                name: "IX_Franchises_OwnerId",
                table: "Franchises",
                column: "OwnerId" );

            migrationBuilder.CreateIndex(
                name: "IX_HitterStats_PlayerId",
                table: "HitterStats",
                column: "PlayerId",
                unique: true );

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_CommissionerId",
                table: "Leagues",
                column: "CommissionerId" );

            migrationBuilder.CreateIndex(
                name: "IX_PitcherStats_PlayerId",
                table: "PitcherStats",
                column: "PlayerId",
                unique: true );

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAssignments_FranchiseId",
                table: "PlayerAssignments",
                column: "FranchiseId" );

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId" );
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims" );

            migrationBuilder.DropTable(
                name: "AspNetUserClaims" );

            migrationBuilder.DropTable(
                name: "AspNetUserLogins" );

            migrationBuilder.DropTable(
                name: "AspNetUserRoles" );

            migrationBuilder.DropTable(
                name: "AspNetUserTokens" );

            migrationBuilder.DropTable(
                name: "HitterStats" );

            migrationBuilder.DropTable(
                name: "PitcherStats" );

            migrationBuilder.DropTable(
                name: "PlayerAssignmentDates" );

            migrationBuilder.DropTable(
                name: "PlayerAssignments" );

            migrationBuilder.DropTable(
                name: "PlayerPositions" );

            migrationBuilder.DropTable(
                name: "PlayerTrades" );

            migrationBuilder.DropTable(
                name: "PlayerValues" );

            migrationBuilder.DropTable(
                name: "AspNetRoles" );

            migrationBuilder.DropTable(
                name: "Players" );

            migrationBuilder.DropTable(
                name: "Franchises" );

            migrationBuilder.DropTable(
                name: "Teams" );

            migrationBuilder.DropTable(
                name: "Leagues" );

            migrationBuilder.DropTable(
                name: "AspNetUsers" );
        }
    }
}
