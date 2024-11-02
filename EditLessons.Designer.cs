namespace class_mangemt
{
    partial class EditLessonsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLessonsForm));
            this.txtLesson1 = new System.Windows.Forms.TextBox();
            this.txtLesson2 = new System.Windows.Forms.TextBox();
            this.txtLesson3 = new System.Windows.Forms.TextBox();
            this.txtLesson4 = new System.Windows.Forms.TextBox();
            this.txtLesson5 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLesson1
            // 
            this.txtLesson1.Location = new System.Drawing.Point(12, 12);
            this.txtLesson1.Name = "txtLesson1";
            this.txtLesson1.Size = new System.Drawing.Size(260, 20);
            this.txtLesson1.TabIndex = 0;
            // 
            // txtLesson2
            // 
            this.txtLesson2.Location = new System.Drawing.Point(12, 38);
            this.txtLesson2.Name = "txtLesson2";
            this.txtLesson2.Size = new System.Drawing.Size(260, 20);
            this.txtLesson2.TabIndex = 1;
            // 
            // txtLesson3
            // 
            this.txtLesson3.Location = new System.Drawing.Point(12, 64);
            this.txtLesson3.Name = "txtLesson3";
            this.txtLesson3.Size = new System.Drawing.Size(260, 20);
            this.txtLesson3.TabIndex = 2;
            // 
            // txtLesson4
            // 
            this.txtLesson4.Location = new System.Drawing.Point(12, 90);
            this.txtLesson4.Name = "txtLesson4";
            this.txtLesson4.Size = new System.Drawing.Size(260, 20);
            this.txtLesson4.TabIndex = 3;
            // 
            // txtLesson5
            // 
            this.txtLesson5.Location = new System.Drawing.Point(12, 116);
            this.txtLesson5.Name = "txtLesson5";
            this.txtLesson5.Size = new System.Drawing.Size(260, 20);
            this.txtLesson5.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditLessonsForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLesson5);
            this.Controls.Add(this.txtLesson4);
            this.Controls.Add(this.txtLesson3);
            this.Controls.Add(this.txtLesson2);
            this.Controls.Add(this.txtLesson1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLessonsForm";
            this.Text = "Edit Lessons";
            this.Load += new System.EventHandler(this.EditLessonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtLesson1;
        private System.Windows.Forms.TextBox txtLesson2;
        private System.Windows.Forms.TextBox txtLesson3;
        private System.Windows.Forms.TextBox txtLesson4;
        private System.Windows.Forms.TextBox txtLesson5;
        private System.Windows.Forms.Button btnSave;
    }
}
