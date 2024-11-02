namespace class_mangemt
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLesson1Score;
        private System.Windows.Forms.TextBox txtLesson2Score;
        private System.Windows.Forms.TextBox txtLesson3Score;
        private System.Windows.Forms.TextBox txtLesson4Score;
        private System.Windows.Forms.TextBox txtLesson5Score;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLesson1Score = new System.Windows.Forms.TextBox();
            this.txtLesson2Score = new System.Windows.Forms.TextBox();
            this.txtLesson3Score = new System.Windows.Forms.TextBox();
            this.txtLesson4Score = new System.Windows.Forms.TextBox();
            this.txtLesson5Score = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            // 
            // txtLesson1Score
            // 
            this.txtLesson1Score.Location = new System.Drawing.Point(100, 60);
            this.txtLesson1Score.Name = "txtLesson1Score";
            this.txtLesson1Score.Size = new System.Drawing.Size(200, 20);
            this.txtLesson1Score.TabIndex = 1;
            this.txtLesson1Score.Text = "Lesson 1 Score";
            // 
            // txtLesson2Score
            // 
            this.txtLesson2Score.Location = new System.Drawing.Point(100, 90);
            this.txtLesson2Score.Name = "txtLesson2Score";
            this.txtLesson2Score.Size = new System.Drawing.Size(200, 20);
            this.txtLesson2Score.TabIndex = 2;
            this.txtLesson2Score.Text = "Lesson 2 Score";
            // 
            // txtLesson3Score
            // 
            this.txtLesson3Score.Location = new System.Drawing.Point(100, 120);
            this.txtLesson3Score.Name = "txtLesson3Score";
            this.txtLesson3Score.Size = new System.Drawing.Size(200, 20);
            this.txtLesson3Score.TabIndex = 3;
            this.txtLesson3Score.Text = "Lesson 3 Score";
            // 
            // txtLesson4Score
            // 
            this.txtLesson4Score.Location = new System.Drawing.Point(100, 150);
            this.txtLesson4Score.Name = "txtLesson4Score";
            this.txtLesson4Score.Size = new System.Drawing.Size(200, 20);
            this.txtLesson4Score.TabIndex = 4;
            this.txtLesson4Score.Text = "Lesson 4 Score";
            // 
            // txtLesson5Score
            // 
            this.txtLesson5Score.Location = new System.Drawing.Point(100, 180);
            this.txtLesson5Score.Name = "txtLesson5Score";
            this.txtLesson5Score.Size = new System.Drawing.Size(200, 20);
            this.txtLesson5Score.TabIndex = 5;
            this.txtLesson5Score.Text = "Lesson 5 Score";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(100, 210);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(200, 20);
            this.txtGPA.TabIndex = 6;
            this.txtGPA.Text = "GPA";
            this.txtGPA.TextChanged += new System.EventHandler(this.txtGPA_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtLesson5Score);
            this.Controls.Add(this.txtLesson4Score);
            this.Controls.Add(this.txtLesson3Score);
            this.Controls.Add(this.txtLesson2Score);
            this.Controls.Add(this.txtLesson1Score);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
