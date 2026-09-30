namespace ConcurrencyW4B2_Threads
{
    internal class AsynchronousFileDownloading
    {
       static async Task Main(string[] args)
        {
            Console.WriteLine("Starting file download...");
            // Simulate an asynchronous file download
            await Task.Delay(3000); // Simulating a 3-second download
            Console.WriteLine("File downloaded successfully!");
        }

        static async Task DownloadFileAsync(string url)
        {
            // Simulate an asynchronous file download
            await Task.Delay(3000); // Simulating a 3-second download
            Console.WriteLine($"File from {url} downloaded successfully!");
        }
    }
}
