// ==========================
// Assignment: E-commerce Platform Search Function
// Pattern: Linear vs Binary Search with Runtime Comparison
// ==========================

using System;
using System.Diagnostics;

namespace ECommerceSearch
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        // Linear search: O(n)
        static Product? LinearSearch(Product[] products, int id)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                    return product;
            }
            return null;
        }

        // Binary search: O(log n)
        static Product? BinarySearch(Product[] products, int id)
        {
            int left = 0, right = products.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == id)
                    return products[mid];
                else if (products[mid].ProductId < id)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }

        static void Main(string[] args)
        {
            // Sample product data
            Product[] products = new Product[]
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "T-Shirt", "Fashion"),
                new Product(103, "Coffee Mug", "Kitchen"),
                new Product(104, "Headphones", "Electronics"),
                new Product(105, "Notebook", "Stationery"),
                new Product(106, "Smartphone", "Electronics"),
                new Product(107, "Running Shoes", "Footwear"),
                new Product(108, "Wrist Watch", "Accessories"),
                new Product(109, "Backpack", "Bags"),
                new Product(110, "Book", "Books")
            };

            // Sort products by ProductId for binary search
            Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

            Console.WriteLine("Enter Product ID to search:");
            int searchId = Convert.ToInt32(Console.ReadLine());

            // Linear Search with timing
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            Product? result1 = LinearSearch(products, searchId);
            stopwatch1.Stop();

            Console.WriteLine("\n--- Linear Search ---");
            if (result1 != null)
                Console.WriteLine($"Found: {result1.ProductName} in {result1.Category}");
            else
                Console.WriteLine("Product not found");
            Console.WriteLine($"Time taken: {stopwatch1.Elapsed.TotalMilliseconds} ms");

            // Binary Search with timing
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            Product? result2 = BinarySearch(products, searchId);
            stopwatch2.Stop();

            Console.WriteLine("\n--- Binary Search ---");
            if (result2 != null)
                Console.WriteLine($"Found: {result2.ProductName} in {result2.Category}");
            else
                Console.WriteLine("Product not found");
            Console.WriteLine($"Time taken: {stopwatch2.Elapsed.TotalMilliseconds} ms");

            // Summary
            Console.WriteLine("\n--- Analysis ---");
            Console.WriteLine("Linear Search: O(n) - Simple but slower for large data.");
            Console.WriteLine("Binary Search: O(log n) - Faster but needs sorted data.");
        }
    }
}
