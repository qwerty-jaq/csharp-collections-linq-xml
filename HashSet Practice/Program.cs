using System.Collections.Generic;

namespace HashSet_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add 5 email addresses to a HashSet.Prevent duplicates.
            try
            {


                HashSet<string> emailAddresses = new HashSet<string>();

                

                emailAddresses.Add("jason@example.com");
                emailAddresses.Add("mememe@gmail.com");
                emailAddresses.Add("lana@sexy.net");
                emailAddresses.Add("janco@outlook.com");
                emailAddresses.Add("jake@snake.co.za");

                //Try to add a duplicate email address
                bool added = emailAddresses.Add("lana@sexy.net");
                if (!added)
                {
                    Console.WriteLine("Duplicate email address not added!!!!\n");
                }

                //display the email addresses
                Console.WriteLine("Email Addresses in HashSet:");
                Console.WriteLine("---------------------------------");
                foreach (string email in emailAddresses)
                {
                    Console.WriteLine(email);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");


            }
        }
    }
}
