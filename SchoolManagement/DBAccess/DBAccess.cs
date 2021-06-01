using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolManagement.DBAccess
{
    public class DBAccess
    {
        public SqlConnection con;

        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["SchoolManagement"].ToString();
            con = new SqlConnection(constring);
        }

        public static void CreateCommand(string queryString,string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}

