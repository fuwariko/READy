using Domain;

namespace UserInterface;

public interface UI
{
    void GetStatic();
    User Authorizate();
    User GetHome();
    UserRecommendationFeed getFeed(User user);
    void Publicate(User user, Content content);
    void DoLike(User user, Content content);
}