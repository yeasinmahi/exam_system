using System;
using System.Windows.Forms;

namespace ExamSystemApp.UI
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private const string Yeasin = "Md. Yeasin Arafat";
        private const string Tarik = "\nMd. Tarik Rahman";
        private const string Farida = "\nFarida Yeasmin";
        private const string Ananna = "\nAnanna Rahman";
        private int _yeasinCounter;
        private int _tarikCounter;
        private int _faridaCounter;
        private int _anannaCounter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_yeasinCounter<17)
            {
                welcomeLabel.Text += Yeasin[_yeasinCounter];
                _yeasinCounter++;
            }
            else if (_tarikCounter<17)
            {
                welcomeLabel.Text += Tarik[_tarikCounter];
                _tarikCounter++;
            }
            else if (_faridaCounter < 15)
            {
                welcomeLabel.Text += Farida[_faridaCounter];
                _faridaCounter++;
            }
            else if (_anannaCounter < 14)
            {
                welcomeLabel.Text += Ananna[_anannaCounter];
                _anannaCounter++;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            LoginPageUi loginPage = new LoginPageUi();
            loginPage.Show();
            Hide();
        }
    }
}
