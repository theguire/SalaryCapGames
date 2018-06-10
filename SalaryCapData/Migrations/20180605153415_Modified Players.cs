using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalaryCapData.Migrations
{
    public partial class ModifiedPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "FranchiseTemplate",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FranchiseTemplate_PlayerId",
                table: "FranchiseTemplate",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FranchiseTemplate_Players_PlayerId",
                table: "FranchiseTemplate",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FranchiseTemplate_Players_PlayerId",
                table: "FranchiseTemplate");

            migrationBuilder.DropIndex(
                name: "IX_FranchiseTemplate_PlayerId",
                table: "FranchiseTemplate");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "FranchiseTemplate");
        }
    }
}
