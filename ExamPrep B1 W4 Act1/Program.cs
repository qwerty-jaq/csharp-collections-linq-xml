using System.Numerics;

namespace ExamPrep_B1_W4_Act1
{
    public class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productId { get; set; }
        public Product(string name, double price, int id)
        {
            productName = name;
            productPrice = price;
            productId = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product ID: {productId}, Name: {productName}, Price: {productPrice:C}");
        }

        public virtual double TotalPrice()
        {
            return productPrice;
        }
    }

    public class Electronics : Product
    {
        public string warrantyPeriod { get; set; }
        public Electronics(string name, double price, int id, string warranty)
            : base(name, price, id)
        {
            this.warrantyPeriod = warranty; 
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Warranty Period: {warrantyPeriod}");
        }

        public override double TotalPrice()
        {
            double tax = 0.15;
            return productPrice + (productPrice * tax);
        }
    }

    public class Clothing : Product
    {
        public string size { get; set; }
        public Clothing(string name, double price, int id, string size)
            : base(name, price, id)
        {
            this.size = size;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Size: {size}");
        }

        public override double TotalPrice()
        {
            double tax = 0.80;
            return productPrice + (productPrice * tax);
        }
    }
    
    internal class InventoryManager
    {
        
        static void Main(string[] args)
        {
            Product product1 = new Electronics("Laptop", 1500.00, 101, "2 years");
            Product product2 = new Clothing("T-Shirt", 20.00, 102, "M");

            Console.WriteLine("Product Information:");
            product1.DisplayInfo();
            Console.WriteLine($"Total Price (with tax): {product1.TotalPrice():C}\n");

            Console.WriteLine("Product Information:");
            product2.DisplayInfo();
            Console.WriteLine($"Total Price (with tax): {product2.TotalPrice():C}\n");

        }
    }
}
