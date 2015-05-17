using System;
using System.Windows.Forms;

namespace ExamSystemApp.UI
{
    public partial class TeacherUi : Form
    {
        public TeacherUi()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            
        }

        private void addMoreButton_Click(object sender, EventArgs e)
        {
            AddSubjectUi addSubject = new AddSubjectUi();
            addSubject.Show();
        }
    }
}
