using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    public partial class AddColumnManufacturerIdToProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_products_manufacturer_id",
                table: "products",
                column: "manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_manufacturers_manufacturer_id",
                table: "products",
                column: "manufacturer_id",
                principalTable: "manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_manufacturers_manufacturer_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_manufacturer_id",
                table: "products");
        }
    }
}
