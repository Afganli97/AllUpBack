using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpBack.Migrations
{
    public partial class AddPartnersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Images",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartnerId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_BlogId",
                table: "Images",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PartnerId",
                table: "Images",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Blogs_BlogId",
                table: "Images",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Partners_PartnerId",
                table: "Images",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Blogs_BlogId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Partners_PartnerId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_BlogId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CategoryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PartnerId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Partners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Blogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
