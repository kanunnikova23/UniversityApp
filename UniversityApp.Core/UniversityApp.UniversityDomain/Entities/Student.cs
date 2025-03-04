using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public class Student(Guid studentId, FullName fullName, int grade, DateTime dateOfBirth, Address address) 
        : Person(studentId, fullName, dateOfBirth, address), IIdentifiable<Guid>
    {
        private Guid StudentId { get; set; } = studentId;
        public int Grade { get; set; } = grade;
        
        Guid IIdentifiable<Guid>.EntityId => StudentId;
    }
}