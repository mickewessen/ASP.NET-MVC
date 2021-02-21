using System;
using System.Collections.Generic;
using UniversityPortal.Data;

#nullable disable

namespace UniversityPortal.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassCourses = new HashSet<SchoolClassCourse>();
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }
        public string ClassName { get; set; }

        public string TeacherId { get; set; }
        public DateTime ClassStart { get; set; }
        public DateTime ClassEnd { get; set; }

        public virtual ApplicationUser Teacher { get; set; }

        public virtual ICollection<SchoolClassCourse> SchoolClassCourses { get; set; }
        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
