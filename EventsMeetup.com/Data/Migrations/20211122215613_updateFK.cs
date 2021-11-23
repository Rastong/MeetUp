using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsMeetup.com.Data.Migrations
{
    public partial class updateFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "userFavorites",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userFavorites_EventID",
                table: "userFavorites",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_userFavorites_UserID",
                table: "userFavorites",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavorites_eventLists_EventID",
                table: "userFavorites",
                column: "EventID",
                principalTable: "eventLists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavorites_AspNetUsers_UserID",
                table: "userFavorites",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavorites_eventLists_EventID",
                table: "userFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavorites_AspNetUsers_UserID",
                table: "userFavorites");

            migrationBuilder.DropIndex(
                name: "IX_userFavorites_EventID",
                table: "userFavorites");

            migrationBuilder.DropIndex(
                name: "IX_userFavorites_UserID",
                table: "userFavorites");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "userFavorites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "userFavorites",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventListID",
                table: "userFavorites",
                type: "int",
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
    }
}
