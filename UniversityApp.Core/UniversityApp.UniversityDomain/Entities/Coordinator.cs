using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Entities
{
    public class Coordinator(Guid coordinatorId, FullName fullName, double salary, DateTime dateOfBirth, Address address) 
        : Person(coordinatorId, fullName, dateOfBirth, address), IIdentifiable<Guid>
    {
        public Guid CoordinatorId { get; } = coordinatorId;
        public double Salary { get; private set; } = salary;

        Guid IIdentifiable<Guid>.EntityId => CoordinatorId;

        public void UpdateSalary(double newSalary) => Salary = newSalary < 0 ? throw new ArgumentException("Зарплата не може бути від'ємною") : newSalary;
    }
}