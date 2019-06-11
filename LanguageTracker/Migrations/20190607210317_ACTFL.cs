using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTracker.Migrations
{
    public partial class ACTFL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PROF_TYPE",
                table: "ACTFL",
                newName: "Writing");

            migrationBuilder.RenameColumn(
                name: "PROF_SCR",
                table: "ACTFL",
                newName: "Speaking");

            migrationBuilder.RenameColumn(
                name: "PROF_LVL",
                table: "ACTFL",
                newName: "Reading");

            migrationBuilder.AddColumn<string>(
                name: "Listening",
                table: "ACTFL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proficiency_Area",
                table: "ACTFL",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Listening",
                table: "ACTFL");

            migrationBuilder.DropColumn(
                name: "Proficiency_Area",
                table: "ACTFL");

            migrationBuilder.RenameColumn(
                name: "Writing",
                table: "ACTFL",
                newName: "PROF_TYPE");

            migrationBuilder.RenameColumn(
                name: "Speaking",
                table: "ACTFL",
                newName: "PROF_SCR");

            migrationBuilder.RenameColumn(
                name: "Reading",
                table: "ACTFL",
                newName: "PROF_LVL");
        }
    }
}
