using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmoryStore.Data.Migrations
{
    public partial class ImageIntityModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Images",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Images",
                newName: "Url");
        }
    }
}
