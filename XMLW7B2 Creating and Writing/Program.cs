using System.Xml;


namespace XMLW7B2_Creating_and_Writing
{
    internal class CreateStudentXml
    {
        static void Main(string[] args)
        {
            try
            {


                // Create a new XmlDocument
                XmlDocument studentInfo = new XmlDocument();

                // Create the root element <StudentInfo>
                XmlElement schoolElement = studentInfo.CreateElement("School");
                studentInfo.AppendChild(schoolElement);
            

                try
                {

                    for (int i = 1; i <= 3; i++)
                    {
                        // Create the <Student> element
                        XmlElement studentElement = studentInfo.CreateElement("Student");
                        studentElement.SetAttribute("ID", i.ToString());

                        //adding the name and age as well as the grade elements
                        XmlElement nameElement = studentInfo.CreateElement("Name");
                        nameElement.InnerText = $"Student {i}";
                        studentElement.AppendChild(nameElement);

                        XmlElement ageElement = studentInfo.CreateElement("Age");
                        ageElement.InnerText = (i + 10).ToString();
                        studentElement.AppendChild(ageElement);

                        XmlElement gradeElement = studentInfo.CreateElement("Grade");
                        gradeElement.InnerText = (i % 2 == 0) ? "A" : "B";
                        studentElement.AppendChild(gradeElement);


                        schoolElement.AppendChild(studentElement);
                    }
                    // Save the XML document to a file
                    studentInfo.Save("StudentInfo.xml");
                    Console.WriteLine($"{studentInfo} created successfully!");

                    //print the XML document to the console
                    Console.WriteLine(studentInfo.OuterXml);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the XML document: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("XML document creation process completed.");
            }
        }
    }
}
