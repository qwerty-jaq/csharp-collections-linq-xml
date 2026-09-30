namespace ExamPrep_B1_W7_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\janco\OneDrive\Documents\example.txt";
            
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Odd-Numbered Lines:");
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 == 0) // 0-based index, so even index means odd-numbered line
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }   

        }
    }
}
