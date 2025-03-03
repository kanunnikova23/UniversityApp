namespace UniversityDomain
{
    public class StudentDto(string firstName, string lastName, DateTime dateOfBirth, int grade) : PersonDto(firstName, lastName, dateOfBirth)
    {
        public int Grade { get; set; } = grade;
    }
}