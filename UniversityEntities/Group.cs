namespace UniversityEntities
{
    public class Group(string title, Coordinator coordinator)
    {
        public string Title { get; set; } = title;
        public List<Student> Students { get; init; } = [];
        public Coordinator? Coordinator { get; set; } = coordinator;
    }
}