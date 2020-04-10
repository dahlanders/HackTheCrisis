using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackTheCrisis.Data.Migrations
{
    public partial class RemovedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareUnits_Address_AddressID",
                table: "HealthCareUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialPartners_Address_AddressID",
                table: "IndustrialPartners");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialPartners_AddressID",
                table: "IndustrialPartners");

            migrationBuilder.DropIndex(
                name: "IX_HealthCareUnits_AddressID",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "IndustrialPartners");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "HealthCareUnits");

            migrationBuilder.RenameColumn(
                name: "ContactDetailsID",
                table: "IndustrialPartners",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "ContactDetailsID",
                table: "HealthCareUnits",
                newName: "PostalCode");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "IndustrialPartners",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "IndustrialPartners",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "IndustrialPartners",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "IndustrialPartners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "HealthCareUnits",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "HealthCareUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "HealthCareUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "HealthCareUnits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "IndustrialPartners");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "IndustrialPartners");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "IndustrialPartners");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "IndustrialPartners");

            migrationBuilder.DropColumn(
                name: "City",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "HealthCareUnits");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "IndustrialPartners",
                newName: "ContactDetailsID");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "HealthCareUnits",
                newName: "ContactDetailsID");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "IndustrialPartners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "HealthCareUnits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialPartners_AddressID",
                table: "IndustrialPartners",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareUnits_AddressID",
                table: "HealthCareUnits",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareUnits_Address_AddressID",
                table: "HealthCareUnits",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialPartners_Address_AddressID",
                table: "IndustrialPartners",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
