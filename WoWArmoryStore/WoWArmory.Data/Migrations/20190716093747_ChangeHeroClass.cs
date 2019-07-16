using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmory.Data.Migrations
{
    public partial class ChangeHeroClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_AspNetUsers_WoWUserId1",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_WoWUserId1",
                table: "Heroes");

            migrationBuilder.RenameColumn(
                name: "WoWUserId1",
                table: "Heroes",
                newName: "WoWUserName");

            migrationBuilder.AlterColumn<string>(
                name: "WoWUserName",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WoWUserName",
                table: "Heroes",
                newName: "WoWUserId1");

            migrationBuilder.AlterColumn<string>(
                name: "WoWUserId1",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
