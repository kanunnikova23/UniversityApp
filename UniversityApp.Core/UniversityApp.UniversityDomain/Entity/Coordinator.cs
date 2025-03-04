using UniversityApp.UniversityDomain.Contracts;

namespace UniversityApp.UniversityDomain.Entity
{
    public class Coordinator(Guid coordinatorId, string firstName, string lastName, DateTime dateOfBirth, double salary) 
        : Person(coordinatorId, firstName, lastName, dateOfBirth), IIdentifiable<Guid>
    {
        private Guid CoordinatorId { get; set; } = coordinatorId;
        public double Salary { get; set; } = salary;
        
        Guid IIdentifiable<Guid>.EntityId => CoordinatorId;
    }
}