using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.Entities;

namespace UniversityApp.UniversityDomain.Aggregates
{
    public class Group(Guid groupId, string title, Coordinator coordinator) 
        : IIdentifiable<Guid>
    {
        public Guid GroupId { get; } = groupId;
        public string Title { get; private set; } = title;
        public List<Student> Students { get; } = [];
        public Coordinator Coordinator { get; private set; } = coordinator;
        
        Guid IIdentifiable<Guid>.EntityId => GroupId;
    }
}