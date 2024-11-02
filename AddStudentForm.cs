using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class AddStudentForm : Form
    {
        private string connectionString;

        public AddStudentForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }
        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If using Approach 2 (exit on any form close)
            Application.Exit();

            // If using Approach 1 (exit on main form close only)
            // No need to add any special logic here
        }


        private void btnSave_Click(object sender, EventArgs e)
{
    using (MySqlConnection conn = new MySqlConnection(connectionString))
    {
        try
        {
            conn.Open();
            float GPA = (int.Parse(txtLesson1Score.Text) + int.Parse(txtLesson3Score.Text) + int.Parse(txtLesson2Score.Text)
                                + int.Parse(txtLesson4Score.Text) + int.Parse(txtLesson5Score.Text)) / 5.0f;
            
            // Step 1: Fetch the current maximum student code
            int maxStudentCode = GetMaxStudentCode(conn);
            int newStudentCode = maxStudentCode + 1;

            // Debugging output
            MessageBox.Show($"New StudentCode: {newStudentCode}");

            // Step 2: Insert the new student with the auto-generated student code
            string query = "INSERT INTO Students (StudentCode, Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA) " +
                           "VALUES (@StudentCode, @Name, @Lesson1Score, @Lesson2Score, @Lesson3Score, @Lesson4Score, @Lesson5Score, @GPA)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentCode", newStudentCode);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Lesson1Score", int.Parse(txtLesson1Score.Text));
            cmd.Parameters.AddWithValue("@Lesson2Score", int.Parse(txtLesson2Score.Text));
            cmd.Parameters.AddWithValue("@Lesson3Score", int.Parse(txtLesson3Score.Text));
            cmd.Parameters.AddWithValue("@Lesson4Score", int.Parse(txtLesson4Score.Text));
            cmd.Parameters.AddWithValue("@Lesson5Score", int.Parse(txtLesson5Score.Text));
            cmd.Parameters.AddWithValue("@GPA", GPA);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Student added successfully!");
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}

// Method to fetch maximum student code from the database
private int GetMaxStudentCode(MySqlConnection conn)
{
    string query = "SELECT MAX(StudentCode) FROM Students";
    MySqlCommand cmd = new MySqlCommand(query, conn);
    object result = cmd.ExecuteScalar();
    if (result != null && result != DBNull.Value)
    {
        return Convert.ToInt32(result);
    }
    return 0; // Return 0 if no student codes exist yet
}

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }

}
