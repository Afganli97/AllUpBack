using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpBack.Migrations
{
    public partial class UpdateImagesColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Images_PartnerId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Banners");

            migrationBuilder.AddColumn<int>(
                name: "AdvantageId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BannerId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Advantage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advantage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdvantageId",
                table: "Images",
                column: "AdvantageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_BannerId",
                table: "Images",
                column: "BannerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_PartnerId",
                table: "Images",
                column: "PartnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_SliderId",
                table: "Images",
                column: "SliderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Advantage_AdvantageId",
                table: "Images",
                column: "AdvantageId",
                principalTable: "Advantage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Banners_BannerId",
                table: "Images",
                column: "BannerId",
                principalTable: "Banners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Sliders_SliderId",
                table: "Images",
                column: "SliderId",
                principalTable: "Sliders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advantage_AdvantageId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Banners_BannerId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Sliders_SliderId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Advantage");

            migrationBuilder.DropIndex(
                name: "IX_Images_AdvantageId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_BannerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PartnerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SliderId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "AdvantageId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Sliders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Banners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_PartnerId",
                table: "Images",
                column: "PartnerId");
        }
    }
}
