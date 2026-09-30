namespace Initial_Final_Exam_Q2
{
    internal class EcommerceCatalog
    {
        static void Main(string[] args)
        {
            try
            {
                //create a list of 5 products, with randomly generated prices within realistic ranges
                Random random = new Random();

                List<Product> products = new List<Product>
            {
                new Product("Laptop", (decimal)(random.Next(5000, 30001) + random.NextDouble())),
                new Product("Smartphone", (decimal)(random.Next(500, 10001) + random.NextDouble())),
                new Product("Tablet", (decimal)(random.Next(1000, 10001) + random.NextDouble())),
                new Product("Smartwatch", (decimal)(random.Next(2000, 20001) + random.NextDouble())),
                new Product("Headphones", (decimal)(random.Next(50, 5001) + random.NextDouble()))
            };

                //use LINQ to sort the list by price in ascending order
                var sortedProducts = products.OrderBy(p => p.Price).ToList();

                //display the sorted list of products
                Console.WriteLine("Products sorted by price (ascending):");
                Console.WriteLine("----------------------------------------\n");
                foreach (var product in sortedProducts)
                {
                    Console.WriteLine(product);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
