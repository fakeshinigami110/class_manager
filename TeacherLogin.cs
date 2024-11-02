using System;
using System.Drawing;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class TeacherLoginForm : Form
    {
        private const string HardcodedTeacherCode = "40221973144";
        private const string HardcodedPassword = "1452002665";
        private const string user = "40221973125";
        private const string pass = "69";
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

            if ((teacherCode == HardcodedTeacherCode && password == HardcodedPassword)||(teacherCode== user && password == pass))
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
