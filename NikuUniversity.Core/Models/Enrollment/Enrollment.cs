using System.Text;
using global::NikuUniversity.Core.Enums;

using System.ComponentModel.DataAnnotations;

namespace NikuUniversity.Core.Models.Enrollment
{
    public class Enrollment : BaseEntity
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Active;

        [Range(0.0, 100.0)]
        public decimal? FinalGrade { get; set; }

        public string? GradeLetter { get; set; } // e.g., "A+", "B"
    }
}