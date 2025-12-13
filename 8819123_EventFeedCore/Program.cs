internal static class Program
{
    private static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n=== Event Feed & Moderation Core ===");
            Console.WriteLine("1. Load events from file");
            Console.WriteLine("2. View ingest queue");
            Console.WriteLine("3. Process next event");
            Console.WriteLine("4. Display feed");
            Console.WriteLine("5. Pin a post");
            Console.WriteLine("6. Delete a post");
            Console.WriteLine("7. Undo");
            Console.WriteLine("8. Redo");
            Console.WriteLine("0. Exit");
            Console.Write("> ");
            
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    Console.WriteLine("TODO: Load events");
                    break;
                case "2":
                    Console.WriteLine("TODO: View queue");
                    break;
                case "3":
                    Console.WriteLine("TODO: Process event");
                    break;
                case "4":
                    Console.WriteLine("TODO: Display feed");
                    break;
                case "5":
                    Console.WriteLine("TODO: Pin post");
                    break;
                case "6":
                    Console.WriteLine("TODO: Delete post");
                    break;
                case "7":
                    Console.WriteLine("TODO: Undo");
                    break;
                case "8":
                    Console.WriteLine("TODO: Redo");
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}