using System;
using System.Threading.Tasks;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlElement Root = xmlDoc.CreateElement("TAH");
        xmlDoc.AppendChild(Root);
        //Dog 1
        XmlElement DogsElement = xmlDoc.CreateElement("Dogs");
        Root.AppendChild(DogsElement);
       
        XmlElement nameElement = xmlDoc.CreateElement("Name");
        nameElement.InnerText = "Muis";
        DogsElement.AppendChild(nameElement);

            XmlElement BreedElement = xmlDoc.CreateElement("Breed");
        BreedElement.InnerText = "X-Lab";
        DogsElement.AppendChild(BreedElement);
           

            XmlElement WeightElement = xmlDoc.CreateElement("Weight");
        WeightElement.InnerText = "20";
        DogsElement.AppendChild(WeightElement);




        //Dog 2
        DogsElement = xmlDoc.CreateElement("Dogs");
        Root.AppendChild(DogsElement);
     
        nameElement.InnerText = "Jessie";
            DogsElement.AppendChild(nameElement);

            BreedElement.InnerText = "X-Rottie";
            DogsElement.AppendChild(BreedElement);

            WeightElement.InnerText = "8";

            DogsElement.AppendChild(WeightElement);



        //Dog 3
        DogsElement = xmlDoc.CreateElement("Dogs");
        Root.AppendChild(DogsElement);
       

        nameElement.InnerText = "John";
            DogsElement.AppendChild(nameElement);

            BreedElement.InnerText = "Poodle";
            DogsElement.AppendChild (BreedElement);

            WeightElement.InnerText = "10";
            DogsElement.AppendChild (WeightElement);

        xmlDoc.Save("Dogs.xml");
        Console.WriteLine("SAved");
    }
}
