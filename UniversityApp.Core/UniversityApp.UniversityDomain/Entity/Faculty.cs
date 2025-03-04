namespace UniversityApp.UniversityDomain.Entity
{
    public class Faculty(Guid facultyId, string title)
    {
        public Guid FacultyId { get; set; } = facultyId;
        public string Title { get; set; } = title;
        public List<Coordinator> Coordinators { get; init; } = [];
        public List<Group> Groups { get; init; } = [];
    }
}