using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpBack.Migrations
{
    public partial class DeleteProductCOlorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductCompositions");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCounts_ColorId",
                table: "ProductCounts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCounts_CompositionId",
                table: "ProductCounts",
                column: "CompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCounts_SizeId",
                table: "ProductCounts",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCounts_Colors_ColorId",
                table: "ProductCounts",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCounts_Compositions_CompositionId",
                table: "ProductCounts",
                column: "CompositionId",
                principalTable: "Compositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCounts_Sizes_SizeId",
                table: "ProductCounts",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCounts_Colors_ColorId",
                table: "ProductCounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCounts_Compositions_CompositionId",
                table: "ProductCounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCounts_Sizes_SizeId",
                table: "ProductCounts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCounts_ColorId",
                table: "ProductCounts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCounts_CompositionId",
                table: "ProductCounts");

            migrationBuilder.DropIndex(
                name: "IX_ProductCounts_SizeId",
                table: "ProductCounts");

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductColors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCompositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompositionId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCompositions_Compositions_CompositionId",
                        column: x => x.CompositionId,
                        principalTable: "Compositions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductCompositions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    SizeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ColorId",
                table: "ProductColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductId",
                table: "ProductColors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompositions_CompositionId",
                table: "ProductCompositions",
                column: "CompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompositions_ProductId",
                table: "ProductCompositions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeId",
                table: "ProductSizes",
                column: "SizeId");
        }
    }
}
