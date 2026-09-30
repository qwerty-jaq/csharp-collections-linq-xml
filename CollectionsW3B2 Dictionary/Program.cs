using System.Runtime.CompilerServices;

namespace CollectionsW3B2_Dictionary
{
    internal class StudentRecordManagementSystem
    {
        static void Main(string[] args)
        {
            Dictionary<int, Tuple<string, double>> studentRecords = new Dictionary<int, Tuple<string, double>>();

            // Adding student records
            studentRecords.Add(1, new Tuple<string, double>("Alice", 85.5));
            studentRecords.Add(2, new Tuple<string, double>("Bob", 92.0));
            studentRecords.Add(3, new Tuple<string, double>("Charlie", 78.0));

            // Displaying all student records
            Console.WriteLine("All Student Records:\n");

            foreach (var record in studentRecords)
            {
                int id = record.Key;
                var details = record.Value;
                Console.WriteLine($"ID: {id}, Name: {details.Item1}, Score: {details.Item2}\n");
            }
            Thread.Sleep(4000); // Simulating a delay for better readability

            //removing a student by id
            int removeStudentID = 2;
            if (studentRecords.ContainsKey(removeStudentID))
            {
                studentRecords.Remove(removeStudentID);
                Console.WriteLine($"Removed student with ID: {removeStudentID}\n");
            }
            else
            {
                Console.WriteLine($"No student found with ID: {removeStudentID}\n");
            }

            Thread.Sleep(4000); // Simulating a delay for better readability

            //retrieving and displaying student records
            Console.WriteLine("Student Records:");
            foreach (var record in studentRecords)
            {
                int id = record.Key;
                var details = record.Value;
                Console.WriteLine($"ID: {id}, Name: {details.Item1}, Score: {details.Item2}\n");
            }

            Thread.Sleep(4000); // Simulating a delay for better readability
            //retrieving a student with grade >80
            Console.WriteLine("Students with scores greater than 80:\n");
            Thread.Sleep(4000); // Simulating a delay for better readability
            foreach (var record in studentRecords)
            {
                if (record.Value.Item2 > 80)
                {
                    Console.WriteLine($"ID: {record.Key}, Name: {record.Value.Item1}, Score: {record.Value.Item2}");
                }
            }
        }
    }

}

