namespace UniversityEntities
{
    public class University(string title)
    {
        public string Title { get; set; } = title;
        public List<Faculty> Faculties { get; set; } = [];
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
                foreach (var coordinator in faculty.Coordinator)
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
                        result.AppendLine($"      - {student.FirstName} {student.LastName}, Оцінка: {student.StudentGrade}");
                    }
                }
            }

            return result.ToString();
        }
    }
}