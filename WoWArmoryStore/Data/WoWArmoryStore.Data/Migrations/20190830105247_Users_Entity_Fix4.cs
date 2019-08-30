using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmoryStore.Data.Migrations
{
    public partial class Users_Entity_Fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WoWArmoryUserId",
                table: "Heroes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WoWArmoryUserId",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
