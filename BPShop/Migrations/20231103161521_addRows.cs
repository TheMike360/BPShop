using Microsoft.EntityFrameworkCore.Migrations;

namespace BPShop.Migrations
{
    public partial class addRows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlowersType",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgRef",
                table: "Products",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlowersType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImgRef",
                table: "Products");
        }
    }
}
