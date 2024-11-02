using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static class_mangemt.ReviewStudentsForm;

namespace class_mangemt
{
    public partial class ReviewStudentsForm : Form
    {
        private string connectionString;
        private int currentPage = 1;
        private int pageSize = 10;


        public static class Lessonheaders
        {
            // Static lesson names
            public static string lesson1 = "Math";
            public static string lesson2 = "Science";
            public static string lesson3 = "History";
            public static string lesson4 = "Art";
            public static string lesson5 = "Physical Education";
        }
        public ReviewStudentsForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int offset = (currentPage - 1) * pageSize;
                    string query = $"SELECT StudentCode, Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students LIMIT {pageSize} OFFSET {offset}";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Add Edit button column if not already added
                    if (!dataGridView1.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                        {
                            Name = "Edit",
                            HeaderText = "",
                            Text = "Edit",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView1.Columns.Add(editButton);
                    }

                    // Add Delete button column if not already added
                    if (!dataGridView1.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView1.Columns.Add(deleteButton);
                    }

                    // Customize DataGridView column headers using static lesson names
                    dataGridView1.Columns["StudentCode"].HeaderText = "Student Code";
                    dataGridView1.Columns["Name"].HeaderText = "Student Name";
                    dataGridView1.Columns["Lesson1Score"].HeaderText = Lessonheaders.lesson1;
                    dataGridView1.Columns["Lesson2Score"].HeaderText = Lessonheaders.lesson2;
                    dataGridView1.Columns["Lesson3Score"].HeaderText = Lessonheaders.lesson3;
                    dataGridView1.Columns["Lesson4Score"].HeaderText = Lessonheaders.lesson4;
                    dataGridView1.Columns["Lesson5Score"].HeaderText = Lessonheaders.lesson5;
                    dataGridView1.Columns["GPA"].HeaderText = "GPA";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    int studentCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentCode"].Value);
                    EditStudentForm editForm = new EditStudentForm(studentCode);
                    editForm.ShowDialog();
                    LoadStudentData();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    int studentCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentCode"].Value);
                    DeleteStudent(studentCode);
                    LoadStudentData();
                }
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadStudentData();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadStudentData();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
            LoadStudentData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadLessonHeadersFromFile();
        }
        public static void LoadLessonHeadersFromFile()
        {
            string filePath = "lessons.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Lessonheaders.lesson1 = reader.ReadLine();
                    Lessonheaders.lesson2 = reader.ReadLine();
                    Lessonheaders.lesson3 = reader.ReadLine();
                    Lessonheaders.lesson4 = reader.ReadLine();
                    Lessonheaders.lesson5 = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lesson headers: " + ex.Message);
            }
        }

        private void ReviewStudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "lessons.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(Lessonheaders.lesson1);
                    writer.WriteLine(Lessonheaders.lesson2);
                    writer.WriteLine(Lessonheaders.lesson3);
                    writer.WriteLine(Lessonheaders.lesson4);
                    writer.WriteLine(Lessonheaders.lesson5);
                }
              //  MessageBox.Show("Lesson headers saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving lesson headers: " + ex.Message);
            }

        }

        private void btnEditLessons_Click(object sender, EventArgs e)
        {
            EditLessonsForm editLessonsForm = new EditLessonsForm(
                Lessonheaders.lesson1,
                Lessonheaders.lesson2,
                Lessonheaders.lesson3,
                Lessonheaders.lesson4,
                Lessonheaders.lesson5 );

            if (editLessonsForm.ShowDialog() == DialogResult.OK)
            {
                Lessonheaders.lesson1 = editLessonsForm.Lesson1;
                Lessonheaders.lesson2 = editLessonsForm.Lesson2;
                Lessonheaders.lesson3 = editLessonsForm.Lesson3;
                Lessonheaders.lesson4 = editLessonsForm.Lesson4;
                Lessonheaders.lesson5 = editLessonsForm.Lesson5;

                LoadStudentData();
            }
        }


        private void DeleteStudent(int studentCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Students WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        


        private void ReviewStudentsForm_Load(object sender, EventArgs e)
        {
            LoadLessonHeadersFromFile();

        }
    }
}
