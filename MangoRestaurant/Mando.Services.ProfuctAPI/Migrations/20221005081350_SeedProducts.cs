using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mando.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Snack", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.", "https://dotnetmastery6502.blob.core.windows.net/mango/samosa.jpg", "Samosa", 15.0 },
                    { 2, "Snack", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.", "https://dotnetmastery6502.blob.core.windows.net/mango/kebab.jpg", "Kebab", 13.99 },
                    { 3, "Dessert", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.", "https://dotnetmastery6502.blob.core.windows.net/mango/swPie.jpg", "Sweet Pie", 10.99 },
                    { 4, "Entree", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.", "https://dotnetmastery6502.blob.core.windows.net/mango/vegCurry.jpg", "Vegetable curry", 13.0 }
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
        }
    }
}
