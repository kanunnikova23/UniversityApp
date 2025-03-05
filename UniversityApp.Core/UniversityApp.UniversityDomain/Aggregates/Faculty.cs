using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.Entities;

namespace UniversityApp.UniversityDomain.Aggregates
{
    public class Faculty(Guid facultyId, string title) : IIdentifiable<Guid>
    {
        private Guid FacultyId { get; set; } = facultyId;
        public string Title { get; set; } = title;
        public List<Coordinator> Coordinators { get; init; } = [];
        public List<Group> Groups { get; init; } = [];
        
        Guid IIdentifiable<Guid>.EntityId => FacultyId;
    }
}