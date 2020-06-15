using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "ShoppingBags",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "ShoppingBags");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
