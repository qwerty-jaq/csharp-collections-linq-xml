using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Initial_Final_Exam_Q3
{
    internal class BookCatalogManagementSystem
    {
        //use a dictionary to store the books by specific  genre
        static Dictionary<string, Book> storedBooks = new Dictionary<string, Book>();


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("- Book Barn -");
                Console.WriteLine("----------------\n");
                Thread.Sleep(2000);

                bool running = true;
                while (running)
                {
                    menu();
                    Thread.Sleep(1000);
                    Console.WriteLine("Please select option (1-4): ");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        AddBook();
                        continue;
                    }
                    else if (input == "2")
                    {
                        ListAll();
                        continue;
                    }
                    else if (input == "3")
                    {
                        SearchBook();
                        continue;
                    }
                    else if (input == "4")
                    {
                        running = false;
                        Console.WriteLine("Exiting the system, Good Bye <3\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input...please try again");
                        continue;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //method to add books to the dictionary 
        static void AddBook()
        {
            Console.WriteLine("Enter the title of the book:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author's name:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the book genre:");
            string genre = Console.ReadLine();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                Console.WriteLine("Cannot be empty, please provide input!");
                return;
            }

            storedBooks.Add(title, new Book(author, genre, title));
            return;
        }

        //method to list all books
        static void ListAll()
        {
            foreach (var book in storedBooks.Values)
            {
                Console.WriteLine(book);
            }

        }

        //method to search book by genre
        static void SearchBook()
        {
            Console.WriteLine("Please provide book genre: ");
            string genreName = Console.ReadLine();
            if (string.IsNullOrEmpty(genreName))
            {
                Console.WriteLine("Genre name cannot be empty!!!\n");
                return;
            }

            //search book by genre
            foreach (var book in storedBooks.Values)
            {
                if (book.Genre.Equals(genreName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write(book.ToString());
                }
            }
        }
        
        static void menu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Add Book");
            Console.WriteLine("2 - List all books:");
            Console.WriteLine("3 - Search by genre: ");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();

        }
    }
    public class Book
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string genre, string title, string author)
        {
            Genre = genre;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
           return  $"Genre: {Genre}, Title: {Title}";
        }

    }
}


//fixed code after hitting the blank and failing in the test......
