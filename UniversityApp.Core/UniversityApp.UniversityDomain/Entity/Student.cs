namespace UniversityApp.UniversityDomain.Entity
{
    public class Student(Guid personId, string firstName, string lastName, DateTime dateOfBirth, int grade) : Person(personId, firstName, lastName, dateOfBirth)
    {
        public int Grade { get; set; } = grade;
    }
}