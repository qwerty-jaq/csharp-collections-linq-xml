namespace MockExamB2_Q1._2
{
    
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    public class Student
    {
        public string Name { get; set; } = "Janco";
        public int Age { get; set; } = 20;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
        
    

    public class ReferenceHandler<T> where T : class
    {
        public void ShowType()
        {
            Console.WriteLine($"Type Handled: {typeof(T).Name}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                // Create a factory for Student instances
                Factory<Student> studentFactory = new Factory<Student>();
                Student student = studentFactory.CreateInstance();
                student.PrintInfo(); // Output: Name: Janco, Age: 20
                                     // Create a reference handler for Student type
                ReferenceHandler<Student> studentHandler = new ReferenceHandler<Student>();
                studentHandler.ShowType(); // Output: Type Handled: Student
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
