using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public abstract class Person(Guid personId, FullName fullName, DateTime dateOfBirth, Address? address)
        : IIdentifiable<Guid>
    {
        public FullName FullName { get; private set; } = fullName;
        public DateTime DateOfBirth { get; private set; } = dateOfBirth;
        public Address? Address { get; private set; } = address;
        

        public void Rename(FullName newName) =>
            FullName = newName ?? throw new ArgumentException("Ім'я не може бути порожнім");
        public void ChangeAddress(Address? newAddress) => Address = newAddress;

        Guid IIdentifiable<Guid>.EntityId => personId;
    }
    
}