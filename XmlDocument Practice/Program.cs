using System.CodeDom.Compiler;
using System.Xml;
using System.Xml.Serialization;

//Create an XmlDocument  with 2 books  (Title, Author)

namespace XmlDocument_Practice
{
    internal class XmlLibraryPractice
    {
        static void Main(string[] args)
        {   
            try
            {
                Thread thread = new Thread(() =>
                {
                    XmlDocument document = new();

                    //root library element
                    XmlElement root = document.CreateElement("Library");
                    document.AppendChild(root);

                    //first book element
                    XmlElement book1 = document.CreateElement("Book");

                    //title and author element for the first book
                    XmlElement title1 = document.CreateElement("Title");
                    title1.InnerText = "The Great Gatsby";
                    book1.AppendChild(title1);
                    XmlElement author1 = document.CreateElement("Author");
                    author1.InnerText = "F. Scott Fitzgerald";
                    book1.AppendChild(author1);

                    //append the first book to the root
                    root.AppendChild(book1);

                    //second book element
                    XmlElement book2 = document.CreateElement("Book");

                    //title and author element for the second book
                    XmlElement title2 = document.CreateElement("Title");
                    title2.InnerText = "To Kill a Mockingbird";
                    book2.AppendChild(title2);
                    XmlElement author2 = document.CreateElement("Author");
                    author2.InnerText = "Harper Lee";
                    book2.AppendChild(author2);

                    //append the second book to the root
                    root.AppendChild(book2);
                })
              

                
                //save the document to a file   
                string filePath = "Library.xml";
                document.Save(filePath);
                    Console.WriteLine($"XML document saved to {filePath}");

                    // Optionally, you can display the XML content in Notepad
                    System.Diagnostics.Process.Start("notepad.exe", filePath);
               
               

            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"XML error occurred: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
