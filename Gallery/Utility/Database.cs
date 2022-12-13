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
        public Response selector()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            List<draw> drawList = new List<draw>();
            while (dr.Read())
            {
                draw model = new draw();
                model.id = (Guid)dr["id"];
                model.artist = (String)dr["artist"];
                model.startYear = (String)dr["startYear"];
                model.endYear = (String)dr["endYear"];
                model.drawName = (String)dr["drawName"];
                model.attribute = (String)dr["attribute"];
                model.imageLink = (String)dr["imageLink"];
                drawList.Add(model);
            }
            return new Response(drawList);
        }
    }
}