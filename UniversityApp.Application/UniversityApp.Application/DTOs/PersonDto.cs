namespace UniversityApp.Application.DTOs
{
    public abstract class PersonDto(string firstName, string lastName, DateTime dateOfBirth)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public DateTime DateOfBirth { get; set; } = dateOfBirth;
    }
}