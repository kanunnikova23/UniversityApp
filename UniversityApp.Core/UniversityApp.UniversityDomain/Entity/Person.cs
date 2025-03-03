namespace UniversityApp.UniversityDomain.Entity
{
    public abstract class Person(Guid personId, string firstName, string lastName, DateTime dateOfBirth)
    {
        public Guid PersonId { get; set; } = personId;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public DateTime DateOfBirth { get; set; } = dateOfBirth;
    }
}