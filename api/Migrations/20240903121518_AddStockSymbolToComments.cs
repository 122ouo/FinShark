using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddStockSymbolToComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31568204-64ae-49db-a467-11329d4e5428");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb03f63b-9309-4a61-b624-994993186c88");

            migrationBuilder.AddColumn<string>(
                name: "stockSymbol",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1155c134-e798-4e29-b6ce-f2902ea1296c", null, "Admin", "ADMIN" },
                    { "1ed781f2-a8cb-4bb5-89a7-770b06d9efb5", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1155c134-e798-4e29-b6ce-f2902ea1296c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ed781f2-a8cb-4bb5-89a7-770b06d9efb5");

            migrationBuilder.DropColumn(
                name: "stockSymbol",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31568204-64ae-49db-a467-11329d4e5428", null, "Admin", "ADMIN" },
                    { "eb03f63b-9309-4a61-b624-994993186c88", null, "User", "USER" }
                });
        }
    }
}
