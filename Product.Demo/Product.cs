using Microsoft.EntityFrameworkCore;
using System;

namespace Product.Demo
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
    public class MyContext : DbContext
    {
        public object shops;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DigiKalaShop;Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
