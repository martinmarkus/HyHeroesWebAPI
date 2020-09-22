using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualPurchasePrice",
                table: "PurchasedProducts");

            migrationBuilder.AddColumn<int>(
                name: "KreditSpentOn",
                table: "PurchasedProducts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KreditSpentOn",
                table: "PurchasedProducts");

            migrationBuilder.AddColumn<int>(
                name: "ActualPurchasePrice",
                table: "PurchasedProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
