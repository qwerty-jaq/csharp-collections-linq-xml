using System.Collections.Concurrent;
using System.Numerics;

namespace LINQweekActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 1200.00m, "Electronics", 50),
                new Product("Smartphone", 800.00m, "Electronics", 150),
                new Product("Tablet", 300.00m, "Electronics", 100),
                new Product("Headphones", 150.00m, "Accessories", 200),
                new Product("Smartwatch", 250.00m, "Accessories", 80)
            };

            var categoryStats = from p in products
                                group p by p.Category into categoryGroup
                                select new
                                {
                                    Category = categoryGroup.Key,
                                    TotalSales = categoryGroup.Sum(p => p.Price * p.QuantitySold),
                                    MostExpensiveProduct = categoryGroup.OrderByDescending(p => p.Price).FirstOrDefault(),
                                    TotalQuantitySold = categoryGroup.Sum(p => p.QuantitySold)
                                };

            foreach (var category in categoryStats)
            {
                Console.WriteLine($"Category: {category.Category}");
                Console.WriteLine($"Total Sales: {category.TotalSales:C}");
                if (category.MostExpensiveProduct != null)
                {
                    Console.WriteLine($"Most Expensive Product: {category.MostExpensiveProduct.ProductName} - {category.MostExpensiveProduct.Price:C}");
                }
                Console.WriteLine($"Total Quantity Sold: {category.TotalQuantitySold}");
                Console.WriteLine();
            }

        }

        
    }

    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int QuantitySold { get; set; }

        public Product(string name, decimal price, string category, int quantity)
        {
            ProductName = name;
            Price = price;
            Category = category;
            QuantitySold = quantity;
        }
    }
}
