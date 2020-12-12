using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "EDSMSPurchases");

            migrationBuilder.AlterColumn<string>(
                name: "McCurrency",
                table: "PayPalIPNMessages",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "EDSMSPurchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "EDSMSPurchases");

            migrationBuilder.AlterColumn<decimal>(
                name: "McCurrency",
                table: "PayPalIPNMessages",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "EDSMSPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
