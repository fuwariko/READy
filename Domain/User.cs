namespace Domain;

public class User
{
    public string Name;
    public string Status;
    public Publicator Publicator;
    public List<Content> Publications;
    public Dictionary<Tag, int> LikeTags;
    public UserRecommendationFeed RecommendationFeed;
    public readonly string Id;

    public User(string name, string id, string status = null)
    {
        Name = name;
        Id = id;
        Status = status;
    }

    public void DoLike(Content content)
    {
        foreach (var tag in content.Tags)
        {
            if (!LikeTags.Keys.Contains(tag))
                LikeTags[tag] = 0;
            LikeTags[tag] += 1;
        }
    }
    
    protected bool Equals(User other)
    {
        return EqualityComparer<string>.Default.Equals(Id, other.Id);
    }
    
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((User)obj);
    }
    
    public override int GetHashCode()
    {
        return EqualityComparer<string>.Default.GetHashCode(Id);
    }
}