using DataLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Commands
{
    public class SocialCommands : ISocialCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public string GetSocial(int profileid)
        {
            throw new NotImplementedException();
        }

        public void UpdateSocial(string url)
        {
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("INSERT INTO social (URL,UserId) VALUES (@url, @userid) ON DUPLICATE KEY UPDATE URL = @url", conn))
                {
                    command.Parameters.AddWithValue("url", url);
                    //command.Parameters.AddWithValue("userid", dto.UserId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
