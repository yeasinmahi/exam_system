using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{
    public partial class StudentUi : Form
    {
        StudentManager studentManager = new StudentManager();
        LoadManager loadManager = new LoadManager();
        public StudentUi()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadSubjectToComboBox();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadSubjectToComboBox()
        {
            List<Subject> listSubjects = loadManager.LoadAllSubject();

            subjectComboBox.DisplayMember = "title";
            subjectComboBox.ValueMember = "code";
            subjectComboBox.DataSource = listSubjects;
        }
    }
}
