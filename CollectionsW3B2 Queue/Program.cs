namespace CollectionsW3B2_Queue
{
    internal class CallCenterQueue
    {
        static void Main(string[] args)
        {
            Queue<string>  callQueue = new Queue<string>();
             
            callQueue.Enqueue("Alice");
            callQueue.Enqueue("Bob");
            callQueue.Enqueue("Charlie");


            Thread.Sleep(2000); // Simulate a delay before serving the next call
            Console.WriteLine($"Now serving: {callQueue.Dequeue()} \n");

            Thread.Sleep(2000); // Simulate a delay before serving the next call    
            Console.WriteLine("Current Call Queue:");
            foreach (var caller in callQueue)
            {
                Console.WriteLine(caller);
            }

        }
    }
}
