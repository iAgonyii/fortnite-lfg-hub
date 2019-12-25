using DataLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class SocialCommands : ISocialCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;

        public string GetSocial(int profileid)
        {
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT URL FROM social WHERE UserId = @profileid", conn))
                {
                    command.Parameters.AddWithValue("profileid", profileid);
                    using (reader = command.ExecuteReader())
                    {
                        return reader.GetString(0);
                    }   
                }
            }
        }

        public void UpdateSocial(int UserId, string url)
        {
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("INSERT INTO social (URL,UserId) VALUES (@url, @userid) ON DUPLICATE KEY UPDATE URL = @url", conn))
                {
                    command.Parameters.AddWithValue("url", url);
                    command.Parameters.AddWithValue("userid", UserId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
