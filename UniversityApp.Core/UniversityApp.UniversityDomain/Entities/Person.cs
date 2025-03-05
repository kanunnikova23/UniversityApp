using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.Enums;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public abstract class Person(Guid personId, FullName fullName, DateTime dateOfBirth, Address? address, Sex sex)
        : IIdentifiable<Guid>
    {
        public Guid PersonId { get; } = personId;
        public FullName FullName { get; private set; } = fullName;
        public DateTime DateOfBirth { get; private set; } = dateOfBirth;
        public Address? Address { get; private set; } = address;
        public Sex Sex { get; set; } = sex;

        Guid IIdentifiable<Guid>.EntityId => PersonId;

        public void Rename(FullName newName) => FullName = newName ?? throw new ArgumentException("Ім'я не може бути порожнім");
        public void ChangeAddress(Address? newAddress) => Address = newAddress;
    }
}