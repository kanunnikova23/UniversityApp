namespace UniversityDomain
{
    public class FacultyDto(string title)
    {
        public string Title { get; set; } = title;
        public List<CoordinatorDto> Coordinators { get; init; } = [];
        public List<GroupDto> Groups { get; init; } = [];
    }
}