using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Gallery.Models;
namespace Gallery.Utility
{
    public class Database
    {
        String connectionString = "Persist Security Info=False;Integrated Security=true;  Initial Catalog = Gallery; Server=localhost\\MSSQLSERVER01";
        String cmd;
        public Database(String cmd)
        {
            this.cmd = cmd;
        }
        public SqlDataReader selector()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            return dr;
        }

    }
}