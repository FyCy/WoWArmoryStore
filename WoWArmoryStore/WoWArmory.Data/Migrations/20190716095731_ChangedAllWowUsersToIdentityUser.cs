using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmory.Data.Migrations
{
    public partial class ChangedAllWowUsersToIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_AspNetUsers_WoWUserId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_WoWUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_WoWUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_WoWUserId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "WoWUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WoWUserId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "WoWUserName",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WoWUserName",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "WoWUserId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WoWUserId",
                table: "Heroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WoWUserId",
                table: "Products",
                column: "WoWUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_WoWUserId",
                table: "Heroes",
                column: "WoWUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_AspNetUsers_WoWUserId",
                table: "Heroes",
                column: "WoWUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_WoWUserId",
                table: "Products",
                column: "WoWUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
