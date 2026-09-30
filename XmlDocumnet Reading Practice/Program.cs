using System.Xml;

//reading the library.xml document

namespace XmlDocument_Reading_Practice
{
    internal class XmlLibraryPractice
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\Users\janco\OneDrive\Documents\Exam Preperation B2 (C#)\XmlDocument Practice\Library.xml";// Ensure this file exists in the same directory as the executable
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // read and print all book titles and authors 
                XmlNodeList book1Nodes = xmlDoc.SelectNodes("/Library/Book");
                foreach (XmlNode book1Node in book1Nodes)
                {
                    string title1 = book1Node.SelectSingleNode("Title")?.InnerText;
                    string author1 = book1Node.SelectSingleNode("Author")?.InnerText;
                    if (title1 != null && author1 != null)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"First Book - Title: {title1}, Author: {author1}\n");
                    }
                    else
                    {
                        Console.WriteLine("First Book's information is incomplete.");
                    }
                }

                // read and print all book titles and authors from the second book
                XmlNodeList book2Nodes = xmlDoc.SelectNodes("/Library/Book");
                foreach (XmlNode book2Node in book2Nodes)
                {
                    string title2 = book2Node.SelectSingleNode("Title")?.InnerText;
                    string author2 = book2Node.SelectSingleNode("Author")?.InnerText;
                    if (title2 != null && author2 != null)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"Second Book - Title: {title2}, Author: {author2}\n");
                    }
                    else
                    {
                        Console.WriteLine("Second Book's information is incomplete.");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: The file was not found. {ex.Message}");
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"Error: There was a problem with the XML format. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine();

        }
    }
}
