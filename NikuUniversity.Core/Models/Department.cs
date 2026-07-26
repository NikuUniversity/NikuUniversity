using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NikuUniversity.Core.Models
{
    public class Department : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // e.g., "Computer Science & IT"

        [StringLength(10)]
        public string Code { get; set; } = string.Empty; // e.g., "CS"

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }

    public class Instructor : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty; // e.g., "Senior Professor"

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
