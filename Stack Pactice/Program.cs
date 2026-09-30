namespace Stack_Pactice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Push 3 actions to stack, Undo last 2 (Pop), show current top action.

            Stack<string> actions = new Stack<string>();
            actions.Push("Action 1: Open file");
            actions.Push("Action 2: Edit file");
            actions.Push("Action 3: Save file");

            Console.WriteLine("\n - Actions performed:");
            Console.WriteLine("------------------------------------------");
            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }

            Console.WriteLine("\nUndoing last 2 actions...\n");
            actions.Pop(); // Undo "Action 3: Save file"
            actions.Pop(); // Undo "Action 2: Edit file"

            Console.WriteLine("\n - Current top action after undoing:");
            Console.WriteLine("------------------------------------------");
            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }

        }
    }
}
