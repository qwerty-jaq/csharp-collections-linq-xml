namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please provide size of array:");
                int input = int.Parse(Console.ReadLine()!);

                int[] numArr = new int[input];
                for (int i = 0; i < numArr.Length; i++)
                {
                    Console.WriteLine($"Please provide number {i}:");
                    input = int.Parse(Console.ReadLine()!);
                    numArr[i] = input;
                }

                // Display the array elements
                Console.WriteLine("You have entered the following numbers:");
                for (int i = 0; i < numArr.Length; i++)
                {
                    Console.WriteLine($"Number {i + 1}: {numArr[i]}");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number is too large or too small.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended. Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
