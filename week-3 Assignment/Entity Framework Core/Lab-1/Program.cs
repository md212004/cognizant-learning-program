using EFCore8Assignment.Data;
using EFCore8Assignment.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();

        // Insert a Category
        var category = new Category { Name = "Electronics" };
        context.Categories.Add(category);
        context.SaveChanges();
        Console.WriteLine("Category Added!");

        // Insert a Product
        var product = new Product
        {
            Name = "Smartphone",
            Price = 29999.99m,
            CategoryId = category.Id
        };
        context.Products.Add(product);
        context.SaveChanges();
        Console.WriteLine("Product Added!");

        // Read all Products
        var products = context.Products.Include(p => p.Category).ToList();
        Console.WriteLine("\nProducts in Database:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id}: {p.Name} - ₹{p.Price} ({p.Category.Name})");
        }
    }
}
