namespace UniversityApp.UniversityDomain.ValueObjects;

public class FullName(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string Patronymic { get; set; } = string.Empty;
    public string LastName { get; set; } = lastName;
}