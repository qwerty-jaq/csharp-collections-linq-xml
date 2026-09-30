using System.Xml.Linq;

namespace XMLW7B2_LINQ_to_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var contact = new[]
                {
                new {Name = "Janco", Phone = "123-456-789", Email = "janco@gmail.com"},
                new {Name = "Pieter", Phone = "987-654-321", Email = "piete@outlook.com"},
                new {Name = "Jan", Phone = "456-789-123", Email = "jan@gmail.com" }
            };

                XDocument doc = new XDocument(
                    new XElement("Contacts",
                        from c in contact
                        select new XElement("Contact",
                            new XElement("Name", c.Name),
                            new XElement("Phone", c.Phone),
                            new XElement("Email", c.Email)

                        )
                    )
                );

                doc.Save("Contacts.xml");
                Console.WriteLine("Document created successfully!\n");

                // Load the XML document in console
                Console.WriteLine(doc.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }


        }
    }
}
