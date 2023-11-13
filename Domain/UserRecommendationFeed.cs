namespace Domain;

public class UserRecommendationFeed
{
    public User User;
    public List<Content> RecomendedContents;

    public UserRecommendationFeed(User user)
    {
        User = user;
        RecomendedContents = new List<Content>();
    }

    public void Regenirate()
    {
        // получаем из БД актульные реки и меняем RecomendedContents
    }
    
    protected bool Equals(UserRecommendationFeed other)
    {
        return EqualityComparer<User>.Default.Equals(User, other.User);
    }
    
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((UserRecommendationFeed)obj);
    }
}