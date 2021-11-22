using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsMeetup.com.Data.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eventLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Host = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    GuestCount = table.Column<int>(nullable: false),
                    SpotsFilled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "userFavorites",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userFavorites", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventLists");

            migrationBuilder.DropTable(
                name: "userFavorites");
        }
    }
}
