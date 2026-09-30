using System.Xml;

namespace XMLW6B2_DOM_approach
{
    class CreateXmlwithXmlDocument
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a new XML document instance
                XmlDocument doc = new XmlDocument();


                // Create the root element
                XmlElement root = doc.CreateElement("Library");
                doc.AppendChild(root);

                // Create a book element
                XmlElement book = doc.CreateElement("Book");
                doc.AppendChild(book);

                //adding attributes to the book element
                XmlAttribute bookID = doc.CreateAttribute("ID");
                bookID.Value = "1";
                book.SetAttributeNode(bookID);

                //create child elements: title, author.
                XmlElement title = doc.CreateElement("Title");
                title.InnerText = "The Great Gatsby";
                book.AppendChild(title);

                XmlElement author = doc.CreateElement("Author");
                author.InnerText = "F. Scott Fitzgerald";
                book.AppendChild(author);

                //save the XML document to a file
                doc.Save("Library.xml");
                Console.WriteLine("XML file created!");
            }
            catch (XmlException xmlEx)
            {
                Console.WriteLine("XML Exception: " + xmlEx.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine("Access denied: " + uaEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("IO Exception: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
         
        }
    }
}
