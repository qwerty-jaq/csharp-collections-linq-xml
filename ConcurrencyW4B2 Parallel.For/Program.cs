namespace ConcurrencyW4B2_Parallel.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            Parallel.For(0, numbers.Length, i =>
            {
                ProcessData(numbers[i]);
            });

            Console.WriteLine("All numbers processed.");
        }

        static void ProcessData(int number)
        {
            double result = Math.Pow(number, 2);
            Console.WriteLine($"Processing number {number}: {result}\n");
        }
    }
}
