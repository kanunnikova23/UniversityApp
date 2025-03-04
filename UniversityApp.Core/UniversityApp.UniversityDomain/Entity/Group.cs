namespace UniversityApp.UniversityDomain.Entity
{
    public class Group(Guid groupId, string title, Coordinator coordinator)
    {
        public Guid GroupId { get; set; } = groupId;
        public string Title { get; set; } = title;
        public List<Student> Students { get; init; } = [];
        public Coordinator? Coordinator { get; set; } = coordinator;
    }
}