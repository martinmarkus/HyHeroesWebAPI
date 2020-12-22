using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExpirationVerified",
                table: "PurchasedProducts");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "PurchasedProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExpirationVerified",
                table: "PurchasedProducts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "PurchasedProducts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
