using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Punto_de_venta.Migrations
{
    /// <inheritdoc />
    public partial class FixBuyItemMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buys_Products_ProductId",
                table: "Buys");

            migrationBuilder.DropIndex(
                name: "IX_Buys_ProductId",
                table: "Buys");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Buys");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Buys");

            migrationBuilder.RenameColumn(
                name: "UnitCost",
                table: "Buys",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "DateBuy",
                table: "Buys",
                newName: "Date");

            migrationBuilder.CreateTable(
                name: "BuyItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyItem_Buys_BuyId",
                        column: x => x.BuyId,
                        principalTable: "Buys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyItem_BuyId",
                table: "BuyItem",
                column: "BuyId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyItem_ProductId",
                table: "BuyItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyItem");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Buys",
                newName: "UnitCost");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Buys",
                newName: "DateBuy");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Buys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Buys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Buys_ProductId",
                table: "Buys",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buys_Products_ProductId",
                table: "Buys",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
