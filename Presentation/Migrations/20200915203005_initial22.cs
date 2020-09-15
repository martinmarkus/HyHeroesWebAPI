using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "BillingTransactions");

            migrationBuilder.DropColumn(
                name: "IsBilled",
                table: "BillingTransactions");

            migrationBuilder.AddColumn<DateTime>(
                name: "BillingDate",
                table: "BillingTransactions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingDate",
                table: "BillingTransactions");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BillingTransactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsBilled",
                table: "BillingTransactions",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
