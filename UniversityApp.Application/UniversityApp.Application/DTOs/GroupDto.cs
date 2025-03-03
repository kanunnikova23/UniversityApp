namespace UniversityDomain
{
    public class GroupDto(string title, CoordinatorDto coordinator)
    {
        public string Title { get; set; } = title;
        public List<StudentDto> Students { get; init; } = [];
        public CoordinatorDto? Coordinator { get; set; } = coordinator;
    }
}