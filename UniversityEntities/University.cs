namespace UniversityEntities
{
public class University(string title)
{
        public string Title { get; set; } = title;
    public List<Faculty> Faculties { get; set; } = [];
    public DateTime YearOfFoundation { get; set; }
}