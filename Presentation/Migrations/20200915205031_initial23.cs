using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FailedTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    FailDate = table.Column<DateTime>(nullable: false),
                    PurchasedProductId = table.Column<Guid>(nullable: false),
                    BillingTransactionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailedTransactions_BillingTransactions_BillingTransactionId",
                        column: x => x.BillingTransactionId,
                        principalTable: "BillingTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FailedTransactions_PurchasedProducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "PurchasedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_BillingTransactionId",
                table: "FailedTransactions",
                column: "BillingTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactions_PurchasedProductId",
                table: "FailedTransactions",
                column: "PurchasedProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FailedTransactions");
        }
    }
}
