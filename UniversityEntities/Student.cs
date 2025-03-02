namespace UniversityEntities
{
    public class Student(Guid personId, string firstName, string lastName, DateTime dateOfBirth, int studentGrade) : Person(personId, firstName, lastName, dateOfBirth)
    {
        public int StudentGrade { get; set; } = studentGrade;
    }
}