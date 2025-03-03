namespace UniversityApp.Application.DTOs
{
    public class StudentDto(string firstName, string lastName, DateTime dateOfBirth, int grade) : PersonDto(firstName, lastName, dateOfBirth)
    {
        public int Grade { get; set; } = grade;
    }
}