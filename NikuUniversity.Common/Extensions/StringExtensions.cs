using System.Text.RegularExpressions;

namespace NikuUniversity.Common.Extensions;

public static class StringExtensions
{
    private static readonly Regex EmailRegex = new(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    /// <summary>
    /// Checks if a string is a valid email format.
    /// </summary>
    public static bool IsValidEmail(this string? email)
    {
        return !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email);
    }

    /// <summary>
    /// Capitalizes the first letter of a string.
    /// </summary>
    public static string ToTitleCase(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) return string.Empty;
        return char.ToUpper(text[0]) + text[1..].ToLower();
    }

    /// <summary>
    /// Truncates a string to a max length with trailing ellipsis.
    /// </summary>
    public static string Truncate(this string? text, int maxLength)
    {
        if (string.IsNullOrEmpty(text) || text.Length <= maxLength)
            return text ?? string.Empty;

        return $"{text[..maxLength]}...";
    }
}