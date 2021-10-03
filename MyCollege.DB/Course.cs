using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollege.DB
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime DateOfStart { get; set; }
        public int NumberOfSessions { get; set; }

    }
}
