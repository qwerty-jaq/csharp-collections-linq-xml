namespace List_Practice
{
    internal class StudentRecords
    {
        static void Main(string[] args)
        {
            try
            {
                List<Student> students = new();

                //sample adding students to the list
                students.Add(new Student("Alice", 20, 90));
                students.Add(new Student("Bob", 22, 85));
                students.Add(new Student("Charlie", 21, 88));

                //displaying all students
                Console.WriteLine("- Student Records:");
                Console.WriteLine("---------------------\n");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
                Thread.Sleep(2000);

                //removing a student
                Console.WriteLine("\n!!!Removing Bob from the records... ");
                students.RemoveAll(s => s.Name == "Bob");
                Thread.Sleep(4000);

                //update a student's grade
                Console.WriteLine("\n!!!Updating Alice's grade... ");
                var alice = students.FirstOrDefault(s => s.Name == "Alice");
                if (alice != null)
                {
                    alice.Grade = 95;
                }
                Thread.Sleep(4000);

                //displaying all students after removal and update
                Console.WriteLine("\nUpdated Student Records:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid format encountered. " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: A null argument was passed. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }

        }

    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name} - Age: {Age}, Grade: {Grade}";
        }
    }
}
