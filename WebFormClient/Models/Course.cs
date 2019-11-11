using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormClient.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public IEnumerable<Enrollment> Enrollments { get; set; }

    }
}