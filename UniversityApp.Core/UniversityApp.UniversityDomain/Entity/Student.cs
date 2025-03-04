using UniversityApp.UniversityDomain.Contracts;

namespace UniversityApp.UniversityDomain.Entity
{
    public class Student(Guid studentId, string firstName, string lastName, DateTime dateOfBirth, int grade) 
        : Person(studentId, firstName, lastName, dateOfBirth), IIdentifiable<Guid>
    {
        private Guid StudentId { get; set; } = studentId;
        public int Grade { get; set; } = grade;
        
        Guid IIdentifiable<Guid>.EntityId => StudentId;
    }
}