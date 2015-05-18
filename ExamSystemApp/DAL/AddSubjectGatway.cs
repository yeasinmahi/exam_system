using System.Configuration;
using System.Data.SqlClient;
using ExamSystemApp.Model;

namespace ExamSystemApp.DAL
{
    class AddSubjectGatway
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int Insert(Subject subject)
        {
            try
            {
                string query = "Insert Into subject (code, title) values ('" + subject.Code + "','" + subject.Title + "')";
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

        public int IsCodeUnique(Subject subject)
        {
            try
            {
                string query = "select code from subject where code='"+subject.Code+"'";
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
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    connection.Close();
                    return 1;
                }
                connection.Close();
                return 0;
            }
            catch (System.Exception)
            {
                return 2;
            }
        }
    }
}
