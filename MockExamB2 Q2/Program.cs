using System.Globalization;

namespace MockExamB2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<StudentEnrollment> enrollments = new HashSet<StudentEnrollment>();
                enrollments.Add(new StudentEnrollment("Alice", "Math"));
                enrollments.Add(new StudentEnrollment("Bob", "Science"));
                enrollments.Add(new StudentEnrollment("Alice", "History"));
                enrollments.Add(new StudentEnrollment("David", "Math"));
                enrollments.Add(new StudentEnrollment("Alice", "Math"));

                Console.WriteLine("- Unique Student Enrollments:");
                Console.WriteLine("--------------------------------\n");
                Thread.Sleep(1000);

                //display the enrollments
                foreach (var enrollment in enrollments)
                {
                    Console.WriteLine($"- Student: {enrollment.studentName} enrolled for course: {enrollment.studentCourse}\n");
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n- End of program execution.\n");
                Thread.Sleep(1000);

            }
    }

    public class StudentEnrollment
    {
        public String studentName { get; set; }
        public string studentCourse { get; set; }

        public StudentEnrollment(string studentName, string studentCourse)
        {
            this.studentName = studentName;
            this.studentCourse = studentCourse;
        }

        public override bool Equals(object? obj)
        {
            if (obj is StudentEnrollment other)
            {
                return this.studentName == other.studentName && this.studentCourse == other.studentCourse;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(studentName, studentCourse);
        }
    }
}
