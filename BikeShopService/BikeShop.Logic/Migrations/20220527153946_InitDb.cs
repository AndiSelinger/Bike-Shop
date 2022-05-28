using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeShop.Logic.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bikeshop");

            migrationBuilder.CreateTable(
                name: "Shop",
                schema: "bikeshop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoogleAddressString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bike",
                schema: "bikeshop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Ccm = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProductionYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SpecialModel = table.Column<bool>(type: "bit", nullable: true),
                    LastService = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bike_Shop_ShopId",
                        column: x => x.ShopId,
                        principalSchema: "bikeshop",
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bike_ShopId",
                schema: "bikeshop",
                table: "Bike",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Bike_Vin",
                schema: "bikeshop",
                table: "Bike",
                column: "Vin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Address",
                schema: "bikeshop",
                table: "Shop",
                column: "Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Location",
                schema: "bikeshop",
                table: "Shop",
                column: "Location",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bike",
                schema: "bikeshop");

            migrationBuilder.DropTable(
                name: "Shop",
                schema: "bikeshop");
        }
    }
}
