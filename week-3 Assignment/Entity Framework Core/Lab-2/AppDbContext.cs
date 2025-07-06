using Microsoft.EntityFrameworkCore;
using EFCore8RetailStore.Models;

namespace EFCore8RetailStore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JAI;Database=RetailStoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
