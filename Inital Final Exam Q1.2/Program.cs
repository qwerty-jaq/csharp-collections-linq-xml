namespace Inital_Final_Exam_Q1._2
{
    internal class Program
    {
        //write a generic method named Swap takes two parameter by reference and swaps their values.
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }

        static void Main(string[] args)
        {
            try
            {
                //call the Swap method with two strings
                string x = "Trudie", y = "Lotz"; //sample string inputs
                Console.WriteLine($"Before Swap: {x}, {y}");
                Swap(ref x, ref y);
                Console.WriteLine("----------------------\n");

                //after calling the Swap method, print the values of x and y
                Console.WriteLine($"After Swap: {x}, {y}");
                Console.WriteLine("----------------------\n");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument null error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
