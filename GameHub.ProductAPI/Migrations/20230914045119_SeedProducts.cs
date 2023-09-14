using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHub.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Ação" },
                    { 2, "Luta" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Em The Witcher 3, Geralt de Rivia embarca em uma jornada perigosa e emocionante em um mundo repleto de monstros e intrigas.", "TheWitcher3.png", "The Witcher 3: Wild Hunt", 76.86m, 50L },
                    { 2, 2, "Street Fighter V: A batalha épica de lutadores habilidosos em busca da supremacia.", "StreetFighterV.png", "Street Fighter V", 23.00m, 5L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
