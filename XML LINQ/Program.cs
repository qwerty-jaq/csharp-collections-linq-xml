using System.Xml;
using System.Xml.Linq;

//Cars.xml with 3 cars elements wit (Make, model, year)

namespace XML_LINQ
{
    internal class CarsXML
    {
        static void Main(string[] args)
        {
            try
            {
                XDocument doc = new XDocument(
                    new XElement("Cars",
                        new XElement("Car",
                            new XElement("Make", "Toyota"),
                            new XElement("Model", "Camry"),
                            new XElement("Year", 2020)
                        ),
                        new XElement("Car",
                            new XElement("Make", "Honda"),
                            new XElement("Model", "Civic"),
                            new XElement("Year", 2019)
                        ),
                        new XElement("Car",
                            new XElement("Make", "Ford"),
                            new XElement("Model", "Focus"),
                            new XElement("Year", 2018)
                        )
                    )
                );

                // Save the XML document to a file
                string filePath = "Cars.xml";
                doc.Save("Cars.xml");

                //display to notepad
                System.Diagnostics.Process.Start("notepad.exe", filePath);
            }
            catch (XmlException xmlEx)
            {
                Console.WriteLine($"XML Exception: {xmlEx.Message}");
            }
            catch (System.IO.IOException ioEx)
            {
                Console.WriteLine($"IO Exception: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
