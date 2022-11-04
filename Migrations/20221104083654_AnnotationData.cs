using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    public partial class AnnotationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvNumber",
                table: "Product",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvNumber",
                table: "Product");
        }
    }
}
