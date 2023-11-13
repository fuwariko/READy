namespace Domain;

public class Tag
{
    public readonly string Name;
    public List<Content> TagContents;

    public Tag(string name)
    {
        Name = name;
        TagContents = new List<Content>();
    }
}