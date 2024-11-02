using System;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class EditLessonsForm : Form
    {
        public string Lesson1 { get; private set; }
        public string Lesson2 { get; private set; }
        public string Lesson3 { get; private set; }
        public string Lesson4 { get; private set; }
        public string Lesson5 { get; private set; }

        public EditLessonsForm(string lesson1, string lesson2, string lesson3, string lesson4, string lesson5)
        {
            InitializeComponent();
            txtLesson1.Text = lesson1;
            txtLesson2.Text = lesson2;
            txtLesson3.Text = lesson3;
            txtLesson4.Text = lesson4;
            txtLesson5.Text = lesson5;
        }
        private void EditLessonsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If using Approach 2 (exit on any form close)
            Application.Exit();

            // If using Approach 1 (exit on main form close only)
            // No need to add any special logic here
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Lesson1 = txtLesson1.Text;
            Lesson2 = txtLesson2.Text;
            Lesson3 = txtLesson3.Text;
            Lesson4 = txtLesson4.Text;
            Lesson5 = txtLesson5.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditLessonsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
