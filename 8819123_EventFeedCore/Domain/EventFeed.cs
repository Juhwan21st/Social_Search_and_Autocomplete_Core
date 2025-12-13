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

    public Post? FindPostById(int id)
    {
        return _posts.Find(p => p.Id == id);
    }

    public bool PinPost(int id)
    {
        var post = FindPostById(id);
        if (post is null) return false;
        
        post.IsPinned = true;
        return true;
    }

    public void LoadSampleData()
    {
        AddPost(new Post(1, "alice", "Hello world! #greeting"));
        AddPost(new Post(2, "bob", "Loving the new features #awesome"));
        AddPost(new Post(3, "charlie", "Check this out #news"));
    }
}

