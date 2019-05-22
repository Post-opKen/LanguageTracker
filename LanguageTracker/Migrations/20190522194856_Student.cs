using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTracker.Migrations
{
    public partial class Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemNumber",
                table: "Class",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    SID = table.Column<string>(type: "nvarchar(9)", nullable: false),
                    FullName = table.Column<string>(type: "varchar(22)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.SID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "ItemNumber",
                table: "Class",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
