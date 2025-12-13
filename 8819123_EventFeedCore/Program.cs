/*
* Course: PROG3330 - Fall 2025 - Section 2
* Programmed by : Juhwan Seo [8819123]
* Project: Event Feed & Moderation Core Assignment
*/

using EventFeedCore.Domain;
using EventFeedCore.UI;

internal static class Program
{
    private static void Main()
    {
        var feed = new EventFeed();
        feed.LoadSampleData();
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
                    FeedDisplay.ShowFeed(feed);
                    break;
                case "5":
                    Console.Write("Enter post ID to pin: ");
                    if (int.TryParse(Console.ReadLine(), out int pinId))
                    {
                        if (feed.PinPost(pinId))
                        {
                            Console.WriteLine($"Pinned post {pinId}.");
                        }
                        else
                        {
                            Console.WriteLine($"Post {pinId} not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid post ID.");
                    }
                    break;
                case "6":
                    Console.Write("Enter post ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        if (feed.DeletePost(deleteId))
                        {
                            Console.WriteLine($"Deleted post {deleteId}.");
                        }
                        else
                        {
                            Console.WriteLine($"Post {deleteId} not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid post ID.");
                    }
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