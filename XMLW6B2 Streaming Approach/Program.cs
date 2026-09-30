using System.Xml;

namespace XMLW6B2_Streaming_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; 

            using (XmlWriter writer = XmlWriter.Create("output.xml", settings))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("Library");

                writer.WriteStartElement("Book");
                writer.WriteAttributeString("ISBN", "978-3-16-148410-0");

                writer.WriteElementString("Title", "The Great Gatsby");
                writer.WriteElementString("Author", "F. Scott Fitzgerald");

                writer.WriteEndElement(); // End Book element

                writer.WriteEndElement();// End Library element

                writer.WriteEndDocument();// End document
            }

            Console.WriteLine("XML file created successfully with streaming approach.");
        }
    }
}
