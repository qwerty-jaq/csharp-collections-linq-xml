namespace CollectionsW3B2_DIctionary_and_Lists
{
    internal class StudentGradesTracker
    {
        static void Main(string[] args)
        {
            //using a dictionary and list to map students and their grades
            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>()
            {
                { "Alice", new List<int> { 85, 90, 78 } },
                { "Bob", new List<int> { 92, 88, 95 } },
                { "Charlie", new List<int> { 70, 75, 80 } }
            };

            //printing the average gra of each student
            foreach (var student in studentGrades)
            {
                string name = student.Key;
                List<int> grades = student.Value;
                double average = grades.Average();
                Console.WriteLine($"{name}'s average grade: {average:F2}%\n");
            }
        }
    }
}
