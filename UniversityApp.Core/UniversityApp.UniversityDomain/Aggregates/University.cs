using UniversityApp.UniversityDomain.Contracts;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.UniversityDomain.Aggregates
{
    public class University(Guid universityId, string title) : IIdentifiable<Guid>
    {
        private Guid UniversityId { get; set; } = universityId;
        public string Title { get; set; } = title;
        public List<Faculty> Faculties { get; init; } = [];
        public DateTime YearOfFoundation { get; set; }
        public Address? Address { get; set; }
        
        Guid IIdentifiable<Guid>.EntityId => UniversityId;

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            result.AppendLine($"Університет: {Title}");
            result.AppendLine($"Рік заснування: {YearOfFoundation:yyyy}");

            foreach (var faculty in Faculties)
            {
                result.AppendLine($"\nФакультет: {faculty.Title}");
                result.AppendLine($"  Координатори:");
                foreach (var coordinator in faculty.Coordinators)
                {
                    result.AppendLine($"    - {coordinator.GetFullName().FirstName} {coordinator.GetFullName().LastName}, ЗП: {coordinator.Salary} грн");
                }

                foreach (var group in faculty.Groups)
                {
                    result.AppendLine($"\n  Група: {group.Title}");
                    result.AppendLine($"    Координатор: {(group.Coordinator?.GetFullName()).FirstName} {(group.Coordinator?.GetFullName()).LastName}");
                    result.AppendLine($"    Студенти:");
                    foreach (var student in group.Students)
                    {
                        result.AppendLine($"      - {student.GetFullName().FirstName} {student.GetFullName().LastName}, Оцінка: {student.Grade}");
                    }
                }
            }

            return result.ToString();
        }
    }
}