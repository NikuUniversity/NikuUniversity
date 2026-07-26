//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NikuUniversity.Common.Models.Helpers
//{
//    internal class AcademicHelper
//    {
//    }
//}


using NikuUniversity.Model.Entities;
using NikuUniversity.Model.Enums;

namespace NikuUniversity.Common.Models.Helpers;

public static class AcademicHelper
{
    // Converts Grade enum to 4.0 scale points
    public static double ToGradePoints(this Grade grade) => grade switch
    {
        Grade.A => 4.0,
        Grade.B => 3.0,
        Grade.C => 2.0,
        Grade.D => 1.0,
        Grade.F => 0.0,
        _ => 0.0
    };

    // Calculates cumulative GPA from a list of enrollments
    public static double CalculateGpa(IEnumerable<Enrollment> enrollments)
    {
        var gradedList = enrollments
            .Where(e => e.FinalGrade.HasValue && e.Course != null)
            .ToList();

        if (!gradedList.Any()) return 0.0;

        double totalPoints = gradedList.Sum(e => e.FinalGrade!.Value.ToGradePoints() * e.Course!.Credits);
        int totalCredits = gradedList.Sum(e => e.Course!.Credits);

        return totalCredits == 0 ? 0.0 : Math.Round(totalPoints / totalCredits, 2);
    }

    // Business validation rule for course registration
    public static bool IsWithinCreditLimits(int requestedCredits, int min = 12, int max = 21)
    {
        return requestedCredits >= min && requestedCredits <= max;
    }
}