using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalaryCapData.Migrations
{
    public partial class AddedFranchisePlayersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "FranchiseId",
                table: "PlayerAssignments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAssignments_PlayerId",
                table: "PlayerAssignments",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments",
                column: "FranchiseId",
                principalTable: "Franchises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAssignments_Players_PlayerId",
                table: "PlayerAssignments",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAssignments_Players_PlayerId",
                table: "PlayerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_PlayerAssignments_PlayerId",
                table: "PlayerAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "FranchiseId",
                table: "PlayerAssignments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAssignments_Franchises_FranchiseId",
                table: "PlayerAssignments",
                column: "FranchiseId",
                principalTable: "Franchises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
