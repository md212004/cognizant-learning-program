using Microsoft.EntityFrameworkCore;
using EFCore8RetailStoreLab4.Models;


namespace EFCore8RetailStoreLab4.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=JAI;Database=RetailStoreDB_Lab4;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
