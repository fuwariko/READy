namespace Domain;

public class Publicator
{
    public User User;

    public Publicator(User user)
    {
        User = user;
    }

    public void Publicate(Content content)
    {
        // Добавляем контент в БД, список публикаций автора и тд
    }

    public void AddTags(List<Tag> tags)
    {
        // Добавляем контенту тегов
    }
}