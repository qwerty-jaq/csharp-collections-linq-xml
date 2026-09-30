namespace ExamPrep_B1_W3_Act1
{
    internal class StudentEnrollmentSystem
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isValid = false;

            while (!isValid)
            {

                try
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());

                    if (age < 18)
                    {
                        throw new InvalidAgeException("You must be 18 years or older!");
                    }
                    else
                    {
                        Console.WriteLine("You are eligible to enroll in the course.");
                        isValid = true;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
}
