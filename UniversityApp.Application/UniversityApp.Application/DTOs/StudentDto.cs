namespace UniversityDomain
{
    public class StudentDto(Guid personId, string firstName, string lastName, DateTime dateOfBirth, int grade) : PersonDto(personId, firstName, lastName, dateOfBirth)
    {
        public int Grade { get; set; } = grade;
    }
}