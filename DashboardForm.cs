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
    public partial class DashboardForm : Form
    {
       
        public DashboardForm()
        {
            InitializeComponent();
           
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

       

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentForm());
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            openChildForm(new InstructorForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
               activeForm.Close();
            pnlMain.Controls.Add(pnlCover);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagementForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();   
        }
    }
}
