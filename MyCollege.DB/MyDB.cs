using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollege.DB
{
    public class MyDB
    {
        public static List<Student> StudentsList = new List<Student>();
        public static List<Course> CourseList = new List<Course>
        {
            new Course() {CourseName = "HTML"},
            new Course() {CourseName = "CSS"},
            new Course() {CourseName = "Core"},
            new Course() {CourseName = "OOP"},
            new Course() {CourseName = ".NET Basic"},
            new Course() {CourseName = "Python"},
            new Course() {CourseName = "SQL"}
        };
    }
}
