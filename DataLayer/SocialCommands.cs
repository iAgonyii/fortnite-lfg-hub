using DataLayerInterface;
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
            string url = "";
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT URL FROM social WHERE UserId = @profileid", conn))
                {
                    command.Parameters.AddWithValue("profileid", profileid);
                    using (reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            url = reader.GetString(0);
                        }
                    }   
                }
            }
            return url;
        }

        public void UpdateSocial(int UserId, string url)
        {
            using (conn)
            {
                conn.Open();
                // We insert if the user had no previous social. We update if the user had a social in the database prior.
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
