using System.Xml;
using System.Xml.Linq;

//load Cars.Xml and read all cars after 2020 using LINQ to XML

namespace XML_read_with_LINQ
{
    internal class CarsXML
    {
        static void Main(string[] args)
        {
            try
            {
                XDocument doc = XDocument.Load("Cars.xml");
                var carsAfter2020 = from car in doc.Descendants("Car")
                                    where (int)car.Element("Year") > 2020
                                    select new
                                    {
                                        Make = car.Element("Make")?.Value,
                                        Model = car.Element("Model")?.Value,
                                        Year = (int)car.Element("Year")
                                    };

                Console.WriteLine("Cars after 2020:");
                foreach (var car in carsAfter2020)
                {
                    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"XML Exception: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }
    }
}
