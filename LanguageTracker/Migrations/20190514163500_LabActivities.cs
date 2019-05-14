using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTracker.Migrations
{
    public partial class LabActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabActivities",
                columns: table => new
                {
                    sid = table.Column<int>(nullable: false),
                    last_name = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    activity = table.Column<string>(nullable: true),
                    staff_levels = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabActivities", x => x.sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabActivities");
        }
    }
}
