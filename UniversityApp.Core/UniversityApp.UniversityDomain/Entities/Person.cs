using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public abstract class Person(Guid personId, FullName fullName, DateTime dateOfBirth, Address? address)
        : IIdentifiable<Guid>
    {
        private Guid PersonId { get; set; } = personId;
        public FullName FullName {get; set; } = fullName;
        public DateTime DateOfBirth { get; set; } = dateOfBirth;
        public Address? Address { get; set; } = address;

        Guid IIdentifiable<Guid>.EntityId => PersonId;
    }
}