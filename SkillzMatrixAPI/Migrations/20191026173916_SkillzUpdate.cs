using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillzMatrixAPI.Migrations
{
    public partial class SkillzUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelNumber",
                table: "Skillz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Skillz",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LevelNumber",
                table: "Skillz");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Skillz");
        }
    }
}
