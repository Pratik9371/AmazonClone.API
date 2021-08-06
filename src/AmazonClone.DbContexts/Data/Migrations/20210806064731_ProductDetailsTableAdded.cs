using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazonClone.DbContexts.Data.Migrations
{
    public partial class ProductDetailsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_products_ProductID",
                table: "ProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails");

            migrationBuilder.RenameTable(
                name: "ProductDetails",
                newName: "productdetails");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDetails_ProductID",
                table: "productdetails",
                newName: "IX_productdetails_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productdetails",
                table: "productdetails",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_productdetails_products_ProductID",
                table: "productdetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productdetails_products_ProductID",
                table: "productdetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productdetails",
                table: "productdetails");

            migrationBuilder.RenameTable(
                name: "productdetails",
                newName: "ProductDetails");

            migrationBuilder.RenameIndex(
                name: "IX_productdetails_ProductID",
                table: "ProductDetails",
                newName: "IX_ProductDetails_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_products_ProductID",
                table: "ProductDetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
