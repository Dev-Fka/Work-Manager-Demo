using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkManager.Database.Migrations
{
    public partial class InıtıalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isMonthly = table.Column<bool>(type: "bit", nullable: false),
                    isWeekly = table.Column<bool>(type: "bit", nullable: false),
                    isDaily = table.Column<bool>(type: "bit", nullable: false),
                    isSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    addedTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
