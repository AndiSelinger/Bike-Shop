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
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bike", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bike_Vin",
                schema: "bikeshop",
                table: "Bike",
                column: "Vin",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bike",
                schema: "bikeshop");
        }
    }
}
