using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ExamSystemApp.BLL;
using ExamSystemApp.Model;

namespace ExamSystemApp.UI
{
    public partial class StudentUi : Form
    {
        readonly LoadManager _loadManager = new LoadManager();
        List<QuestionAndAnswer> _listQuestionAndAnswers = new List<QuestionAndAnswer>();
        public StudentUi()
        {
            InitializeComponent();
            QuestionPanel.Hide();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadSubjectToComboBox();
            
        }
        int _i;
        private int _countQuestion;
        private int _correctAnswer;
        private int _wrongAnswer;
        private int _notAnswer;
        private string _answer = "";
        private double _score;
        private int _numberOfQuestion;
        int _minute = 9;
        int _second = 60;
        private void submitButton_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            NextQuestion();
            
        }

        private void ResetAllData()
        {
            submitButton.Text = @"Next";
            _i = 0;
            _countQuestion = 0;
            _correctAnswer = 0;
            _wrongAnswer = 0;
            _notAnswer = 0;
            _answer = "";
            _score = 0;
            _numberOfQuestion = 0;
            _minute = 9;
            _second = 60;
            _listQuestionAndAnswers = null;
            timeLabel.Text = "";


        }
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Hide();
            ResetAllData();
            
            QuestionPanel.Show();
            LoadQuestion();
            _countQuestion = _listQuestionAndAnswers.Count;
            NextQuestion();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Show();
            QuestionPanel.Hide();
        }

        private void LoadSubjectToComboBox()
        {
            List<Subject> listSubjects = _loadManager.LoadAllSubject();

            subjectComboBox.DisplayMember = "title";
            subjectComboBox.ValueMember = "sid";
            subjectComboBox.DataSource = listSubjects;
        }

        private void LoadQuestion()
        {
            int sid;
            if (subjectComboBox.SelectedItem != null)
            {
                sid = Convert.ToInt32(subjectComboBox.SelectedValue.ToString());
                _listQuestionAndAnswers = _loadManager.LoadQuestionList(sid);
            }
            else
            {
                MessageBox.Show(@"Select A Subject First");
            }
            
        }

        private void NextQuestion()
        {
            ARadioButton.Checked = false;
            BRadioButton.Checked = false;
            CRadioButton.Checked = false;
            DRadioButton.Checked = false;
            
            if (_countQuestion>=10)
            {
                timer2.Start();
                if (_i < 10)
                {
                    if (_i == 9)
                    {
                        submitButton.Text = @"Finish";
                    }
                    _numberOfQuestion++;
                    numberOfQuestionLabel.Text = _numberOfQuestion.ToString(CultureInfo.InvariantCulture);

                    questionTextBox.Text = _listQuestionAndAnswers[_i].Question;
                    optionATextBox.Text = _listQuestionAndAnswers[_i].OptionA;
                    optionBTextBox.Text = _listQuestionAndAnswers[_i].OptionB;
                    optionCTextBox.Text = _listQuestionAndAnswers[_i].OptionC;
                    optionDTextBox.Text = _listQuestionAndAnswers[_i].OptionD;
                    _answer = _listQuestionAndAnswers[_i].Answer;

                    _i++;
                    
                }
                else
                {
                    _score = _correctAnswer - _wrongAnswer*.25;
                    timer2.Stop();
                    MessageBox.Show(string.Format(@"Correct Answer:{0}
Wrong Answer:{1}
Not Answered:{2}
Your Score is {3}", _correctAnswer, _wrongAnswer, _notAnswer, _score));
                    QuestionPanel.Hide();
                    startButton.Show();
                }
            }
            else
            {
                timer2.Stop();
                MessageBox.Show(@"There are not enought question to load");
            }
        }

        private void CheckAnswer()
        {
            string userAnswer = "";
            bool isAnswerOrNot = true;
            if (ARadioButton.Checked)
            {
                userAnswer = "A";
            }
            else if (BRadioButton.Checked)
            {
                userAnswer = "B";
            }
            else if (CRadioButton.Checked)
            {
                userAnswer = "C";
            }
            else if (DRadioButton.Checked)
            {
                userAnswer = "D";
            }
            else
            {
                isAnswerOrNot = false;
            }
            if (isAnswerOrNot)
            {
                if (_answer.Equals(userAnswer))
                {
                    _correctAnswer++;
                }
                else
                {
                    _wrongAnswer++;
                }
            }
            else
            {
                _notAnswer++;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (_minute>=0)
            {
                _second--;
                if (_second<=0)
                {
                    if (_minute==0 && _second==0)
                    {
                        timer2.Stop();
                        _score = _correctAnswer - _wrongAnswer * .25;
                        MessageBox.Show(string.Format("Correct Answer:{0}\nWrong Answer:{1}\nNot Answered:{2}\nYour Score is {3}", _correctAnswer, _wrongAnswer, _notAnswer, _score));
                        QuestionPanel.Hide();
                        startButton.Show();
                        
                    }
                    _minute--;
                    _second = 10;
                }
                
            }
            string tempTime = string.Format("{0:00} : {1:00}", _minute, _second);
            timeLabel.Text = tempTime;
        }
    }
}
