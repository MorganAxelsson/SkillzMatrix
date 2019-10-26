using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillzMatrixAPI.Migrations
{
    public partial class ModifiedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LevelNumber",
                table: "Skillz");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Skillz");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "LevelNumber",
                table: "Skillz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Skillz",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
