namespace CollectionsW2B2
{
    internal class StudentGardeManagementSystem
    {
        static void Main(string[] args)
        {
            List<Student<int>> students = new List<Student<int>>
            {
                new Student<int>(1, "Alice"),
                new Student<int>(2, "Bob"),
                new Student<int>(3, "Charlie")
            };

            Dictionary<int, double> grades = new Dictionary<int, double>
            {
                { 1, 85.2 },
                { 2, 92.9 },
                { 3, 67.5 }
            };

            double total = 0;
            foreach (var student in students)
            {
               double grade = grades[student.ID];
                Console.WriteLine($"{student.Name} (ID : {student.ID} - Grade : {grade} ");
                total += grade;
            }

            double averageGrade = total / students.Count;
            Console.WriteLine($"\nAverage Garde: {averageGrade:F2}");
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
