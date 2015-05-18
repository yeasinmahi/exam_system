using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{
    public partial class TeacherUi : Form
    {
        TeacherManager _teacherManager = new TeacherManager();
        readonly LoadManager _loadManager = new LoadManager();
        public TeacherUi()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            LoadSubjectToComboBox();
        }

        private void addMoreButton_Click(object sender, EventArgs e)
        {
            AddSubjectUi addSubject = new AddSubjectUi();
            addSubject.Show();
        }
        private void LoadSubjectToComboBox()
        {
            List<Subject> listSubjects = _loadManager.LoadAllSubject();

            subjectComboBox.DisplayMember = "title";
            subjectComboBox.ValueMember = "code";
            subjectComboBox.DataSource = listSubjects;
        }
    }
}
