using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace MockExam_Q3
{
    internal class DigitalArtCollectionManagement
    {
        static Dictionary<string, Art> catalog = new Dictionary<string, Art>();

        static void Main(string[] args)
        {



            //Menu loop
            bool running = true;
            while (running)
            {
                Console.WriteLine("- DIGITAL ART COLLECTIONS -");
                Console.WriteLine("------------------------------\n");

                menu();
                Thread.Sleep(1000);

                Console.Write("Select an option (1-4): \n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        addArt();
                        continue;
                    case "2":
                        listAll();
                        continue;
                    case "3":
                        filterByArtist();
                        continue;
                    case "4":
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("!!!Invalid option, please try again.\n");
                        continue;
                }


            }

        }

        static void menu()
        {
            Console.WriteLine("1 - Add Art");
            Console.WriteLine("2 - List All Art");
            Console.WriteLine("3 - Filter by Artist");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();

        }

        static void addArt()
        {
            //add art by art name and artists
            Console.WriteLine("- Adding Art\n");
            try
            {

                Console.WriteLine("Enter Art Title:");
                string title = Console.ReadLine();
                Console.WriteLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("!!!Art title cannot be empty.\n");
                    return;
                }

                Console.WriteLine("Enter Artist Name:");
                string artist = Console.ReadLine();
                Console.WriteLine();
                if (string.IsNullOrWhiteSpace(artist))
                {
                    Console.WriteLine("!!!Artist name cannot be empty.\n");
                    return;
                }

                catalog.Add(title, new Art(title, artist));
                Console.WriteLine($"Art '{title}' by '{artist}' added successfully.\n");
                return;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a valid integer for ID.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return;
            }
            Console.WriteLine();


        }

        static void listAll()
        {
            //list all art in the catalog
            Console.WriteLine("- List of All Art:\n");
            Console.WriteLine("-----------------------\n");
            if (catalog.Count == 0)
            {
                Console.WriteLine("!!!No art available in the catalog.\n");
                return;
            }
            foreach (var art in catalog.Values)
            {
                Console.WriteLine(art.ToString());
            }
            Console.WriteLine();

        }

        static void filterByArtist()
        {
            try
            {
                //filter art by artist id
                Console.WriteLine("- Filter by Artist:\n");
                Console.Write("Enter Artist Name:\n ");
                string artistName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(artistName))
                {
                    Console.WriteLine("!!!Artist name cannot be empty.\n");
                    return;
                }

                foreach (var artist in catalog.Values)
                {
                    if (artist.Artist.Equals(artistName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(artist.ToString());
                    }
                }

                if (catalog.Values.All(a => !a.Artist.Equals(artistName, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"!!!No art found for artist: {artistName}\n");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input format: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine();
        }
        public class Art
        {
            public string Title { get; set; }
            public string Artist { get; set; }

            public Art(string title, string artist)
            {
                Title = title;
                Artist = artist;
            }

            public override string ToString()
            {
                return $"Title: {Title}, Artist: {Artist}";
            }
        }


    }

}


