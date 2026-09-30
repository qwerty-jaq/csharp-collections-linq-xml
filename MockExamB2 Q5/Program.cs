using System.ComponentModel;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

namespace MockExamB2_Q5
{
    internal class XmlPatientCatalog
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                
                XmlElement rootElement = doc.CreateElement("PatientCatalog");
                doc.AppendChild(rootElement);

                rootElement.AppendChild(CreatePatientElement(doc, "PT201", "Emily Johnson", "Female", "34", "Asthma"));
                rootElement.AppendChild(CreatePatientElement(doc, "PT202", "Michael Smith", "Male", "47", "Diabetes Type 2"));
                rootElement.AppendChild(CreatePatientElement(doc, "PT203", "Sophia Brown", "Female", "29", "Anemia"));
                rootElement.AppendChild(CreatePatientElement(doc, "PT204", "James Wilson", "Male", "53", "Hypertension"));

                //Save the XML document to a file
                string filePath = "PatientCatalog.xml";
                doc.Save(filePath);
                Console.WriteLine($"Patient catalog saved to {filePath}");

                //Display the XML content to Notepad
                System.Diagnostics.Process.Start("notepad.exe", filePath);

            }
            catch (XmlException xmlEx)
            {
                Console.WriteLine($"XML Exception: {xmlEx.Message}");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"IO Exception: {ioEx.Message}");
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine($"Format Exception: {formatEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        //helper method
        static XmlElement CreatePatientElement(XmlDocument doc, string id, string name, string gender, string age, string diagnosis)
        {
            XmlElement patientElement = doc.CreateElement("Patient");
            patientElement.SetAttribute("ID", id);

            XmlElement nameElement = doc.CreateElement("Name");
            nameElement.InnerText = name;
            patientElement.AppendChild(nameElement);

            XmlElement genderElement = doc.CreateElement("Gender");
            genderElement.InnerText = gender;
            patientElement.AppendChild(genderElement);

            XmlElement ageElement = doc.CreateElement("Age");
            ageElement.InnerText = age;
            patientElement.AppendChild(ageElement);

            XmlElement diagnosisElement = doc.CreateElement("Diagnosis");
            diagnosisElement.InnerText = diagnosis;
            patientElement.AppendChild(diagnosisElement);

            return patientElement;
        }
    }
}
