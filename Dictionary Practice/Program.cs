namespace Dictionary_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> Products = new();

                Products.Add(1, "Apple");
                Products.Add(2, "Banana");
                Products.Add(3, "Cherry");

                //display the dictionary
                Console.WriteLine("Current List:");
                Console.WriteLine("--------------------------------------");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - Product ID: {product.Key}, Product Name: {product.Value}");
                }

                Console.WriteLine("--------------------------------------");
                //removing an item from the dictionary
                int productIdToRemove = 2; // ID of the product to remove
                if (Products.Remove(productIdToRemove))
                {
                    Console.WriteLine($"\n - Product with ID {productIdToRemove} has been removed.");
                }
                else
                {
                    Console.WriteLine($"Product with ID {productIdToRemove} not found.");
                }

                //using ContainsKey()
                int productIdToCheck = 3; // ID of the product to check
                if (Products.ContainsKey(productIdToCheck))
                {
                    Console.WriteLine($"\n - Product with ID {productIdToCheck} exists in the dictionary.");
                }
                else
                {
                    Console.WriteLine($"Product with ID {productIdToCheck} does not exist in the dictionary.");
                }

                //usng TryGetValue()
                int productIdToGet = 1; // ID of the product to get
                if (Products.TryGetValue(productIdToGet, out string productName))
                {
                    Console.WriteLine($"\n - Product with ID {productIdToGet} is {productName}.");
                }
                else
                {
                    Console.WriteLine($"Product with ID {productIdToGet} not found.");
                }

                //display the updated dictionary
                Console.WriteLine("\nUpdated Product List:");
                Console.WriteLine("---------------------------");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - Product ID: {product.Key}, Product Name: {product.Value}\n");
                }
            }
            catch (FormatException)
            {   Console.WriteLine("Invalid format. Please enter a valid number.");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("The specified key was not found in the dictionary.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}


