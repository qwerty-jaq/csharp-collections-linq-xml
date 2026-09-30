namespace Queue_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enqueue 3 tickets, Dequeue 2, Display current queue.
            try
            {
                Queue<string> ticketQueue = new();

                ticketQueue.Enqueue("Ticket 1");
                ticketQueue.Enqueue("Ticket 2");
                ticketQueue.Enqueue("Ticket 3");

                Console.WriteLine("\n - Tickets in queue after enqueuing 3 tickets:");
                Console.WriteLine("------------------------------------------------------");
                foreach (var ticket in ticketQueue)
                {
                    Console.WriteLine(ticket);
                }

                //dequeue 2 tickets
                ticketQueue.Dequeue();
                ticketQueue.Dequeue();

                //Display the dequeued tickets
                Console.WriteLine("\n - Dequeued tickets:");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ticket 1 and Ticket 2 have been dequeued.");


                // Display current queue
                Console.WriteLine("\n - Tickets in queue after dequeuing 2 tickets:");
                Console.WriteLine("------------------------------------------------------");
                foreach (var ticket in ticketQueue)
                {
                    Console.WriteLine(ticket);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

        }
    }
}
