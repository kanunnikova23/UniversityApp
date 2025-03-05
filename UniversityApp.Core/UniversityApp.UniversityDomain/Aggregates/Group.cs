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

        public void AddStudent(Student student) => Students.Add(Students.Any(s => s.StudentId == student.StudentId) ? student : throw new ArgumentException("Студент вже в групі."));

        public void RemoveStudent(Guid studentId) => Students.Remove(Students.FirstOrDefault(s => s.StudentId == studentId) ?? throw new ArgumentException("Студента не знайдено."));

        public void ChangeCoordinator(Coordinator newCoordinator) => Coordinator = newCoordinator ?? throw new ArgumentException("Координатор не може бути порожнім.");
    }
}