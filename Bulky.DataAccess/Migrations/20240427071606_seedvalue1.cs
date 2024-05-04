using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedvalue1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Author", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Maria Hoey and Peter Hoey", "A delightfully strange collection of linked stories pondering just how little people truly know about animals.", "978-1-60309-502-0", "", 90.0, 87.0, 67.0, 67.0, "Animal Stories" },
                    { 2, " Jess Fink", "Sexy and charming This is pornography with a heart", "978-1-60309-535-8", "", 56.0, 52.0, 43.0, 45.0, "Chester 5000" },
                    { 3, "Rich Koslowski", " If superheroes were real, they’d be a lot like pro athletes. But when supers start mysteriously dropping dead, all the agents and managers in the world may not be able to save them...", "978-1-60309-515-0", "", 90.0, 89.0, 67.0, 78.0, "F.A.R.M. System" },
                    { 4, "Eddie Campbell", "The first modern serial killer strikes his first victims, and reluctant Inspector Abberline is assigned the case of a lifetime.", "UPC 827714016215", "", 90.0, 56.0, 43.0, 45.0, "Hell: Master Edition " },
                    { 5, "Jeffrey Brown", "This pocket-sized volume is to The Transformers what Avenue Q is to Sesame Street -- a mocking, fawning, idiotic, adoring paean to a pop culture phenomenon inseparable from the artist’s person. Although allegory without substance, all action and no moral, it’s delightful fluff", "978-1-891830-91-4", "", 89.0, 78.0, 56.0, 76.0, "Incredible Change-Bots One" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
