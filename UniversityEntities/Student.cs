namespace UniversityEntities;

public class Student : Person
{
    public int StudentGrade { get; set; }
    
    protected Student(Guid personId, string firstName, string lastName, DateTime dateOfBirth, int studentGrade)
        : base(personId, firstName, lastName, dateOfBirth)
    {
        StudentGrade = studentGrade;
    }
}