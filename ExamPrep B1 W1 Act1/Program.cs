namespace ExamPrep_B1_W1_Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Banking Application!");
            bool running = true;
            while (running)
            {
                
                ShowMenu();
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CheckBalance(1000.00m); // Example balance
                        break;
                    case "2":
                        decimal balance = DepositFunds(1000.00m); // Example balance
                        break;
                    case "3":
                        balance = WithdrawFunds(1000.00m); // Example balance
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {

            Thread.Sleep(1000);
            Console.WriteLine("\nBanking Options:");
            Console.WriteLine("1 - Check Account Balance");
            Console.WriteLine("2 - Deposit Funds");
            Console.WriteLine("3 - Withdraw Funds");
            Console.WriteLine("4 - Exit");
        }

        static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        static decimal DepositFunds(decimal balance)
        {
            Console.Write("Enter amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"Successfully deposited {depositAmount:C}. New balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please try again.");
            }
            return balance;
        }

        static decimal WithdrawFunds(decimal balance)
        {
            Console.Write("Enter amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0 && withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"Successfully withdrew {withdrawAmount:C}. New balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please try again.");
            }
            return balance;
        }
    }
}
