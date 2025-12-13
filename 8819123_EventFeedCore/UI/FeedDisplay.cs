namespace EventFeedCore.UI;

using Domain;

/// <summary>
/// Handles displaying feed information to the console.
/// No business logic - only presentation/formatting.
/// </summary>
public static class FeedDisplay
{
    public static void ShowFeed(EventFeed feed)
    {
        var posts = feed.GetAllPosts();
        if (posts.Count == 0)
        {
            Console.WriteLine("No posts in feed.");
            return;
        }

        Console.WriteLine("\n=== Event Feed ===");
        foreach (var post in posts)
        {
            string pinned = post.IsPinned ? "[PINNED] " : "";
            Console.WriteLine($"{pinned}[{post.Id}] {post.Author}: {post.Content} (Likes: {post.Likes})");
        }
    }
}

