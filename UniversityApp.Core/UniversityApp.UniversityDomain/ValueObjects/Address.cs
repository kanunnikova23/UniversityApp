namespace UniversityApp.UniversityDomain.ValueObjects;

public class Address(string street, string city, string state, string postalCode, string country)
{
    public string Street { get; set; } = street;
    public string City { get; private set; } = city;
    public string State { get; private set; } = state;
    public string PostalCode { get; private set; } = postalCode;
    public string Country { get; private set; } = country;
}
