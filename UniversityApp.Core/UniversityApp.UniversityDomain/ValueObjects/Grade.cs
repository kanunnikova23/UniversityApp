using UniversityApp.UniversityDomain.Enums;

namespace UniversityApp.UniversityDomain.ValueObjects;

public class Grade
{
    public float Score { get; set; }
    public GradeLetter Letter { get; set; }
    public GradeSystem System { get; set; }
}