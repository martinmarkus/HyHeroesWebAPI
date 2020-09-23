using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KreditValue",
                table: "EDSMSActivationCodes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "EDSMSActivationCodes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_EDSMSActivationCodes_UserId",
                table: "EDSMSActivationCodes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EDSMSActivationCodes_Users_UserId",
                table: "EDSMSActivationCodes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EDSMSActivationCodes_Users_UserId",
                table: "EDSMSActivationCodes");

            migrationBuilder.DropIndex(
                name: "IX_EDSMSActivationCodes_UserId",
                table: "EDSMSActivationCodes");

            migrationBuilder.DropColumn(
                name: "KreditValue",
                table: "EDSMSActivationCodes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EDSMSActivationCodes");
        }
    }
}
