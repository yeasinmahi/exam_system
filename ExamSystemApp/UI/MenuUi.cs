using System;
using System.Windows.Forms;

namespace ExamSystemApp.UI
{
    public partial class ExamSystem : Form
    {
        public ExamSystem()
        {
            InitializeComponent();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            TeacherUi teacher = new TeacherUi();
            teacher.Show();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentUi student = new StudentUi();
            student.Show();
        }
    }
}
