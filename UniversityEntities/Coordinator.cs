namespace UniversityEntities;

public class Coordinator : Person
{
    public double Salary { get; set; }

    protected Coordinator(Guid personId, string firstName, string lastName, DateTime dateOfBirth, double salary)
        : base(personId, firstName, lastName, dateOfBirth)
    {
        Salary = salary;
    }
}