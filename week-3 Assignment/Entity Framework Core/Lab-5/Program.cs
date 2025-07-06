using EFCore8RetailStoreLab4.Data;
using EFCore8RetailStoreLab4.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("EF Core Lab 4 + Lab 5: Insert and Retrieve Data");

await MainAsync();

async Task MainAsync()
{
    using var context = new AppDbContext();

    // LAB 4: Insert Initial Data
    Console.WriteLine("\n Inserting Initial Data...");

    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };
    var clothing = new Category { Name = "Clothing" };

    await context.Categories.AddRangeAsync(electronics, groceries, clothing);

    var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
    var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };
    var product3 = new Product { Name = "T-Shirt", Price = 500, Category = clothing };

    await context.Products.AddRangeAsync(product1, product2, product3);
    await context.SaveChangesAsync();

    Console.WriteLine("Initial Data Inserted Successfully!");

    // LAB 5: Retrieve Data
    Console.WriteLine("\nRetrieving Data From Database...");

    // Retrieve All Products
    var products = await context.Products.Include(p => p.Category).ToListAsync();
    Console.WriteLine("\nAll Products:");
    foreach (var p in products)
    {
        Console.WriteLine($"{p.Name} - {p.Price} ({p.Category.Name})");
    }

    // Find by ID
    var productById = await context.Products.FindAsync(1);
    if (productById != null)
        Console.WriteLine($"\nFound by ID 1: {productById.Name} - {productById.Price}");

    // FirstOrDefault with Condition
    var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
    if (expensive != null)
        Console.WriteLine($"\nFirst Expensive Product (>50,000): {expensive.Name} - {expensive.Price}");
}
