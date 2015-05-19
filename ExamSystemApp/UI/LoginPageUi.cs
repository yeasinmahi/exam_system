using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystemApp.UI
{
    public partial class LoginPageUi : Form
    {
        public LoginPageUi()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.ToLower();
            string password = PasswordTextBox.Text;
            if (userName=="")
            {
                MessageBox.Show("Username Can Not Be Blanked");
            }
            else if (password=="")
            {
                MessageBox.Show("Password Can Not Be Blanked");
            }
            else
            {
                if (userName=="teacher" && password=="12345")
                {
                    TeacherUi teacherUi = new TeacherUi();
                    teacherUi.Show();
                    
                }
                else if (userName == "student" && password == "12345")
                {
                    StudentUi studentUi = new StudentUi();
                    studentUi.Show();
                }
                else
                {
                    MessageBox.Show("You Enter Wrong Username Or Password");
                }
            }

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registratin Page Is Not Ready");
        }
    }
}
