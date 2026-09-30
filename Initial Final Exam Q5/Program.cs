using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

//create xml file = Students.Xml
//root element <School>
//add 5 student elements inside school  with attributes (Id) and child elements  (name, age, gender, grade)
//use loop to create students  dynamically (helper<T>)
//save xml to projects root directory
//display confirmation message 
//error handling




namespace Initial_Final_Exam_Q5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            try {
                //create the document and loop for the 5 students
                XmlDocument studentDoc = new XmlDocument();

                XmlElement root = studentDoc.CreateElement("School");
                studentDoc.AppendChild(root);

                //ask how many student to loop and add


                //sample adding
                root.AppendChild(CreateStudentHelper(studentDoc, "001", "Janco Queiroz", "21", "Male", "12"));
                root.AppendChild(CreateStudentHelper(studentDoc, "002", "Trudee Lotz", "23", "Female", "99"));
                root.AppendChild(CreateStudentHelper(studentDoc, "003", "Lana Katzur", "19", "Female", "85"));
                root.AppendChild(CreateStudentHelper(studentDoc, "004", "Mark Olles", "25", "Male", "77"));
                root.AppendChild(CreateStudentHelper(studentDoc, "005", "Mike Feely", "22", "Male", "62"));
                root.AppendChild(CreateStudentHelper(studentDoc, "006", "Gina Olles", "20", "Female", "53"));


                //save the document
                string filePath = "Student.xml";
                studentDoc.Save(filePath);
                Console.WriteLine($"File {filePath} created successfully!\n");

                //show in console
                Console.WriteLine(OuterXml. s
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error with format: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        //helper<T> method for adding students dynamically
        static XmlElement CreateStudentHelper(XmlDocument studentDoc, string id, string name, string age, string gender, string grade)
        {
           
                //add student element with attributes and child elements
                XmlElement studentElement = studentDoc.CreateElement("Student");
                studentElement.SetAttribute("ID", id);

                XmlElement studentName = studentDoc.CreateElement("Name");
                studentName.InnerText = name;
                studentElement.AppendChild(studentName);

                XmlElement studentAge = studentDoc.CreateElement("Age");
                studentAge.InnerText = age;
                studentElement.AppendChild(studentAge);

                XmlElement studentGender = studentDoc.CreateElement("Gender");
                studentGender.InnerText = gender;
                studentElement.AppendChild(studentGender);

                XmlElement studentGrade = studentDoc.CreateElement("Grade");
                studentGrade.InnerText = grade;
                studentElement.AppendChild(studentGrade);

                return studentElement;
        }
    }
}
