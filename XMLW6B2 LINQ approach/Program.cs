using System.Xml;
using System.Xml.Linq;

namespace XMLW6B2_LINQ_approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument(
                new XElement("Books",
                    new XElement("Book",
                        new XElement("Title", "C# Programming"),
                        new XElement("Author", "John Doe"),
                        new XElement("Year", "2023")
                    ),
                    new XElement("Book",
                        new XElement("Title", "Learning LINQ"),
                        new XElement("Author", "Jane Smith"),
                        new XElement("Year", "2022")
                    )
                )
            );
            xdoc.Save("Books.xml");
            Console.WriteLine("Xml created successfully.");
        }
    }
}
