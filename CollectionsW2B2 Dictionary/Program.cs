namespace CollectionsW2B2_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product<int>> products = new List<Product<int>>
            {
                new Product<int>(1, "Laptop", 10.99),
                new Product<int>(2, "Mouse", 20.99),
                new Product<int>(3, "Keyboard", 30.99)
            };

            Dictionary<int, int> Stock = new Dictionary<int, int>
            {
                { 1, 300 },
                { 2, 220 },
                { 3, 130 }
            };

            int totalStock = 0;

            foreach (var item in products)
            {
                int quantity = Stock[item.ProductID];
                Console.WriteLine($"{item.Name}, (ID: {item.ProductID}), - Price: R{item.Price:F2} - Stock: {quantity} ");
                totalStock += quantity;
            }
            Console.WriteLine($"\nTotal Item in stock {totalStock}");
        }
    }

    public class Product<T>
    {
        public T ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(T id, string name, double price)
        {
            ProductID = id;
            Name = name;
            Price = price;
        }
    }
}
