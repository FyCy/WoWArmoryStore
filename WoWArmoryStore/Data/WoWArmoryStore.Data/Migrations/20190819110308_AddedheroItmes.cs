using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWArmoryStore.Data.Migrations
{
    public partial class AddedheroItmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_HeroId",
                table: "Products",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Heroes_HeroId",
                table: "Products",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Heroes_HeroId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_HeroId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Products");
        }
    }
}
