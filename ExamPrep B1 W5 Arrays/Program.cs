namespace ExamPrep_B1_W5_Arrays
{
    using System;

    class ArrayPractice
    {
        static void Main()
        {
            Console.WriteLine("=== C# ARRAYS COMPLETE GUIDE ===\n");

            // Call each demonstration method
            SingleDimensionalArrays();
            MultiDimensionalArrays();
            JaggedArrays();
            PracticeExercises();
        }

        // ==================== SINGLE DIMENSIONAL ARRAYS ====================
        static void SingleDimensionalArrays()
        {
            Console.WriteLine("1. SINGLE DIMENSIONAL ARRAYS");
            Console.WriteLine("================================");

            // Method 1: Declare and initialize with size
            int[] numbers = new int[5]; // Creates array of 5 integers (all 0 by default)

            // Method 2: Declare and initialize with values
            string[] names = { "Alice", "Bob", "Charlie", "Diana" };

            // Method 3: Declare, then initialize
            double[] grades = new double[] { 85.5, 92.0, 78.5, 96.0, 88.0 };

            // Method 4: Using new keyword with values
            int[] ages = new int[] { 20, 25, 30, 35 };

            // Accessing and modifying elements
            numbers[0] = 10;  // Set first element
            numbers[1] = 20;  // Set second element
            numbers[4] = 50;  // Set last element

            Console.WriteLine("Numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            Console.WriteLine("\nNames using foreach:");
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            // Finding maximum value
            double maxGrade = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > maxGrade)
                    maxGrade = grades[i];
            }
            Console.WriteLine($"\nHighest grade: {maxGrade}");

            // Array properties and methods
            Console.WriteLine($"Names array length: {names.Length}");
            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($"Last name: {names[names.Length - 1]}");

            Console.WriteLine();
        }

        // ==================== MULTIDIMENSIONAL ARRAYS ====================
        static void MultiDimensionalArrays()
        {
            Console.WriteLine("2. MULTIDIMENSIONAL ARRAYS (RECTANGULAR)");
            Console.WriteLine("=========================================");

            // 2D Array - Think of it as a table/matrix
            // Syntax: datatype[,] arrayName = new datatype[rows, columns];

            // Method 1: Declare with size, then assign values
            int[,] matrix = new int[3, 4]; // 3 rows, 4 columns

            // Fill the matrix with values
            int value = 1;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            // Method 2: Initialize with values directly
            int[,] grades = {
            {85, 90, 78, 92},  // Student 1's grades
            {88, 76, 95, 89},  // Student 2's grades
            {92, 85, 88, 94}   // Student 3's grades
        };

            Console.WriteLine("Matrix (3x4):");
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) = number of rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) = number of columns
                {
                    Console.Write($"{matrix[i, j],4}"); // {value,width} for formatting
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nStudent Grades:");
            for (int student = 0; student < grades.GetLength(0); student++)
            {
                Console.Write($"Student {student + 1}: ");
                for (int subject = 0; subject < grades.GetLength(1); subject++)
                {
                    Console.Write($"{grades[student, subject]} ");
                }
                Console.WriteLine();
            }

            // Calculate average for each student
            Console.WriteLine("\nStudent Averages:");
            for (int student = 0; student < grades.GetLength(0); student++)
            {
                int sum = 0;
                for (int subject = 0; subject < grades.GetLength(1); subject++)
                {
                    sum += grades[student, subject];
                }
                double average = (double)sum / grades.GetLength(1);
                Console.WriteLine($"Student {student + 1}: {average:F2}");
            }

            // 3D Array example
            int[,,] cube = new int[2, 3, 4]; // 2 layers, 3 rows, 4 columns
            Console.WriteLine($"\n3D Array dimensions: {cube.GetLength(0)} x {cube.GetLength(1)} x {cube.GetLength(2)}");

            Console.WriteLine();
        }

        // ==================== JAGGED ARRAYS ====================
        static void JaggedArrays()
        {
            Console.WriteLine("3. JAGGED ARRAYS (ARRAY OF ARRAYS)");
            Console.WriteLine("===================================");

            // Jagged arrays are arrays of arrays - each "row" can have different lengths
            // Syntax: datatype[][] arrayName = new datatype[numberOfArrays][];

            // Method 1: Create jagged array step by step
            int[][] jaggedArray = new int[4][]; // 4 arrays, sizes not specified yet

            // Now specify the size of each sub-array
            jaggedArray[0] = new int[3];    // First array has 3 elements
            jaggedArray[1] = new int[5];    // Second array has 5 elements
            jaggedArray[2] = new int[2];    // Third array has 2 elements
            jaggedArray[3] = new int[4];    // Fourth array has 4 elements

            // Fill with values
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = (i + 1) * 10 + j;
                }
            }

            // Method 2: Initialize with values directly
            string[][] studentSubjects = {
            new string[] {"Math", "Physics", "Chemistry"},           // Student 1: 3 subjects
            new string[] {"English", "History"},                     // Student 2: 2 subjects
            new string[] {"Art", "Music", "Drama", "Dance"},        // Student 3: 4 subjects
            new string[] {"Computer Science", "Biology", "Geography", "Psychology", "Philosophy"} // Student 4: 5 subjects
        };

            Console.WriteLine("Jagged Array (different lengths):");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Array {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine($"(Length: {jaggedArray[i].Length})");
            }

            Console.WriteLine("\nStudent Subjects:");
            for (int student = 0; student < studentSubjects.Length; student++)
            {
                Console.WriteLine($"Student {student + 1} subjects ({studentSubjects[student].Length} total):");
                for (int subject = 0; subject < studentSubjects[student].Length; subject++)
                {
                    Console.WriteLine($"  - {studentSubjects[student][subject]}");
                }
            }

            // Working with mixed data types in jagged arrays
            object[][] mixedData = {
            new object[] {"John", 25, 85.5},
            new object[] {"Alice", 22, 92.0, "Honor Student"},
            new object[] {"Bob", 24}
        };

            Console.WriteLine("\nMixed Data (Object jagged array):");
            for (int i = 0; i < mixedData.Length; i++)
            {
                Console.Write($"Record {i + 1}: ");
                foreach (var item in mixedData[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // ==================== PRACTICE EXERCISES ====================
        static void PracticeExercises()
        {
            Console.WriteLine("4. PRACTICE EXERCISES");
            Console.WriteLine("=====================");

            // Exercise 1: Find sum of all elements in single dimensional array
            Console.WriteLine("Exercise 1: Sum of array elements");
            int[] numbers = { 5, 10, 15, 20, 25 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum of {string.Join(", ", numbers)} = {sum}");

            // Exercise 2: Matrix multiplication (2x2 matrices)
            Console.WriteLine("\nExercise 2: Matrix addition");
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Matrix 1 + Matrix 2 =");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j],4}");
                }
                Console.WriteLine();
            }

            // Exercise 3: Find longest array in jagged array
            Console.WriteLine("\nExercise 3: Find longest sub-array");
            int[][] testArrays = {
            new int[] {1, 2},
            new int[] {3, 4, 5, 6, 7},
            new int[] {8, 9, 10}
        };

            int maxLength = 0;
            int maxIndex = 0;
            for (int i = 0; i < testArrays.Length; i++)
            {
                if (testArrays[i].Length > maxLength)
                {
                    maxLength = testArrays[i].Length;
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Longest array is at index {maxIndex} with {maxLength} elements:");
            Console.WriteLine($"[{string.Join(", ", testArrays[maxIndex])}]");

            // Exercise 4: Search for element in 2D array
            Console.WriteLine("\nExercise 4: Search in 2D array");
            int[,] searchMatrix = {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90}
        };

            int target = 50;
            bool found = false;
            int foundRow = -1, foundCol = -1;

            for (int i = 0; i < searchMatrix.GetLength(0) && !found; i++)
            {
                for (int j = 0; j < searchMatrix.GetLength(1) && !found; j++)
                {
                    if (searchMatrix[i, j] == target)
                    {
                        found = true;
                        foundRow = i;
                        foundCol = j;
                    }
                }
            }

            if (found)
                Console.WriteLine($"Found {target} at position [{foundRow}, {foundCol}]");
            else
                Console.WriteLine($"{target} not found in matrix");

            Console.WriteLine("\n=== END OF ARRAY PRACTICE ===");
        }
    }

    /* 
    KEY CONCEPTS TO REMEMBER FOR EXAMS:

    1. SINGLE DIMENSIONAL ARRAYS:
       - Declaration: int[] arr = new int[size];
       - Initialization: int[] arr = {1, 2, 3};
       - Access: arr[index] (0-based indexing)
       - Length: arr.Length

    2. MULTIDIMENSIONAL ARRAYS:
       - Declaration: int[,] arr = new int[rows, cols];
       - Access: arr[row, col]
       - Dimensions: arr.GetLength(0) for rows, arr.GetLength(1) for cols
       - All sub-arrays have same length (rectangular)

    3. JAGGED ARRAYS:
       - Declaration: int[][] arr = new int[numberOfArrays][];
       - Access: arr[i][j] (note the double brackets)
       - Length: arr.Length for main array, arr[i].Length for sub-array
       - Sub-arrays can have different lengths

    4. COMMON OPERATIONS:
       - Traversing: for loop or foreach
       - Searching: linear search through elements
       - Finding min/max: compare all elements
       - Calculating sums/averages: accumulate values

    5. EXAM TIPS:
       - Remember 0-based indexing
       - Watch out for IndexOutOfRangeException
       - Use GetLength() for multidimensional, Length for others
       - Jagged arrays use [][] syntax, multidimensional use [,]
    */
}
