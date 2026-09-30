using System.Globalization;

namespace List_User_Input_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> Tasks = new();

                Console.WriteLine("How many task to add?");
                int taskCount = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                Console.WriteLine();

                for (int i = 0; i < taskCount; i++)
                {
                    Console.WriteLine($"\nEnter task {i + 1} name: ");
                    string taskName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine();

                    Console.WriteLine($"\nEnter duration for task {i + 1} in minutes: ");
                    int duration = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Tasks.Add(new TaskItem(taskName, duration).ToString());
                }

                foreach (var task in Tasks)
                {
                    Console.WriteLine(task);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format. Please enter a valid number for task count and duration.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

        }

        public class TaskItem
        {
            public string Name { get; set; }
            public int Duration { get; set; }

            public TaskItem(string name, int duration)
            {
                Name = name;
                Duration = duration;
            }

            public override string ToString()
            {
                return $"{Name} - duration: {Duration} minutes";
            }
        }
    }
}
