namespace UniversityApp.UniversityDomain.Entity
{
    public class University(Guid universityId, string title)
    {
        public Guid UniversityId { get; set; } = universityId;
        public string Title { get; set; } = title;
        public List<Faculty> Faculties { get; init; } = [];
        public DateTime YearOfFoundation { get; set; }

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
                    result.AppendLine($"    - {coordinator.FirstName} {coordinator.LastName}, ЗП: {coordinator.Salary} грн");
                }

                foreach (var group in faculty.Groups)
                {
                    result.AppendLine($"\n  Група: {group.Title}");
                    result.AppendLine($"    Координатор: {group.Coordinator?.FirstName} {group.Coordinator?.LastName}");
                    result.AppendLine($"    Студенти:");
                    foreach (var student in group.Students)
                    {
                        result.AppendLine($"      - {student.FirstName} {student.LastName}, Оцінка: {student.Grade}");
                    }
                }
            }

            return result.ToString();
        }
    }
}