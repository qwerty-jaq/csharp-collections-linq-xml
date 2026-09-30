namespace CollectionsW3B2_Stack
{
    internal class RecentlyOpenedDocument
    {
        static void Main(string[] args)
        {
            Stack<string> recentlyOpenedDocuments = new Stack<string>();
            HashSet<string> openedDocumentsSet = new HashSet<string>();

            // Simulate opening documents
            OpenFile(recentlyOpenedDocuments, openedDocumentsSet, "Document1.txt");
            OpenFile(recentlyOpenedDocuments, openedDocumentsSet, "Document2.txt");
            OpenFile(recentlyOpenedDocuments, openedDocumentsSet, "Document3.txt");
            OpenFile(recentlyOpenedDocuments, openedDocumentsSet, "Document1.txt"); // Reopen Document1

            Console.WriteLine("Recently Opened Files:\n");
            Thread.Sleep(1000); // Simulate a delay for better visibility in output
            foreach (var doc in recentlyOpenedDocuments)
            {

                Console.WriteLine(doc);
                Thread.Sleep(1000); // Simulate a delay for better visibility in output
            }
        }

        static void OpenFile(Stack<string> stack, HashSet<string> set, string fileName)
        {
            // If the file is already opened, remove it from the stack
            if (set.Contains(fileName))
            {
                stack = new Stack<string>(stack.Where(doc => doc != fileName));
                set.Remove(fileName);
            }
            // Add the file to the top of the stack and the set
            stack.Push(fileName);
            set.Add(fileName);
        }
    }

   
}
