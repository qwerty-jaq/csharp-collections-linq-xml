namespace CollectionsW2B2_Queue
{
    internal class SchedulingSystem
    {
        static void Main(string[] args)
        {
            Queue<TaskItem<string>> taskQueue = new Queue<TaskItem<string>>();

            // Adding tasks to the queue
            taskQueue.Enqueue(new TaskItem<string>("Task 1", 30));
            taskQueue.Enqueue(new TaskItem<string>("Task 2", 45));
            taskQueue.Enqueue(new TaskItem<string>("Task 3", 20));

            Console.WriteLine("Processing Tasks:\n");

            while (taskQueue.Count > 0)
            {
                var task = taskQueue.Dequeue();
                Console.WriteLine($"Task: {task.Name}, Estimated Time: {task.TimeMinutes} mins");
            }
        }
    }

    public class TaskItem<T>
    {
        public T Name { get; set; }
        public int TimeMinutes { get; set; }

        public TaskItem(T name, int timeMinutes)
        {
            Name = name;
            TimeMinutes = timeMinutes;
        }
    }
}
