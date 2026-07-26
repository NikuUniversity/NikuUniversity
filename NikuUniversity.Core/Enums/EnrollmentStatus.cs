using System;
using System.Collections.Generic;
using System.Text;

namespace NikuUniversity.Core.Enums
{
    public enum EnrollmentStatus
    {
        Pending = 0,
        Active = 1,
        Completed = 2,
        Dropped = 3,
        Withdrawn = 4
    }

    public enum PaymentStatus
    {
        Unpaid = 0,
        Partial = 1,
        Paid = 2,
        Overdue = 3
    }

    public enum CourseLevel
    {
        Undergraduate = 1,
        Postgraduate = 2,
        Diploma = 3,
        Certification = 4
    }

}
