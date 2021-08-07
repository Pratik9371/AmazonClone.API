using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazonClone.DbContexts.Data.Migrations
{
    public partial class RemovedPriceFromOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "orderdetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "orderdetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
