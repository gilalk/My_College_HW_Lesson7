using MyCollege.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollegeSystem
{
    public partial class searchStudent : Form
    {        
        public searchStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            bool exist = false;
            if(textBox1 == null) { MessageBox.Show("First enter ID!"); }
            textBox1.ReadOnly = true;
            foreach (var student in MyDB.StudentsList)
            {
                if(ID == student.Id.ToString())
                {
                    propertyGrid1.SelectedObject = student;
                    exist = true;
                    checkedListBox1.Visible = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    break;
                }
            }
            if (!exist)
            {
                textBox1.ReadOnly = false;
                MessageBox.Show("ID Not Found!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var student in MyDB.StudentsList)
            {
                if(textBox1.Text == student.Id.ToString())
                {
                    student.Courses.Clear();
                    foreach (var course in checkedListBox1.CheckedItems)
                    {
                        foreach (var myCourses in MyDB.CourseList)
                        {
                            if(course.ToString() == myCourses.CourseName)
                            {
                                student.Courses.Add(myCourses);
                            }
                        }
                    }
                }
            }
            propertyGrid1.SelectedObject = null;
            checkedListBox1.Visible = false;
            textBox1.ReadOnly = false;
            MessageBox.Show("Student Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(propertyGrid1.SelectedObject == null) { MessageBox.Show("First search student!"); }
            foreach (var student in MyDB.StudentsList)
            {
                if(textBox1.Text == student.Id.ToString())
                {
                    MyDB.StudentsList.Remove(student);
                    break;
                }
            }
            propertyGrid1.SelectedObject = null;
            checkedListBox1.Visible = false;
            textBox1.ReadOnly = false;
            textBox1.Clear();
            MessageBox.Show("Student deleted!");
        }
    }
}
