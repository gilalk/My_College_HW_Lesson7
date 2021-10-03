using System;
using System.Collections.Generic;

namespace MyCollege.DB
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public string City { get; set; }
        public int TuitionPaid { get; set; }
        public int TuitionLeftToPay { get; set; }
        public List<Course> Courses { get; set; }

    }
}
