using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace NikuUniversity.Common
{
    public static class CommonHelper
{
    // Generate Student ID / Employee ID
    public static string GenerateStudentId(string prefix = "NIKU", int year = 0)
    {
        year = year == 0 ? DateTime.Now.Year : year;
        string random = RandomNumberGenerator.GetInt32(1000, 9999).ToString();
        return $"{prefix}{year}{random}";
    }

    // Generate strong password hash (recommended)
    public static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    // Verify password
    public static bool VerifyPassword(string password, string hash)
    {
        return HashPassword(password) == hash;
    }

    // Generate OTP
    public static string GenerateOTP(int length = 6)
    {
        return RandomNumberGenerator.GetInt32(0, (int)Math.Pow(10, length))
            .ToString($"D{length}");
    }

    // Clean / Sanitize string
    public static string CleanString(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        return Regex.Replace(input.Trim(), @"\s+", " ");
    }

    // Validate Email
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) return false;
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
    }

    // Validate Phone (Indian format example)
    public static bool IsValidPhone(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone)) return false;
        return Regex.IsMatch(phone, @"^[6-9]\d{9}$");
    }

    // Convert to Title Case
    public static string ToTitleCase(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return text;
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
    }

    // Calculate Age
    public static int CalculateAge(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var age = today.Year - dateOfBirth.Year;
        if (dateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    // Format Currency (Indian Rupee)
    public static string FormatCurrency(decimal amount)
    {
        return string.Format(new System.Globalization.CultureInfo("en-IN"), "{0:C}", amount);
    }

    // Generate slug for URLs
    public static string GenerateSlug(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return string.Empty;
        text = text.ToLowerInvariant();
        text = Regex.Replace(text, @"[^a-z0-9\s-]", "");
        text = Regex.Replace(text, @"\s+", "-").Trim('-');
        return text;
    }
}

2. Date & Time Helpers
C#public static class DateHelper
{
    public static string GetAcademicYear(DateTime? date = null)
    {
        date ??= DateTime.Now;
        int year = date.Value.Month >= 7 ? date.Value.Year : date.Value.Year - 1;
        return $"{year}-{year + 1}";
    }

    public static string GetCurrentSemester()
    {
        int month = DateTime.Now.Month;
        return month >= 7 && month <= 12 ? "Odd" : "Even";
    }

    public static bool IsValidAcademicYear(string academicYear)
    {
        return Regex.IsMatch(academicYear, @"^\d{4}-\d{4}$");
    }
}

3. Pagination Helper
C#public class PaginatedResult<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public bool HasPrevious => PageNumber > 1;
    public bool HasNext => PageNumber < TotalPages;
}

public static class PaginationHelper
{
    public static PaginatedResult<T> ToPaginatedList<T>(
        IQueryable<T> source, int pageNumber, int pageSize)
    {
        var count = source.Count();
        var items = source.Skip((pageNumber - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

        return new PaginatedResult<T>
        {
            Items = items,
            TotalCount = count,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }
}

4. API Response Wrapper (Very Common)
C#public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
    public List<string>? Errors { get; set; }

    public static ApiResponse<T> Ok(T data, string message = "Success")
    {
        return new ApiResponse<T> { Success = true, Message = message, Data = data };
    }

    public static ApiResponse<T> Fail(string message, List<string>? errors = null)
    {
        return new ApiResponse<T> { Success = false, Message = message, Errors = errors };
    }
}

5. File Upload Helper
C#public static class FileHelper
{
    public static async Task<string> SaveFileAsync(IFormFile file, string folderName = "uploads")
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File is empty");

        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);
        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        var uniqueFileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);

        return $"/{folderName}/{uniqueFileName}";
    }

    public static bool IsValidImage(IFormFile file)
    {
        var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };
        var extension = Path.GetExtension(file.FileName).ToLower();
        return allowed.Contains(extension) && file.Length < 5 * 1024 * 1024; // 5 MB
    }
}

Most Frequently Used Functions Summary













































FunctionPurposeGenerateStudentId()Auto generate Student IDHashPassword() / VerifyPassword()Secure password handlingGenerateOTP()For email/SMS verificationIsValidEmail() / IsValidPhone()ValidationGetAcademicYear()Current academic yearToPaginatedList()Server-side paginationApiResponse<T>Standard API responseSaveFileAsync()Upload documents / photosCalculateAge()Age calculation from DOB

Would you like me to also give you:

Email sending functions
JWT Token generation functions
Excel import/export functions
Result / Grade calculation functions

Just tell me which ones you need next.
