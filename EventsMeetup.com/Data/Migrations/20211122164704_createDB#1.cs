using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsMeetup.com.Data.Migrations
{
    public partial class createDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "userFavorites",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "userFavorites");
        }
    }
}
