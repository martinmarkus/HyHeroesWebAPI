using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayPalTransactionRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    IsRequestProcessed = table.Column<bool>(nullable: false),
                    RequesterUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalTransactionRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayPalTransactionRequests_Users_RequesterUserId",
                        column: x => x.RequesterUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayPalTransactionRequests_RequesterUserId",
                table: "PayPalTransactionRequests",
                column: "RequesterUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayPalTransactionRequests");
        }
    }
}
