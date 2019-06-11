using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTracker.Migrations
{
    public partial class Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassID = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    YearQuarterID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ItemNumber = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    CourseID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    InstructorName = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
