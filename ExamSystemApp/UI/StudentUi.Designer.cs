namespace ExamSystemApp.UI
{
    partial class StudentUi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clockLabel = new System.Windows.Forms.Label();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.numberOfQuestionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.CRadioButton = new System.Windows.Forms.RadioButton();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.ARadioButton = new System.Windows.Forms.RadioButton();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clockLabel);
            this.groupBox1.Controls.Add(this.QuestionPanel);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.subjectComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 439);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answar All The Question";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(463, 37);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(0, 13);
            this.clockLabel.TabIndex = 19;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Controls.Add(this.label9);
            this.QuestionPanel.Controls.Add(this.timeLabel);
            this.QuestionPanel.Controls.Add(this.numberOfQuestionLabel);
            this.QuestionPanel.Controls.Add(this.label8);
            this.QuestionPanel.Controls.Add(this.label7);
            this.QuestionPanel.Controls.Add(this.DRadioButton);
            this.QuestionPanel.Controls.Add(this.submitButton);
            this.QuestionPanel.Controls.Add(this.CRadioButton);
            this.QuestionPanel.Controls.Add(this.BRadioButton);
            this.QuestionPanel.Controls.Add(this.ARadioButton);
            this.QuestionPanel.Controls.Add(this.optionDTextBox);
            this.QuestionPanel.Controls.Add(this.optionBTextBox);
            this.QuestionPanel.Controls.Add(this.optionCTextBox);
            this.QuestionPanel.Controls.Add(this.optionATextBox);
            this.QuestionPanel.Controls.Add(this.questionTextBox);
            this.QuestionPanel.Controls.Add(this.label2);
            this.QuestionPanel.Controls.Add(this.label3);
            this.QuestionPanel.Controls.Add(this.label4);
            this.QuestionPanel.Controls.Add(this.label5);
            this.QuestionPanel.Controls.Add(this.label6);
            this.QuestionPanel.Location = new System.Drawing.Point(12, 98);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(576, 315);
            this.QuestionPanel.TabIndex = 7;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(293, 16);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 18;
            // 
            // numberOfQuestionLabel
            // 
            this.numberOfQuestionLabel.AutoSize = true;
            this.numberOfQuestionLabel.Location = new System.Drawing.Point(451, 16);
            this.numberOfQuestionLabel.Name = "numberOfQuestionLabel";
            this.numberOfQuestionLabel.Size = new System.Drawing.Size(13, 13);
            this.numberOfQuestionLabel.TabIndex = 17;
            this.numberOfQuestionLabel.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total 10 Question";
            // 
            // DRadioButton
            // 
            this.DRadioButton.AutoSize = true;
            this.DRadioButton.Location = new System.Drawing.Point(308, 179);
            this.DRadioButton.Name = "DRadioButton";
            this.DRadioButton.Size = new System.Drawing.Size(14, 13);
            this.DRadioButton.TabIndex = 14;
            this.DRadioButton.TabStop = true;
            this.DRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(438, 250);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 37);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Next";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CRadioButton
            // 
            this.CRadioButton.AutoSize = true;
            this.CRadioButton.Location = new System.Drawing.Point(69, 179);
            this.CRadioButton.Name = "CRadioButton";
            this.CRadioButton.Size = new System.Drawing.Size(14, 13);
            this.CRadioButton.TabIndex = 13;
            this.CRadioButton.TabStop = true;
            this.CRadioButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(308, 116);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(14, 13);
            this.BRadioButton.TabIndex = 12;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // ARadioButton
            // 
            this.ARadioButton.AutoSize = true;
            this.ARadioButton.Location = new System.Drawing.Point(69, 116);
            this.ARadioButton.Name = "ARadioButton";
            this.ARadioButton.Size = new System.Drawing.Size(14, 13);
            this.ARadioButton.TabIndex = 11;
            this.ARadioButton.TabStop = true;
            this.ARadioButton.UseVisualStyleBackColor = true;
            // 
            // optionDTextBox
            // 
            this.optionDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionDTextBox.Location = new System.Drawing.Point(365, 179);
            this.optionDTextBox.Multiline = true;
            this.optionDTextBox.Name = "optionDTextBox";
            this.optionDTextBox.ReadOnly = true;
            this.optionDTextBox.Size = new System.Drawing.Size(157, 29);
            this.optionDTextBox.TabIndex = 10;
            // 
            // optionBTextBox
            // 
            this.optionBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionBTextBox.Location = new System.Drawing.Point(365, 116);
            this.optionBTextBox.Multiline = true;
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.ReadOnly = true;
            this.optionBTextBox.Size = new System.Drawing.Size(157, 29);
            this.optionBTextBox.TabIndex = 9;
            // 
            // optionCTextBox
            // 
            this.optionCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionCTextBox.Location = new System.Drawing.Point(119, 179);
            this.optionCTextBox.Multiline = true;
            this.optionCTextBox.Name = "optionCTextBox";
            this.optionCTextBox.ReadOnly = true;
            this.optionCTextBox.Size = new System.Drawing.Size(157, 29);
            this.optionCTextBox.TabIndex = 8;
            // 
            // optionATextBox
            // 
            this.optionATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionATextBox.Location = new System.Drawing.Point(119, 116);
            this.optionATextBox.Multiline = true;
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.ReadOnly = true;
            this.optionATextBox.Size = new System.Drawing.Size(157, 29);
            this.optionATextBox.TabIndex = 7;
            // 
            // questionTextBox
            // 
            this.questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTextBox.Location = new System.Drawing.Point(92, 58);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(455, 52);
            this.questionTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(201, 208);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 39);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(228, 37);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(173, 21);
            this.subjectComboBox.TabIndex = 6;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Remaining Time";
            // 
            // StudentUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.RadioButton DRadioButton;
        private System.Windows.Forms.RadioButton CRadioButton;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton ARadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numberOfQuestionLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
    }
}