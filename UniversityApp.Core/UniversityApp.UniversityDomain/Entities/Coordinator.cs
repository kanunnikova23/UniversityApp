using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public class Coordinator(Guid coordinatorId, FullName fullName, double salary, DateTime dateOfBirth, Address address) 
        : Person(coordinatorId, fullName, dateOfBirth, address), IIdentifiable<Guid>
    {
        private Guid CoordinatorId { get; set; } = coordinatorId;
        public double Salary { get; set; } = salary;
        
        Guid IIdentifiable<Guid>.EntityId => CoordinatorId;
    }
}