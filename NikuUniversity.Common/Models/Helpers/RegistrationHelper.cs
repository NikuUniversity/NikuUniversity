namespace NikuUniversity.Common.Models.Helpers;

public static class RegistrationHelper
{
    // Formats: REG-2026-FALL-8492
    public static string GenerateRegistrationNumber(string term = "FALL")
    {
        var year = DateTime.UtcNow.Year;
        var randomNum = Random.Shared.Next(1000, 9999);
        return $"REG-{year}-{term.ToUpper()}-{randomNum}";
    }

    // Formats: APP-2026-009812
    public static string GenerateApplicationNumber()
    {
        var year = DateTime.UtcNow.Year;
        var randomNum = Random.Shared.Next(100000, 999999);
        return $"APP-{year}-{randomNum}";
    }

    // Formats: STU-2026-1042
    public static string GenerateStudentEnrollmentNumber(int studentId)
    {
        var year = DateTime.UtcNow.Year;
        return $"STU-{year}-{studentId:D4}";
    }
}