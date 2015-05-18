using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    subject.Code = reader["code"].ToString();
                    subject.Title = reader["title"].ToString();
                    listSubjects.Add(subject);
                }
                connection.Close();
                return listSubjects;
            }
            catch (System.Exception)
            {
                return listSubjects;
            }
        }
    }
}
