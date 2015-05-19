using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystemApp.Model;

namespace ExamSystemApp.DAL
{
    class TeacherGatway
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int Insert(QuestionAndAnswer questionAndAnswer)
        {
            try
            {
                string query = "Insert Into question (sid, question, optionA, optionB, optionC, optionD, answer) values (" + questionAndAnswer.Sid + ",'" + questionAndAnswer.Question + "','" + questionAndAnswer.OptionA + "','" + questionAndAnswer.OptionB + "','" + questionAndAnswer.OptionC + "','" + questionAndAnswer.OptionD + "','" + questionAndAnswer.Answer + "')";
                MessageBox.Show(query);
                SqlConnection connection;
                try
                {
                    connection = new SqlConnection(_connectionString);
                }
                catch (System.Exception)
                {
                    return -1;
                }
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowAffected;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}
