using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalaryCapData.Migrations
{
    public partial class AddedFranchisePlayersTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_PlayerAssignments_FranchiseId",
                table: "PlayerAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "FranchiseId",
                table: "PlayerAssignments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FranchisePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatcherId = table.Column<int>(nullable: true),
                    DesignatedHitterId = table.Column<int>(nullable: true),
                    FirstBaseId = table.Column<int>(nullable: true),
                    FranchiseId = table.Column<int>(nullable: false),
                    Outfield1Id = table.Column<int>(nullable: true),
                    Outfield2Id = table.Column<int>(nullable: true),
                    Outfield3Id = table.Column<int>(nullable: true),
                    Pitcher1Id = table.Column<int>(nullable: true),
                    Pitcher2Id = table.Column<int>(nullable: true),
                    Pitcher3Id = table.Column<int>(nullable: true),
                    Pitcher4Id = table.Column<int>(nullable: true),
                    SecondBaseId = table.Column<int>(nullable: true),
                    ShortStopId = table.Column<int>(nullable: true),
                    ThirdBaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranchisePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_CatcherId",
                        column: x => x.CatcherId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_DesignatedHitterId",
                        column: x => x.DesignatedHitterId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_FirstBaseId",
                        column: x => x.FirstBaseId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Outfield1Id",
                        column: x => x.Outfield1Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Outfield2Id",
                        column: x => x.Outfield2Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Outfield3Id",
                        column: x => x.Outfield3Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Pitcher1Id",
                        column: x => x.Pitcher1Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Pitcher2Id",
                        column: x => x.Pitcher2Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Pitcher3Id",
                        column: x => x.Pitcher3Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_Pitcher4Id",
                        column: x => x.Pitcher4Id,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_SecondBaseId",
                        column: x => x.SecondBaseId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_ShortStopId",
                        column: x => x.ShortStopId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FranchisePlayers_PlayerAssignments_ThirdBaseId",
                        column: x => x.ThirdBaseId,
                        principalTable: "PlayerAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_CatcherId",
                table: "FranchisePlayers",
                column: "CatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_DesignatedHitterId",
                table: "FranchisePlayers",
                column: "DesignatedHitterId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_FirstBaseId",
                table: "FranchisePlayers",
                column: "FirstBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Outfield1Id",
                table: "FranchisePlayers",
                column: "Outfield1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Outfield2Id",
                table: "FranchisePlayers",
                column: "Outfield2Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Outfield3Id",
                table: "FranchisePlayers",
                column: "Outfield3Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Pitcher1Id",
                table: "FranchisePlayers",
                column: "Pitcher1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Pitcher2Id",
                table: "FranchisePlayers",
                column: "Pitcher2Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Pitcher3Id",
                table: "FranchisePlayers",
                column: "Pitcher3Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_Pitcher4Id",
                table: "FranchisePlayers",
                column: "Pitcher4Id");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_SecondBaseId",
                table: "FranchisePlayers",
                column: "SecondBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_ShortStopId",
                table: "FranchisePlayers",
                column: "ShortStopId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisePlayers_ThirdBaseId",
                table: "FranchisePlayers",
                column: "ThirdBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FranchisePlayers");

            migrationBuilder.AlterColumn<int>(
                name: "FranchiseId",
                table: "PlayerAssignments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAssignments_FranchiseId",
                table: "PlayerAssignments",
                column: "FranchiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments",
                column: "FranchiseId",
                principalTable: "Franchises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
