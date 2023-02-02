using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpBack.Migrations
{
    public partial class UpdateBannerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannerId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Banners",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_ProductId",
                table: "Sliders",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banners_ProductId",
                table: "Banners",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Banners_Products_ProductId",
                table: "Banners",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Products_ProductId",
                table: "Sliders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banners_Products_ProductId",
                table: "Banners");

            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Products_ProductId",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_ProductId",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Banners_ProductId",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Banners");
        }
    }
}
