namespace UniversityApp.UniversityDomain.Entity
{
    public class Coordinator(Guid personId, string firstName, string lastName, DateTime dateOfBirth, double salary) : Person(personId, firstName, lastName, dateOfBirth)
    {
        public double Salary { get; set; } = salary;
    }
}