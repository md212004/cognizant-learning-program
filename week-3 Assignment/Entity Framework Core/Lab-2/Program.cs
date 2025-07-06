using EFCore8RetailStore.Data;
using EFCore8RetailStore.Models;
using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

// Insert Categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };
var clothing = new Category { Name = "Clothing" };

context.Categories.AddRange(electronics, groceries, clothing);
context.SaveChanges();
Console.WriteLine("Categories Added!");

// Insert Products
var productsToAdd = new List<Product>
{
    new Product { Name = "Smartphone", Price = 29999.99m, CategoryId = electronics.Id },
    new Product { Name = "Laptop", Price = 59999.99m, CategoryId = electronics.Id },
    new Product { Name = "Milk", Price = 45.50m, CategoryId = groceries.Id },
    new Product { Name = "Bread", Price = 30.00m, CategoryId = groceries.Id },
    new Product { Name = "T-Shirt", Price = 499.99m, CategoryId = clothing.Id },
    new Product { Name = "Jeans", Price = 1499.50m, CategoryId = clothing.Id }
};

context.Products.AddRange(productsToAdd);
context.SaveChanges();
Console.WriteLine("Products Added!");

// Display all Products
var allProducts = context.Products.Include(p => p.Category).ToList();
Console.WriteLine("\nProducts in Database:");
foreach (var p in allProducts)
{
    Console.WriteLine($"{p.Id}: {p.Name} -RS{p.Price} ({p.Category.Name})");
}
