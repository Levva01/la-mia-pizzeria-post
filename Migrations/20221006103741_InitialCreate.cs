using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_post.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizze",
                columns: new[] { "Id", "Descrizione", "Foto", "Nome", "Prezzo" },
                values: new object[,]
                {
                    { 1, "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo", "img/pizza.jpg", "Margherita", 5.0 },
                    { 2, "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo", "img/pizza.jpg", "Margherita", 5.0 },
                    { 3, "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo", "img/pizza.jpg", "Margherita", 5.0 },
                    { 4, "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo", "img/pizza.jpg", "Margherita", 5.0 },
                    { 5, "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo", "img/pizza.jpg", "Margherita", 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
