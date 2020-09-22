using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualValueOfOneKredit",
                table: "PurchasedProducts");

            migrationBuilder.AddColumn<int>(
                name: "ActualPurchasePrice",
                table: "PurchasedProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EDSMSPurchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JatekFizetesId = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    ReceiverPhoneNumber = table.Column<string>(nullable: true),
                    CustomerPhoneNumber = table.Column<string>(nullable: true),
                    GrossPrice = table.Column<string>(nullable: true),
                    IsTest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDSMSPurchases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EDSMSPurchases");

            migrationBuilder.DropColumn(
                name: "ActualPurchasePrice",
                table: "PurchasedProducts");

            migrationBuilder.AddColumn<decimal>(
                name: "ActualValueOfOneKredit",
                table: "PurchasedProducts",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
