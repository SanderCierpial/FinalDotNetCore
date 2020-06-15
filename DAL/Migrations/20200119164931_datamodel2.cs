using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class datamodel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerIdId",
                table: "ShoppingBags");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_Products_ProductIdId",
                table: "ShoppingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagIdId",
                table: "ShoppingItems");

            migrationBuilder.RenameColumn(
                name: "ShoppingBagIdId",
                table: "ShoppingItems",
                newName: "ShoppingBagId");

            migrationBuilder.RenameColumn(
                name: "ProductIdId",
                table: "ShoppingItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingItems_ShoppingBagIdId",
                table: "ShoppingItems",
                newName: "IX_ShoppingItems_ShoppingBagId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingItems_ProductIdId",
                table: "ShoppingItems",
                newName: "IX_ShoppingItems_ProductId");

            migrationBuilder.RenameColumn(
                name: "CustomerIdId",
                table: "ShoppingBags",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingBags_CustomerIdId",
                table: "ShoppingBags",
                newName: "IX_ShoppingBags_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagId",
                table: "ShoppingItems",
                column: "ShoppingBagId",
                principalTable: "ShoppingBags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagId",
                table: "ShoppingItems");

            migrationBuilder.RenameColumn(
                name: "ShoppingBagId",
                table: "ShoppingItems",
                newName: "ShoppingBagIdId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShoppingItems",
                newName: "ProductIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingItems_ShoppingBagId",
                table: "ShoppingItems",
                newName: "IX_ShoppingItems_ShoppingBagIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingItems_ProductId",
                table: "ShoppingItems",
                newName: "IX_ShoppingItems_ProductIdId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "ShoppingBags",
                newName: "CustomerIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags",
                newName: "IX_ShoppingBags_CustomerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerIdId",
                table: "ShoppingBags",
                column: "CustomerIdId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_Products_ProductIdId",
                table: "ShoppingItems",
                column: "ProductIdId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagIdId",
                table: "ShoppingItems",
                column: "ShoppingBagIdId",
                principalTable: "ShoppingBags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
