using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazonClone.DbContexts.Data.Migrations
{
    public partial class RemovedProductRefInOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderdetails_products_ProductID",
                table: "orderdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_UserID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orderdetails_ProductID",
                table: "orderdetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_orders_UserID",
                table: "orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_orderdetails_ProductID",
                table: "orderdetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_orderdetails_products_ProductID",
                table: "orderdetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_UserID",
                table: "orders",
                column: "UserID",
                principalTable: "users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
