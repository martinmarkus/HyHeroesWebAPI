using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FailedTransactions_PurchasedProducts_PurchasedProductId",
                table: "FailedTransactions");

            migrationBuilder.DropIndex(
                name: "IX_FailedTransactions_PurchasedProductId",
                table: "FailedTransactions");

            migrationBuilder.DropColumn(
                name: "PurchasedProductId",
                table: "FailedTransactions");

            migrationBuilder.AddColumn<int>(
                name: "KreditAmount",
                table: "FailedTransactions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KreditAmount",
                table: "FailedTransactions");

            migrationBuilder.AddColumn<Guid>(
                name: "PurchasedProductId",
                table: "FailedTransactions",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_PurchasedProductId",
                table: "FailedTransactions",
                column: "PurchasedProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_FailedTransactions_PurchasedProducts_PurchasedProductId",
                table: "FailedTransactions",
                column: "PurchasedProductId",
                principalTable: "PurchasedProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
