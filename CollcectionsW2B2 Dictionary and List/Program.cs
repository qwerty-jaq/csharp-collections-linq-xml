namespace CollcectionsW2B2_Dictionary_and_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample
            List<Student<int>> students = new List<Student<int>>
            {
                new Student<int>(1, "Alice"),
                new Student<int>(2, "Bob"),
                new Student<int>(3, "Charlie")
            };

            Dictionary<int, List<string>> burrowedBooks = new Dictionary<int, List<string>>
            {
                { 1, new List<string> { "C# YKYK", "FSoG" } },
                { 2, new List<string> { "Bible" } },
                { 3, new List<string> { "Software Engineering", "CyberSecurity", "SUDOKU" } }
            };

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name} with (ID: {student.ID}) has borrowed:");

                foreach (var book in burrowedBooks[student.ID] )
                {
                    Console.WriteLine($"  - {book}");
                }
                Console.WriteLine();
            }    
        }
    }

    public class Student<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
        public Student(T id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
