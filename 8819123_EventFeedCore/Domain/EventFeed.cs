namespace EventFeedCore.Domain;

public class EventFeed
{
    private readonly List<Post> _posts = new();

    public void AddPost(Post post)
    {
        if (post is null) throw new ArgumentNullException(nameof(post));
        _posts.Add(post);
    }

    public IReadOnlyList<Post> GetAllPosts() => _posts.AsReadOnly();

    public void LoadSampleData()
    {
        AddPost(new Post(1, "alice", "Hello world! #greeting"));
        AddPost(new Post(2, "bob", "Loving the new features #awesome"));
        AddPost(new Post(3, "charlie", "Check this out #news"));
    }
}

