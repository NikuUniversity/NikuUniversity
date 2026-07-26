using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;               // required for Task
using NikuUniversity.Core.Models;          // <- add the namespace that contains Course

namespace NikuUniversity.Core.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course?> GetCourseByIdAsync(int id);
        Task<bool> EnrollStudentAsync(int studentId, int courseId);
    }
}
