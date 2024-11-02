namespace class_mangemt
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLesson1;
        private System.Windows.Forms.TextBox txtLesson2;
        private System.Windows.Forms.TextBox txtLesson3;
        private System.Windows.Forms.TextBox txtLesson4;
        private System.Windows.Forms.TextBox txtLesson5;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLesson1 = new System.Windows.Forms.TextBox();
            this.txtLesson2 = new System.Windows.Forms.TextBox();
            this.txtLesson3 = new System.Windows.Forms.TextBox();
            this.txtLesson4 = new System.Windows.Forms.TextBox();
            this.txtLesson5 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtLesson1
            // 
            this.txtLesson1.Location = new System.Drawing.Point(150, 70);
            this.txtLesson1.Name = "txtLesson1";
            this.txtLesson1.Size = new System.Drawing.Size(200, 20);
            this.txtLesson1.TabIndex = 1;
            // 
            // txtLesson2
            // 
            this.txtLesson2.Location = new System.Drawing.Point(150, 110);
            this.txtLesson2.Name = "txtLesson2";
            this.txtLesson2.Size = new System.Drawing.Size(200, 20);
            this.txtLesson2.TabIndex = 2;
            // 
            // txtLesson3
            // 
            this.txtLesson3.Location = new System.Drawing.Point(150, 150);
            this.txtLesson3.Name = "txtLesson3";
            this.txtLesson3.Size = new System.Drawing.Size(200, 20);
            this.txtLesson3.TabIndex = 3;
            // 
            // txtLesson4
            // 
            this.txtLesson4.Location = new System.Drawing.Point(150, 190);
            this.txtLesson4.Name = "txtLesson4";
            this.txtLesson4.Size = new System.Drawing.Size(200, 20);
            this.txtLesson4.TabIndex = 4;
            // 
            // txtLesson5
            // 
            this.txtLesson5.Location = new System.Drawing.Point(150, 230);
            this.txtLesson5.Name = "txtLesson5";
            this.txtLesson5.Size = new System.Drawing.Size(200, 20);
            this.txtLesson5.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(150, 270);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(200, 20);
            this.txtGPA.TabIndex = 6;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtLesson5);
            this.Controls.Add(this.txtLesson4);
            this.Controls.Add(this.txtLesson3);
            this.Controls.Add(this.txtLesson2);
            this.Controls.Add(this.txtLesson1);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentForm";
            this.Text = "Edit Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtGPA;
    }
}
