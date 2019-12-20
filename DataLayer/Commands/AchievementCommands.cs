using DataLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Commands
{
    public class AchievementCommands : IAchievementCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public List<AchievementDTO> GetAchievements(int profileid)
        {
            throw new NotImplementedException();
        }

        public void UpdateAchievements(List<AchievementDTO> dtos)
        {
            using (conn)
            {
                conn.Open();

                command = new MySqlCommand();

                string sql = "insert into achievement(Rank,Tourney,UserId) values ";
                string valueSQL = "";

                //command.Parameters.AddWithValue("userid", dto.UserId);

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
