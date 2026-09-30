namespace CollectionsW3B2_Dictionary2
{
    internal class OnlineShoppingCart
    {
        static void Main(string[] args)
        {
            //strong item prices in a dictionary
            Dictionary<string, double> itemPrices = new Dictionary<string, double>
            {
                { "Apple", 12.99},
                { "Banana", 8.60 },
                { "Orange", 9.56 },
                { "Mango", 7.99 }
            };

            //strong item quantities in a dictionary
            Dictionary<string, int> itemQuantities = new Dictionary<string, int>
            {
                { "Apple", 10 },
                { "Banana", 20 },
                { "Orange", 15 },
                { "Mango", 5 }
            };

            //display the items and their prices
            Console.WriteLine("Items and their prices:");
            foreach (var item in itemPrices)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}\n");
            }
        }
    }
}
