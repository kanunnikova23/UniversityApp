namespace UniversityEntities;

public class Faculty(string title)
{
    public string Title { get; set; } = title;
    public List<Coordinator> Coordinator { get; set; } = [];
    public List<Group> Groups { get; set; } = [];
}