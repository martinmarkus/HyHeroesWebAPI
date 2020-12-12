using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KreditPurchases_Users_UserId",
                table: "KreditPurchases");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "KreditPurchases",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AddForeignKey(
                name: "FK_KreditPurchases_Users_UserId",
                table: "KreditPurchases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KreditPurchases_Users_UserId",
                table: "KreditPurchases");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "KreditPurchases",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KreditPurchases_Users_UserId",
                table: "KreditPurchases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
