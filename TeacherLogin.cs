using System;
using System.Drawing;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class TeacherLoginForm : Form
    {
        private const string HardcodedTeacherCode = "12345678";
        private const string HardcodedPassword = "12345678";
        public TeacherLoginForm()
        {
            InitializeComponent();
        }
        private void TeacherLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string teacherCode = txtTeacherCode.Text;
            string password = txtPassword.Text;

            if ((teacherCode == HardcodedTeacherCode && password == HardcodedPassword))
            {
                ReviewStudentsForm studentsForm = new ReviewStudentsForm();
               
                studentsForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid teacher code or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeacherLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
