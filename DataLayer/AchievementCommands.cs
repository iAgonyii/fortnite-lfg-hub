using DataLayerDTO;
using DataLayerInterface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AchievementCommands : IAchievementCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public List<AchievementDTO> GetAchievements(int profileid)
        {
            using (conn)
            {
                conn.Open();
                using(command = new MySqlCommand("SELECT Rank, Tourney FROM achievement WHERE UserId = @profileid", conn))
                {
                    command.Parameters.AddWithValue("profileid", profileid);
                    using(reader = command.ExecuteReader())
                    {
                        List<AchievementDTO> dtos = new List<AchievementDTO>();
                        while(reader.Read())
                        {
                            dtos.Add(new AchievementDTO() { Rank = reader.GetInt32(0), Event = reader.GetString(1) });
                        }
                        return dtos;
                    }
                }
            }
        }

        public void UpdateAchievements(List<AchievementDTO> dtos, int profileid)
        {
            using (conn)
            {
                conn.Open();

                command = new MySqlCommand();

                string sql = "insert into achievement(Rank,Tourney,UserId) values ";
                string valueSQL = "";

                command.Parameters.AddWithValue("userid", profileid);

                // We have to dynamically add value parameters for every achievement that we have because we don't know how many a user will input.
                // We do this with a little stringbuilding
                for (int i = 0; i < dtos.Count; i++)
                {
                    if (i == dtos.Count - 1)
                    {
                        valueSQL += "(@rank" + i + ",@ev" + i + ",@userid)";
                        command.Parameters.AddWithValue("rank" + i, dtos[i].Rank);
                        command.Parameters.AddWithValue("ev" + i, dtos[i].Event);
                    }
                    else
                    {
                        valueSQL += "(@rank" + i + ",@ev" + i + ",@userid),";
                        command.Parameters.AddWithValue("rank" + i, dtos[i].Rank);
                        command.Parameters.AddWithValue("ev" + i, dtos[i].Event);
                    }
                }

                sql += valueSQL + ";";

                command.Connection = conn;
                command.CommandText = "BEGIN; DELETE FROM achievement WHERE UserId=@userid; " + sql + "COMMIT;";
                command.ExecuteNonQuery();
            }
        }
    }
}
