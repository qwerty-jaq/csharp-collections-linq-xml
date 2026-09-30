namespace ExamPrep_B1_W5_ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            /*int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            Console.WriteLine("Array elements are:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }*/

            //Question 2:
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];

            Console.WriteLine("Enter elements for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine(areEqual ? "The arrays are equal." : "The arrays are not equal.");

        }
    }
}
