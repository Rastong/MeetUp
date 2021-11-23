using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsMeetup.com.Data.Migrations
{
    public partial class addfkref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "userFavorites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventListID",
                table: "userFavorites",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userFavorites_ApplicationUserId",
                table: "userFavorites",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_userFavorites_EventListID",
                table: "userFavorites",
                column: "EventListID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavorites_AspNetUsers_ApplicationUserId",
                table: "userFavorites",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavorites_eventLists_EventListID",
                table: "userFavorites",
                column: "EventListID",
                principalTable: "eventLists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavorites_AspNetUsers_ApplicationUserId",
                table: "userFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavorites_eventLists_EventListID",
                table: "userFavorites");

            migrationBuilder.DropIndex(
                name: "IX_userFavorites_ApplicationUserId",
                table: "userFavorites");

            migrationBuilder.DropIndex(
                name: "IX_userFavorites_EventListID",
                table: "userFavorites");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "userFavorites");

            migrationBuilder.DropColumn(
                name: "EventListID",
                table: "userFavorites");
        }
    }
}
