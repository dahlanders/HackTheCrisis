using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackTheCrisis.Data.Migrations
{
    public partial class AddedNewCreatedDateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_HealthCareUnits_HealthCareUnitID",
                table: "Demands");

            migrationBuilder.AlterColumn<string>(
                name: "UnitType",
                table: "HealthCareUnits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "HealthCareUnits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "Demands",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HealthCareUnitID",
                table: "Demands",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Demands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_HealthCareUnits_HealthCareUnitID",
                table: "Demands",
                column: "HealthCareUnitID",
                principalTable: "HealthCareUnits",
                principalColumn: "HealthCareUnitID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_HealthCareUnits_HealthCareUnitID",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Demands");

            migrationBuilder.AlterColumn<string>(
                name: "UnitType",
                table: "HealthCareUnits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "HealthCareUnits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "Demands",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "HealthCareUnitID",
                table: "Demands",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_HealthCareUnits_HealthCareUnitID",
                table: "Demands",
                column: "HealthCareUnitID",
                principalTable: "HealthCareUnits",
                principalColumn: "HealthCareUnitID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
