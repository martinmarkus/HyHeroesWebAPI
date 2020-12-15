using Microsoft.EntityFrameworkCore.Migrations;

namespace HyHeroesWebAPI.Presentation.Migrations
{
    public partial class initial28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Preview",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "News",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preview",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "News");
        }
    }
}
