using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillzMatrixAPI.Migrations
{
    public partial class UserSkillz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSkillz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    SkillzId = table.Column<int>(nullable: false),
                    LevelsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkillz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkillz_Levels_LevelsId",
                        column: x => x.LevelsId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkillz_Skillz_SkillzId",
                        column: x => x.SkillzId,
                        principalTable: "Skillz",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkillz_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillz_LevelsId",
                table: "UserSkillz",
                column: "LevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillz_SkillzId",
                table: "UserSkillz",
                column: "SkillzId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillz_UserId",
                table: "UserSkillz",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSkillz");
        }
    }
}
