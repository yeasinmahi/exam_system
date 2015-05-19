using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{
    public partial class TeacherUi : Form
    {
        readonly LoadManager _loadManager = new LoadManager();
        readonly TeacherManager _teacherManager = new TeacherManager();
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
            Dispose();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string question = questionTextBox.Text;
            string optionA = optionATextBox.Text;
            string optionB = optionBTextBox.Text;
            string optionC = optionCTextBox.Text;
            string optionD = optionDTextBox.Text;
            string answer = "";
            if (answarComboBox.SelectedItem!=null)
            {
                answer = answarComboBox.SelectedItem.ToString();
            }
            int sid = 0;
            if (subjectComboBox.SelectedItem != null)
            {
                sid = Convert.ToInt32(subjectComboBox.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show(@"You Should Select A Subject First");
            }

            if (question=="")
            {
                MessageBox.Show(@"Cannot Be Blanked The Question Field");
            }
            else if (optionA == "")
            {
                MessageBox.Show(@"Cannot Be Blanked The Option A Field");
            }
            else if (optionB == "")
            {
                MessageBox.Show(@"Cannot Be Blanked The Option B Field");
            }
            else if (optionC == "")
            {
                MessageBox.Show(@"Cannot Be Blanked The Option C Field");
            }
            else if (optionD == "")
            {
                MessageBox.Show(@"Cannot Be Blanked The Option D Field");
            }
            else if (answer == "")
            {
                MessageBox.Show(@"Should Be Select The Correct Answer");
            }
            else
            {
                QuestionAndAnswer questionAndAnswer = new QuestionAndAnswer();
                questionAndAnswer.Sid = sid;
                questionAndAnswer.Question = question;
                questionAndAnswer.OptionA = optionA;
                questionAndAnswer.OptionB = optionB;
                questionAndAnswer.OptionC = optionC;
                questionAndAnswer.OptionD = optionD;
                questionAndAnswer.Answer = answer;
                MessageBox.Show(_teacherManager.Insert(questionAndAnswer));

            }


        }

        private void LoadSubjectToComboBox()
        {
            List<Subject> listSubjects = _loadManager.LoadAllSubject();

            subjectComboBox.DisplayMember = "title";
            subjectComboBox.ValueMember = "sid";
            subjectComboBox.DataSource = listSubjects;
        }
    }
}
