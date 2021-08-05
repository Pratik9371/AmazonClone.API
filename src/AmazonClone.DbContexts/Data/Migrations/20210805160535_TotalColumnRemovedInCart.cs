using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazonClone.DbContexts.Data.Migrations
{
    public partial class TotalColumnRemovedInCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "cart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "cart",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
