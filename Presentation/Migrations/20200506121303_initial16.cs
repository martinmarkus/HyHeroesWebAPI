using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActualValueOfOneKredit",
                table: "PurchasedProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ActualValueOfOneKredit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualValueOfOneKredit", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualValueOfOneKredit");

            migrationBuilder.DropColumn(
                name: "ActualValueOfOneKredit",
                table: "PurchasedProducts");
        }
    }
}
