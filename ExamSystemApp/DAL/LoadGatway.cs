using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ExamSystemApp.Model;

namespace ExamSystemApp.DAL
{
    class LoadGatway
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public List<Subject> LoadAllSubject()
        {
            List<Subject> listSubjects = new List<Subject>();
            try
            {
                string query = "select * from subject";
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Subject subject = new Subject();
                    subject.Sid = reader["sid"].ToString();
                    subject.Title = reader["title"].ToString();
                    listSubjects.Add(subject);
                }
                connection.Close();
                return listSubjects;
            }
            catch (Exception)
            {
                return listSubjects;
            }
        }

        public List<QuestionAndAnswer> LoadQuestionList(int sid)
        {
            List<QuestionAndAnswer> listQuestionAndAnswers = new List<QuestionAndAnswer>();
            try
            {
                string query = "select top 10 * from question where sid="+sid+" order by newid()";
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    QuestionAndAnswer questionAndAnswer = new QuestionAndAnswer();
                    questionAndAnswer.Qid = Convert.ToInt32(reader["qid"].ToString());
                    questionAndAnswer.Question = reader["question"].ToString();
                    questionAndAnswer.OptionA = reader["optionA"].ToString();
                    questionAndAnswer.OptionB = reader["optionB"].ToString();
                    questionAndAnswer.OptionC = reader["optionC"].ToString();
                    questionAndAnswer.OptionD = reader["optionD"].ToString();
                    questionAndAnswer.Answer = reader["answer"].ToString();
                    listQuestionAndAnswers.Add(questionAndAnswer);
                }
                connection.Close();
                return listQuestionAndAnswers;
            }
            catch (Exception)
            {
                return listQuestionAndAnswers;
            }
        }
    }
}
