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
            result.AppendLine($"����������: {Title}");
            result.AppendLine($"г� ����������: {YearOfFoundation:yyyy}");

            foreach (var faculty in Faculties)
            {
                result.AppendLine($"\n���������: {faculty.Title}");
                result.AppendLine($"  ������������:");
                foreach (var coordinator in faculty.Coordinator)
                {
                    result.AppendLine($"    - {coordinator.FirstName} {coordinator.LastName}, ��: {coordinator.Salary} ���");
                }

                foreach (var group in faculty.Groups)
                {
                    result.AppendLine($"\n  �����: {group.Title}");
                    result.AppendLine($"    �����������: {group.Coordinator?.FirstName} {group.Coordinator?.LastName}");
                    result.AppendLine($"    ��������:");
                    foreach (var student in group.Students)
                    {
                        result.AppendLine($"      - {student.FirstName} {student.LastName}, ������: {student.StudentGrade}");
                    }
                }
            }

            return result.ToString();
        }
    }
}