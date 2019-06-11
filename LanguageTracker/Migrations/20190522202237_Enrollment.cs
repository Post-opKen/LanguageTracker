using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTracker.Migrations
{
    public partial class Enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    SID = table.Column<string>(type: "nvarchar(9)", nullable: false),
                    ClassID = table.Column<string>(type: "varchar(4)", nullable: true),
                    YearQuarterID = table.Column<string>(type: "varchar(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.SID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");
        }
    }
}
