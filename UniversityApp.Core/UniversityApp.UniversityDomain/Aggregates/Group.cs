using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.Entities;

namespace UniversityApp.UniversityDomain.Aggregates
{
    public class Group(Guid groupId, string title, Coordinator coordinator) 
        : IIdentifiable<Guid>
    {
        private Guid GroupId { get; set; } = groupId;
        public string Title { get; set; } = title;
        public List<Student> Students { get; init; } = [];
        public Coordinator? Coordinator { get; set; } = coordinator;
        
        Guid IIdentifiable<Guid>.EntityId => GroupId;
    }
}