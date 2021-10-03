using MyCollege.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollegeSystem
{
    public partial class StudentControl : UserControl
    {
        public bool ChangingMode { get; set; }
        public bool ThereIsNoErrors { get; set; }

        public StudentControl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (ChangingMode && ThereIsNoErrors)
            {
                Student student = new Student();
                student.Courses = new List<Course>();
                student.Id = int.Parse(textBox1.Text);
                student.FirstName = textBox2.Text;
                student.LastName = textBox3.Text;
                student.EmailAdress = textBox5.Text;
                student.DOB = dateTimePicker1.Value;
                student.PhoneNumber = int.Parse(textBox4.Text);
                student.City = comboBox1.Text;
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    foreach (var course in MyDB.CourseList)
                    {
                        if (item == course.CourseName)
                        {
                            student.Courses.Add(course);
                        }
                    }
                }

                MyDB.StudentsList.Add(student);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.Text = "";
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(i, false);
                } 

                MessageBox.Show("Student added successfuly");
            }
            else
            {
                MessageBox.Show("First Valid Change Mode!");
            }

            ChangingMode = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangingMode = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"\d{9}$");
            if (!pattern.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(this.textBox1, "Invalid ID");
                ThereIsNoErrors = false;
            }

            else
            {
                errorProvider1.SetError(this.textBox1, string.Empty);
                ThereIsNoErrors = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^[A-z0-9.]+\@(gmail|yahoo|GMAIL|YAHOO)\.(com|COM)$");
            if (!pattern.IsMatch(textBox5.Text))
            {
                errorProvider2.SetError(this.textBox5, "Invalid Mail Adress");
                ThereIsNoErrors = false;
            }
            else
            {
                errorProvider2.SetError(this.textBox5, string.Empty);
                ThereIsNoErrors = true;
            }
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            searchStudent searchStudent = new searchStudent();
            searchStudent.Show(this);
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {

        }
    }
}
