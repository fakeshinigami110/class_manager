using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System;
using System.Xml.Linq;

namespace class_mangemt
{
    public partial class EditStudentForm : Form
    {
        private string connectionString;
        private int studentCode;

        public EditStudentForm(int studentCode)
        {
            InitializeComponent();
            this.studentCode = studentCode;
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            LoadStudentDetails();
        }
        private void EditStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If using Approach 2 (exit on any form close)
            Application.Exit();

            // If using Approach 1 (exit on main form close only)
            // No need to add any special logic here
        }
        private void LoadStudentDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtLesson1.Text = reader["Lesson1Score"].ToString();
                        txtLesson2.Text = reader["Lesson2Score"].ToString();
                        txtLesson3.Text = reader["Lesson3Score"].ToString();
                        txtLesson4.Text = reader["Lesson4Score"].ToString();
                        txtLesson5.Text = reader["Lesson5Score"].ToString();
                        txtGPA.Text = reader["GPA"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Calculate GPA
                    int lesson1Score = int.Parse(txtLesson1.Text);
                    int lesson2Score = int.Parse(txtLesson2.Text);
                    int lesson3Score = int.Parse(txtLesson3.Text);
                    int lesson4Score = int.Parse(txtLesson4.Text);
                    int lesson5Score = int.Parse(txtLesson5.Text);
                    float gpa = (lesson1Score + lesson2Score + lesson3Score + lesson4Score + lesson5Score) / 5.0f;

                    // Update student data in the database
                    string query = "UPDATE Students SET Name = @Name, Lesson1Score = @Lesson1Score, Lesson2Score = @Lesson2Score, Lesson3Score = @Lesson3Score, Lesson4Score = @Lesson4Score, Lesson5Score = @Lesson5Score, GPA = @GPA WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Lesson1Score", lesson1Score);
                    cmd.Parameters.AddWithValue("@Lesson2Score", lesson2Score);
                    cmd.Parameters.AddWithValue("@Lesson3Score", lesson3Score);
                    cmd.Parameters.AddWithValue("@Lesson4Score", lesson4Score);
                    cmd.Parameters.AddWithValue("@Lesson5Score", lesson5Score);
                    cmd.Parameters.AddWithValue("@GPA", gpa);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
