using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public class Coordinator(Guid coordinatorId, FullName fullName, double salary, DateTime dateOfBirth, Address address) 
        : Person(coordinatorId, fullName, dateOfBirth, address), IIdentifiable<Guid>
    {
        private Guid CoordinatorId { get; } = coordinatorId;
        public double Salary { get; private set; } = salary;
        
        public void UpdateSalary(double newSalary)
        {
            if (newSalary < 0)
                throw new ArgumentException("Зарплата не може бути від'ємною");
        
            Salary = newSalary;
        }
       
        
        Guid IIdentifiable<Guid>.EntityId => CoordinatorId;
    }
}