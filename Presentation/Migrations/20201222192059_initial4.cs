using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerActivations");

            migrationBuilder.DropTable(
                name: "ServerExpirations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServerActivations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Arcade = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ComboFly = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Creative = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GTA = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lobby = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OpSkyBlock = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PotterCraft = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Prison = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PurchasedProductId = table.Column<Guid>(type: "char(36)", nullable: false),
                    SkyBoss = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Survival = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerActivations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerActivations_PurchasedProducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "PurchasedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerExpirations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Arcade = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ComboFly = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Creative = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GTA = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lobby = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OpSkyBlock = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PotterCraft = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Prison = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PurchasedProductId = table.Column<Guid>(type: "char(36)", nullable: false),
                    SkyBoss = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Survival = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                name: "IX_ServerActivations_PurchasedProductId",
                table: "ServerActivations",
                column: "PurchasedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerExpirations_PurchasedProductId",
                table: "ServerExpirations",
                column: "PurchasedProductId");
        }
    }
}
