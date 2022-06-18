using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSytem
{
    public partial class StudentForm : Form
    {
        StudentClass student = new StudentClass();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // add new student
            string name = txtName.Text;
            string sname = txtSurname.Text;
            string mail = txtMail.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";
            MessageBox.Show("Student has saved");
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
