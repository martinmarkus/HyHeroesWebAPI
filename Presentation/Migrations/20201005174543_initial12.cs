using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServerExpirations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Lobby = table.Column<bool>(nullable: false),
                    Survival = table.Column<bool>(nullable: false),
                    Creative = table.Column<bool>(nullable: false),
                    GTA = table.Column<bool>(nullable: false),
                    PotterCraft = table.Column<bool>(nullable: false),
                    OpSkyBlock = table.Column<bool>(nullable: false),
                    SkyBoss = table.Column<bool>(nullable: false),
                    Prison = table.Column<bool>(nullable: false),
                    ComboFly = table.Column<bool>(nullable: false),
                    Arcade = table.Column<bool>(nullable: false),
                    PurchasedProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerExpirations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerExpirations_PurchasedProducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "PurchasedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServerExpirations_PurchasedProductId",
                table: "ServerExpirations",
                column: "PurchasedProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerExpirations");
        }
    }
}
