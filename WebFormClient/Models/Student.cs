using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormClient.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Address { get; set; }

        public IEnumerable<Enrollment> Enrollments { get; set; }

    }
}