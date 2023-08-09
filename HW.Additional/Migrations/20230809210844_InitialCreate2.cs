using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW.Additional.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_SellerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_SellerId",
                table: "Owners",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Sellers_SellerId",
                table: "Owners",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Sellers_SellerId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_SellerId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Owners");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SellerId",
                table: "Cars",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }
    }
}
