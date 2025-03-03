namespace UniversityApp.Application.DTOs
{
    public class CoordinatorDto(string firstName, string lastName, DateTime dateOfBirth, double salary) : PersonDto(firstName, lastName, dateOfBirth)
    {
        public double Salary { get; set; } = salary;
    }
}