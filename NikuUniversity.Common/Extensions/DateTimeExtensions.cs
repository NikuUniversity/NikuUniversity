namespace NikuUniversity.Common.Extensions;

public static class DateTimeExtensions
{
    /// <summary>
    /// Converts a DateTime to an academic year string (e.g., "2025-2026").
    /// </summary>
    public static string ToAcademicYear(this DateTime date)
    {
        // Assuming academic year starts in July/August
        int startYear = date.Month >= 7 ? date.Year : date.Year - 1;
        return $"{startYear}-{startYear + 1}";
    }

    /// <summary>
    /// Returns a human-readable relative time (e.g., "2 days ago", "Just now").
    /// </summary>
    public static string ToRelativeTimeString(this DateTime dateTime)
    {
        var timeSpan = DateTime.UtcNow - dateTime.ToUniversalTime();

        if (timeSpan.TotalSeconds < 60) return "Just now";
        if (timeSpan.TotalMinutes < 60) return $"{timeSpan.Minutes}m ago";
        if (timeSpan.TotalHours < 24) return $"{timeSpan.Hours}h ago";
        if (timeSpan.TotalDays < 30) return $"{timeSpan.Days}d ago";

        return dateTime.ToString("MMM dd, yyyy");
    }
}