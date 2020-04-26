using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidityPeriodInDays",
                table: "PurchasedProducts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Currency",
                table: "Users",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "ValidityPeriodInMonths",
                table: "PurchasedProducts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidityPeriodInMonths",
                table: "PurchasedProducts");

            migrationBuilder.AlterColumn<float>(
                name: "Currency",
                table: "Users",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "ValidityPeriodInDays",
                table: "PurchasedProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
