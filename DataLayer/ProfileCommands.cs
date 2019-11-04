using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MySql.Data;

namespace DataLayer
{
    class ProfileCommands
    {
        SqlConnection conn = new SqlConnection(DbConnect.connectionstring);
        SqlCommand command;
        SqlDataReader reader;

        private string GetProfileData()
        {
            string username = "";
            using(conn)
            {
                conn.Open();
                using (command = new SqlCommand("select Username from profile"))
                {
                    using (reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            username = reader.GetString(0);
                        }
                    }
                }
            }
            return username;
        }
    }
}
