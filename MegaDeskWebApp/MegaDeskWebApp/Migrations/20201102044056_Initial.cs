using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true),
                    Depth = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    DrawerCount = table.Column<int>(nullable: false),
                    DeskMaterial = table.Column<string>(nullable: true),
                    ShippingOption = table.Column<string>(nullable: true),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    Area = table.Column<decimal>(nullable: false),
                    OversizeCost = table.Column<decimal>(nullable: false),
                    MaterialCost = table.Column<decimal>(nullable: false),
                    DrawerCost = table.Column<decimal>(nullable: false),
                    ShippingCost = table.Column<decimal>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
