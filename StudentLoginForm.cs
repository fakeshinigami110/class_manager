using MySql.Data.MySqlClient;
using System;
using System.Configuration; // Required for ConfigurationManager
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class StudentLoginForm : Form
    {
        private string connectionString;

        public StudentLoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

            // Set default text and hook up event handler
            txtStudentCode.Text = "student code";
            
        }
        private void StudentLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If using Approach 2 (exit on any form close)
            Application.Exit();

            // If using Approach 1 (exit on main form close only)
            // No need to add any special logic here
        }

        private void StudentLoginForm_Load(object sender, EventArgs e)
        {
            
        }

       
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Validate the input
            string inputText = txtStudentCode.Text.Trim();

            if (inputText == "student code")
            {
                MessageBox.Show("Please enter a valid student code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(inputText, out int studentCode))
            {
                // Open the StudentDetailsForm with the entered student code
                StudentDetailsForm detailsForm = new StudentDetailsForm(studentCode);
                detailsForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Please enter a valid student code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 main = new Form1();
            //main.Show();
            this.Hide();
        }

       

        private void txtStudentCode_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
