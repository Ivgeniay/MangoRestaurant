using Mando.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Mando.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Samosa",
                    Price = 15,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.",
                    ImageUrl = "https://dotnetmastery6502.blob.core.windows.net/mango/samosa.jpg",
                    CategoryName = "Snack"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    Name = "Kebab",
                    Price = 13.99,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.",
                    ImageUrl = "https://dotnetmastery6502.blob.core.windows.net/mango/kebab.jpg",
                    CategoryName = "Snack"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 3,
                    Name = "Sweet Pie",
                    Price = 10.99,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.",
                    ImageUrl = "https://dotnetmastery6502.blob.core.windows.net/mango/swPie.jpg",
                    CategoryName = "Dessert"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 4,
                    Name = "Vegetable curry",
                    Price = 13,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut bibendum mauris. Donec vel nulla ut lacus pulvinar volutpat malesuada eu velit. Vestibulum nibh mauris, sagittis eu mattis sit amet, consequat et felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus eu mauris eu sapien maximus pretium at id leo. Nullam augue metus, ullamcorper ut sodales vitae, ultrices et dolor. Sed sagittis leo eu nibh rhoncus maximus. Donec enim odio, tristique vel turpis nec, vulputate scelerisque neque.",
                    ImageUrl = "https://dotnetmastery6502.blob.core.windows.net/mango/vegCurry.jpg",
                    CategoryName = "Entree"
                });
        }
    }
}
