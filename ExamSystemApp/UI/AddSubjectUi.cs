using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{

    public partial class AddSubjectUi : Form
    {
        AddSubjectManager addSubjectManager = new AddSubjectManager();
        private Subject subject= new Subject();
        public AddSubjectUi()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string code = codeTextBox.Text;
            string title = titleTextBox.Text;
            if (code=="")
            {
                MessageBox.Show("You should give a subject code");
            }
            else if (title=="")
            {
                MessageBox.Show("You should give a title of a subject");
            }
            else
            {
                subject.code = code;
                subject.title = title;
                MessageBox.Show(addSubjectManager.Insert(subject));
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
