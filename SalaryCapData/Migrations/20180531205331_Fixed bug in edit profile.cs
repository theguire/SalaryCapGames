using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalaryCapData.Migrations
{
    public partial class Fixedbugineditprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_CatcherId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_DesignatedHitterId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_FirstBaseId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield1Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield2Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield3Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher1Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher2Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher3Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher4Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_SecondBaseId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_ShortStopId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_ThirdBaseId",
                table: "FranchisePlayers");

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_CatcherId",
                table: "FranchisePlayers",
                column: "CatcherId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_DesignatedHitterId",
                table: "FranchisePlayers",
                column: "DesignatedHitterId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_FirstBaseId",
                table: "FranchisePlayers",
                column: "FirstBaseId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield1Id",
                table: "FranchisePlayers",
                column: "Outfield1Id",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield2Id",
                table: "FranchisePlayers",
                column: "Outfield2Id",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield3Id",
                table: "FranchisePlayers",
                column: "Outfield3Id",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher1Id",
                table: "FranchisePlayers",
                column: "Pitcher1Id",
                principalTable: "PitcherStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher2Id",
                table: "FranchisePlayers",
                column: "Pitcher2Id",
                principalTable: "PitcherStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher3Id",
                table: "FranchisePlayers",
                column: "Pitcher3Id",
                principalTable: "PitcherStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher4Id",
                table: "FranchisePlayers",
                column: "Pitcher4Id",
                principalTable: "PitcherStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_SecondBaseId",
                table: "FranchisePlayers",
                column: "SecondBaseId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_ShortStopId",
                table: "FranchisePlayers",
                column: "ShortStopId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_HitterStats_ThirdBaseId",
                table: "FranchisePlayers",
                column: "ThirdBaseId",
                principalTable: "HitterStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_CatcherId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_DesignatedHitterId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_FirstBaseId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield1Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield2Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_Outfield3Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher1Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher2Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher3Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_PitcherStats_Pitcher4Id",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_SecondBaseId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_ShortStopId",
                table: "FranchisePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisePlayers_HitterStats_ThirdBaseId",
                table: "FranchisePlayers");

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_CatcherId",
                table: "FranchisePlayers",
                column: "CatcherId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_DesignatedHitterId",
                table: "FranchisePlayers",
                column: "DesignatedHitterId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_FirstBaseId",
                table: "FranchisePlayers",
                column: "FirstBaseId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield1Id",
                table: "FranchisePlayers",
                column: "Outfield1Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield2Id",
                table: "FranchisePlayers",
                column: "Outfield2Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Outfield3Id",
                table: "FranchisePlayers",
                column: "Outfield3Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher1Id",
                table: "FranchisePlayers",
                column: "Pitcher1Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher2Id",
                table: "FranchisePlayers",
                column: "Pitcher2Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher3Id",
                table: "FranchisePlayers",
                column: "Pitcher3Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_Pitcher4Id",
                table: "FranchisePlayers",
                column: "Pitcher4Id",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_SecondBaseId",
                table: "FranchisePlayers",
                column: "SecondBaseId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_ShortStopId",
                table: "FranchisePlayers",
                column: "ShortStopId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisePlayers_PlayerAssignments_ThirdBaseId",
                table: "FranchisePlayers",
                column: "ThirdBaseId",
                principalTable: "PlayerAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
