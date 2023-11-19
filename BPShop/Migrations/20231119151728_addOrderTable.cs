using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BPShop.Migrations
{
    public partial class addOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Time = table.Column<DateTime>(nullable: false),
                    ProductIds = table.Column<string>(nullable: true),
                    Count = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    HisName = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    RecipientName = table.Column<string>(maxLength: 100, nullable: true),
                    RecipientContact = table.Column<string>(maxLength: 100, nullable: true),
                    PayType = table.Column<int>(nullable: false),
                    OrderStatuses = table.Column<int>(nullable: false),
                    DeliverDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
