namespace UniversityDomain
{
    public class CoordinatorDto(Guid personId, string firstName, string lastName, DateTime dateOfBirth, double salary) : PersonDto(personId, firstName, lastName, dateOfBirth)
    {
        public double Salary { get; set; } = salary;
    }
}