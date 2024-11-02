using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class StudentDetailsForm : Form
    {
        private string connectionString;

        public StudentDetailsForm(int studentCode)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            LoadStudentDetails(studentCode);
        }
        private void StudentDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If using Approach 2 (exit on any form close)
            Application.Exit();

            // If using Approach 1 (exit on main form close only)
            // No need to add any special logic here
        }

        private void LoadStudentDetails(int studentCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);
                    ReviewStudentsForm.LoadLessonHeadersFromFile();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // Optionally, you can customize DataGridView column headers
                    dataGridView1.Columns["Name"].HeaderText = "Student Name";
                    dataGridView1.Columns["Lesson1Score"].HeaderText = ReviewStudentsForm.Lessonheaders.lesson1;
                    dataGridView1.Columns["Lesson2Score"].HeaderText = ReviewStudentsForm.Lessonheaders.lesson2;
                    dataGridView1.Columns["Lesson3Score"].HeaderText = ReviewStudentsForm.Lessonheaders.lesson3;
                    dataGridView1.Columns["Lesson4Score"].HeaderText = ReviewStudentsForm.Lessonheaders.lesson4;
                    dataGridView1.Columns["Lesson5Score"].HeaderText = ReviewStudentsForm.Lessonheaders.lesson5;
                    dataGridView1.Columns["GPA"].HeaderText = "GPA";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            // Load event logic (if any)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLoginForm loginForm = new StudentLoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
