namespace ConcurrencyW4B2_Parallel_Data_Aggression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 10000).ToArray();

            int totalSum = numbers.AsParallel().Sum();

            Console.WriteLine($"Total Sum: {totalSum}");
        }
    }
}
