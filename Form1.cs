using System;
using System.Drawing;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLoginForm loginForm = new StudentLoginForm();
            loginForm.Show();
            //this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherLoginForm teacherLogin = new TeacherLoginForm();
            teacherLogin.Show();
            //this.Hide();
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string github_url = "https://github.com/fakeshinigami110/class-managment";
            System.Diagnostics.Process.Start(github_url);
        }
    }
}
