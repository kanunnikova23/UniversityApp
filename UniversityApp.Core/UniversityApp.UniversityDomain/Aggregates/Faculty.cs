using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.Entities;

namespace UniversityApp.UniversityDomain.Aggregates
{
    public class Faculty(Guid facultyId, string title) : IIdentifiable<Guid>
    {
        public Guid FacultyId { get; } = facultyId;
        public string Title { get; private set; } = title;
        public List<Coordinator> Coordinators { get; } = [];
        public List<Group> Groups { get; } = [];
        
        Guid IIdentifiable<Guid>.EntityId => FacultyId;
    }
}