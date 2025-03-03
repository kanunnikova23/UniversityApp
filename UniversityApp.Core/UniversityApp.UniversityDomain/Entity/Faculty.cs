namespace UniversityApp.UniversityDomain.Entity
{
    public class Faculty(string title)
    {
        public string Title { get; set; } = title;
        public List<Coordinator> Coordinators { get; init; } = [];
        public List<Group> Groups { get; init; } = [];
    }
}