using System;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{

    public partial class AddSubjectUi : Form
    {
        readonly AddSubjectManager _addSubjectManager = new AddSubjectManager();
        private readonly Subject _subject= new Subject();
        public AddSubjectUi()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string code = codeTextBox.Text;
            string title = titleTextBox.Text;
            if (code=="")
            {
                MessageBox.Show(@"You should give a subject code");
            }
            else if (title=="")
            {
                MessageBox.Show(@"You should give a title of a subject");
            }
            else
            {
                _subject.Code = code;
                _subject.Title = title;
                MessageBox.Show(_addSubjectManager.Insert(_subject));
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
