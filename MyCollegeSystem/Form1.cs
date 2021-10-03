using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCollege.DB;

namespace MyCollegeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new StudentControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.StudentsList;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(dataGridView1);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
