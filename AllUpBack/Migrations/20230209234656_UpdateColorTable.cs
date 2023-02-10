using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpBack.Migrations
{
    public partial class UpdateColorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorBootstrapClass",
                table: "Colors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorBootstrapClass",
                table: "Colors");
        }
    }
}
