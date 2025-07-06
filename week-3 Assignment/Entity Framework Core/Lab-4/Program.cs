using System;
using System.Threading.Tasks;
using EFCore8RetailStoreLab4.Data;
using EFCore8RetailStoreLab4.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // Insert initial categories
        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        // Insert initial products
        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);

        await context.SaveChangesAsync();
        Console.WriteLine("Initial data inserted successfully.");

        // Display products
        var products = await context.Products.Include(p => p.Category).ToListAsync();
        Console.WriteLine("\nProducts in the database:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id}: {product.Name} - ₹{product.Price} ({product.Category.Name})");
        }
    }
}
