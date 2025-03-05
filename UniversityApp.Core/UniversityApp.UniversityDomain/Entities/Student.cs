using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public class Student(Guid studentId, FullName fullName, int grade, DateTime dateOfBirth, Address address) 
        : Person(studentId, fullName, dateOfBirth, address), IIdentifiable<Guid>
    {
        public Guid StudentId { get; } = studentId;
        public int Grade { get; private set; } = grade;

        Guid IIdentifiable<Guid>.EntityId => StudentId;

        public void ChangeGrade(int newGrade) => Grade = newGrade is < 0 or > 100 ? throw new ArgumentException("Неправильна оцінка.") : newGrade;
    }
}