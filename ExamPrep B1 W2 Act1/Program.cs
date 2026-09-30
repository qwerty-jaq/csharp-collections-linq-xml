namespace ExamPrep_B1_W2_Act1
{
    internal class MovieTicketSystem
    {
        static void Main(string[] args)
        {
            string genre;
            int tickets;
            double pricePerTicket = 0.0;
            double totalPrice = 0.0;

            Console.WriteLine("Welcome to the Movie Theatre:");
            Console.WriteLine("Available genres: Action, Comedy, Drama, Horror");
            Console.Write("Please select a genre: ");
            genre = Console.ReadLine()?.Trim().ToLowerInvariant();

                switch (genre)
                {
                    case "action":
                        pricePerTicket = 10.0;
                        break;
                    case "comedy":
                        pricePerTicket = 8.00;
                        break;
                    case "drama":
                        pricePerTicket = 7.00;
                        break;
                    case "horror":
                        pricePerTicket = 6.00;
                        break;
                    default:
                        Console.WriteLine("Invalid genre selected.");
                        return;
                }

                Console.Write("How many tickets would you like to purchase? ");
                if (!int.TryParse(Console.ReadLine(), out tickets) || tickets <= 0)
                {
                    Console.WriteLine("Invalid number of tickets.");
                    return;
                }
                totalPrice = pricePerTicket * tickets;
                Console.WriteLine($"You have selected {tickets} ticket(s) for the {genre} genre.");
                Console.WriteLine($"Total price: ${totalPrice:F2}");
                Console.WriteLine("Thank you for your purchase! Enjoy the movie!");
           

        }
    }
}
