using UniversityApp.UniversityDomain.Contracts;

namespace UniversityApp.UniversityDomain.Entity
{
    public abstract class Person(Guid studentId, string firstName, string lastName, DateTime dateOfBirth)
        : IIdentifiable<Guid>
    {
        private Guid StudentId { get; set; } = studentId;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public DateTime DateOfBirth { get; set; } = dateOfBirth;

        Guid IIdentifiable<Guid>.EntityId => StudentId;
    }
}