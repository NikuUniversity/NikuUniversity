namespace NikuUniversity.Core.DTOs;

public record CourseSummaryDto(
    int Id,
    string CourseCode,
    string Title,
    string DepartmentName,
    string InstructorName,
    int Credits,
    decimal TuitionFee
);

public record StudentEnrollmentRequestDto(
    int StudentId,
    int CourseId
);

public record RegistrationResultDto(
    bool Success,
    string Message,
    int? EnrollmentId
);