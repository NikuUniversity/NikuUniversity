using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NikuUniversity.Core.Enums;

namespace NikuUniversity.Core.Models.Student
{
    public class Student : BaseEntity
    {
        [Required]
        [StringLength(20)]
        public string StudentCode { get; set; } = string.Empty; // e.g., "NU-2026-001"

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
