using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackTheCrisis.Data.Migrations
{
    public partial class NewDbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demands");

            migrationBuilder.AlterColumn<int>(
                name: "UnitType",
                table: "HealthCareUnits",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "HealthCareUnits",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "HealthCareUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactDetailsID",
                table: "HealthCareUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "HealthCareUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "HealthCareUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "HealthCareUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Needs",
                columns: table => new
                {
                    NeedID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnumNeedType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    QuantityUnit = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    OwnerHealthCareUnitID = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Needs", x => x.NeedID);
                    table.ForeignKey(
                        name: "FK_Needs_HealthCareUnits_OwnerHealthCareUnitID",
                        column: x => x.OwnerHealthCareUnitID,
                        principalTable: "HealthCareUnits",
                        principalColumn: "HealthCareUnitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialPartners",
                columns: table => new
                {
                    ContactDetailsID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IndustrialPartnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorporateIdentityNumber = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustrialPartners", x => x.IndustrialPartnerID);
                    table.ForeignKey(
                        name: "FK_IndustrialPartners_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferTypes = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OwnerIndustrialPartnerID = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferID);
                    table.ForeignKey(
                        name: "FK_Offers_IndustrialPartners_OwnerIndustrialPartnerID",
                        column: x => x.OwnerIndustrialPartnerID,
                        principalTable: "IndustrialPartners",
                        principalColumn: "IndustrialPartnerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareUnits_AddressID",
                table: "HealthCareUnits",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialPartners_AddressID",
                table: "IndustrialPartners",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Needs_OwnerHealthCareUnitID",
                table: "Needs",
                column: "OwnerHealthCareUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OwnerIndustrialPartnerID",
                table: "Offers",
                column: "OwnerIndustrialPartnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareUnits_Address_AddressID",
                table: "HealthCareUnits",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareUnits_Address_AddressID",
                table: "HealthCareUnits");

            migrationBuilder.DropTable(
                name: "Needs");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "IndustrialPartners");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_HealthCareUnits_AddressID",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "ContactDetailsID",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "HealthCareUnits");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "HealthCareUnits");

            migrationBuilder.AlterColumn<string>(
                name: "UnitType",
                table: "HealthCareUnits",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "HealthCareUnits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Demands",
                columns: table => new
                {
                    DemandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    HealthCareUnitID = table.Column<int>(nullable: false),
                    Item = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    WhenDoINeedIt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demands", x => x.DemandID);
                    table.ForeignKey(
                        name: "FK_Demands_HealthCareUnits_HealthCareUnitID",
                        column: x => x.HealthCareUnitID,
                        principalTable: "HealthCareUnits",
                        principalColumn: "HealthCareUnitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demands_HealthCareUnitID",
                table: "Demands",
                column: "HealthCareUnitID");
        }
    }
}
