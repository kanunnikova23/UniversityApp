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

        public void AddCoordinator(Coordinator coordinator) => Coordinators.Add(Coordinators.Any(c => c.CoordinatorId == coordinator.CoordinatorId) ? coordinator : throw new ArgumentException("Координатор вже доданий."));
        
        public void RemoveCoordinator(Guid coordinatorId) => Coordinators.Remove(Coordinators.FirstOrDefault(c => c.CoordinatorId == coordinatorId) ?? throw new ArgumentException("Координатора не знайдено."));
        
        public void AddGroup(Group group) => Groups.Add(Groups.Any(g => g.GroupId == group.GroupId) ? group : throw new ArgumentException("Група вже додана."));

        public void RemoveGroup(Guid groupId) => Groups.Remove(Groups.FirstOrDefault(g => g.GroupId == groupId) ?? throw new ArgumentException("Групу не знайдено."));
    }
}