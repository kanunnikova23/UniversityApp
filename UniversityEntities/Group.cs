namespace UniversityEntities;

public class Group(string title)
{
    public string Title { get; set; } = title;
    public List<Student> Students { get; set; } = [];
    public Coordinator? Coordinator { get; set; }
}