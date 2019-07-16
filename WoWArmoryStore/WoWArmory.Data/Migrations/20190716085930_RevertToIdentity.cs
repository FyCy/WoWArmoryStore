using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmory.Data.Migrations
{
    public partial class RevertToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WoWUserId1",
                table: "Heroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_WoWUserId1",
                table: "Heroes",
                column: "WoWUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_AspNetUsers_WoWUserId1",
                table: "Heroes",
                column: "WoWUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_AspNetUsers_WoWUserId1",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_WoWUserId1",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "WoWUserId1",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
