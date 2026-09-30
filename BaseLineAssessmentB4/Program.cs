namespace BaseLineAssessmentB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Question 1:\n");
            program.Question1();
            Console.WriteLine("-------------------------------");
            Thread.Sleep(5000);

            Console.WriteLine("Question 2:\n");
            program.Question2();
            Console.WriteLine("-------------------------------");
            Thread.Sleep(5000);

            Console.WriteLine("Question 3:\n");
            program.Question3();
            Console.WriteLine("-------------------------------");
            Thread.Sleep(5000);

            Console.WriteLine("Question 4:\n");
            program.Question4();
            Console.WriteLine("-------------------------------");
            Thread.Sleep(5000);

            Console.WriteLine("Question 5:\n");
            program.Question5();
            Console.WriteLine("-------------------------------");
           
        }

        public void Question1()
        {
            //1D array of integers
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //sum of array elements
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine($"Sum of array elements: {sum}");
            Console.WriteLine();

            //average of array elements
            double average = (double)sum / arr.Length;
            Console.WriteLine($"Average of array elements: {average}");
            Console.WriteLine();

            //highest and lowest elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Lowest element: {arr[0]}");
            Console.WriteLine($"Highest element: {arr[arr.Length - 1]}");
            Console.WriteLine();

            //size of the array
            Console.WriteLine($"Size of the array: {arr.Length}");
            Console.WriteLine();

        }

        public void Question2()
        {
            //List<T>
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Cherry");
            fruits.Add("Blue Berries");
            fruits.Add("Mango");
            Console.WriteLine("Original Fruits List:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            //insert banana at index 2
            fruits.Insert(1, "Banana");
            Console.WriteLine("Fruits List:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            //removing cherry
            fruits.Remove("Cherry");
            Console.WriteLine("Fruits List:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            //display items with index
            Console.WriteLine("Fruits List with Index:");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine($"Index {i}: {fruits[i]}");

            }
            Console.WriteLine();
        }
        public void Question3()
        {
            //Stack<int>
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(15);
            stack.Push(25);
            stack.Push(35);
            Console.WriteLine("Stack elements:");
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //removing one number from the stack (not the top one)
            int numberToRemove = 15;
            Stack<int> tempStack = new Stack<int>();

            while (stack.Count > 0)//move items to find the number to remove
            {
                int top = stack.Pop();
                if (top != numberToRemove)
                {
                    tempStack.Push(top);
                }
            }

            while (tempStack.Count > 0)//put items back
            {
                stack.Push(tempStack.Pop());
            }

            Console.WriteLine($"Stack elements after removing {numberToRemove}:");
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            //displaying the top element
            Console.WriteLine($"Top element: {stack.Peek()}");
            Console.WriteLine();


            //display items with index
            Console.WriteLine("Stack elements with Index:");
            int index = 0;
            foreach (int num in stack)
            {
                Console.WriteLine($"Index {index}: {num}");
                index++;
            }
            Console.WriteLine();

            //size of the stack
            Console.WriteLine($"Size of the stack: {stack.Count}");
            Console.WriteLine();
        }
        public void Question4()
        {
            //Queue, prompting user to enter names 
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                string name = Console.ReadLine();
                queue.Enqueue(name);
            }
            Console.WriteLine();

            Console.WriteLine("Queue elements:");
            foreach (string name in queue)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //removing one name from the queue
            string removedName = queue.Dequeue();
            Console.WriteLine($"Removed name: {removedName}");
            Console.WriteLine("Queue elements after removal:");
            foreach (string name in queue)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //display elements with index
            Console.WriteLine("Queue elements with Index:");
            int index = 0;
            foreach (string name in queue)
            {
                Console.WriteLine($"Index {index}: {name}");
                index++;
            }
            Console.WriteLine();
        }
        public void Question5()
        {
            //create nodes
            Node first = new Node(10);
            Node second = new Node(20);
            Node third = new Node(30);

            //link nodes
            first.Next = second;
            second.Next = third;
            third.Next = null;

            //traverse the linked list
            Console.WriteLine("Linked List elements:");
            Node current = first;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }

        }
    }
}
