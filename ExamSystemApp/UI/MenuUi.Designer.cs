namespace ExamSystemApp.UI
{
    partial class ExamSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teacherButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherButton
            // 
            this.teacherButton.Location = new System.Drawing.Point(79, 104);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(116, 71);
            this.teacherButton.TabIndex = 0;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(223, 103);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(116, 71);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // ExamSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 327);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.teacherButton);
            this.Name = "ExamSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button studentButton;
    }
}

