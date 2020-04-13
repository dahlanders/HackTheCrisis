using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackTheCrisis.Data.Migrations
{
    public partial class UpdatedOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Needs",
                newName: "SubmittedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Offers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OfferStatus",
                table: "Offers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "Offers",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "QuantityUnit",
                table: "Offers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NeesStatus",
                table: "Needs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "OfferStatus",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "QuantityUnit",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "NeesStatus",
                table: "Needs");

            migrationBuilder.RenameColumn(
                name: "SubmittedDate",
                table: "Needs",
                newName: "CreatedDate");
        }
    }
}
