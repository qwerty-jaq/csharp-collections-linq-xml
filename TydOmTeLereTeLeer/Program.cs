using System.Runtime.InteropServices;
using System.Xml;

namespace TydOmTeLereTeLeer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement root = xmlDoc.CreateElement("TAH");
            xmlDoc.AppendChild(root);

            CreateDog(xmlDoc, root, "Muis", "X-Lab", "20");
            CreateDog(xmlDoc, root, "Jessie", "X-Rottie", "8");
            CreateDog(xmlDoc, root, "John", "Poodle", "10");

            xmlDoc.Save("TAH.xml");
            Console.WriteLine("XML file created successfully: TAH.xml");

            ReadAndCalculateAverage("TAH.xml");
        }

        static void CreateDog(XmlDocument xmlDoc, XmlElement root, string name, string breed, string weight)
        {
            XmlElement dog = xmlDoc.CreateElement("Dog");
           
            XmlElement nameElement = xmlDoc.CreateElement("Name");
            nameElement.InnerText = name;
            dog.AppendChild(nameElement);

            XmlElement breedElement = xmlDoc.CreateElement("Breed");
            breedElement.InnerText = breed;
            dog.AppendChild(breedElement);

            XmlElement weightElement = xmlDoc.CreateElement("Weight");
            weightElement.InnerText = weight;
            dog.AppendChild(weightElement);

            root.AppendChild(dog);
        }

        static void ReadAndCalculateAverage(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList weightNodes = xmlDoc.GetElementsByTagName("Weight");
            double totalWeight = 0;
            int count = 0;

            foreach (XmlNode node in weightNodes)
            {
                    totalWeight += double.Parse(node.InnerText);
                    count++;
                
            }

            double averageWeight = totalWeight / count;
            Console.WriteLine($"Average weight of dogs: {averageWeight} kg");
        }
    }
}
