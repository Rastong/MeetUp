using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsMeetup.com.Data.Migrations
{
    public partial class createDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "userFavorites",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventID",
                table: "userFavorites");
        }
    }
}
