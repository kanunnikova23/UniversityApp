namespace UniversityEntities;

public class University(string title)
{
    public required string Title { get; set; }
    public List<Faculty> Faculties { get; set; } = [];
    public DateTime YearOfFoundation { get; set; }
}