using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackTheCrisis.Data.Migrations
{
    public partial class Submitted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Offers");

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmittedDate",
                table: "Offers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmittedDate",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
