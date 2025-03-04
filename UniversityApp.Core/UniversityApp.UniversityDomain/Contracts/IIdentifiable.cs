namespace UniversityApp.UniversityDomain.Contracts;

public interface IIdentifiable<out T>
{
    T EntityId { get; }
}