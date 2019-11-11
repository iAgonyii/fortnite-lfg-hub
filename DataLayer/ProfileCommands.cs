using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace DataLayer
{
    public class ProfileCommands
    {
        MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        MySqlCommand command;
        MySqlDataReader reader;

        public ProfileDTO GetProfileData(string searchInput)
        {
            ProfileDTO dto = new ProfileDTO();
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT * FROM profile INNER JOIN achievement ON profile.UserId=achievement.UserId INNER JOIN social ON profile.UserId=social.UserId WHERE Username=@searchInput", conn))
                {
                    command.Parameters.AddWithValue("searchInput", searchInput);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dto.Username = reader.GetString(1);
                            //dto.Achievements = reader.GetString(10) + " " + "-" + " " + reader.GetString(11);
                            dto.FreeText = reader.GetString(3);
                            dto.SocialURL = reader.GetString(14);
                        }
                    }
                }
            }
            return dto;
        }

        public void SaveNewProfile(ProfileDTO dto)
        {
            using (conn)
            {
                conn.Open();

                command = new MySqlCommand();

                string sql = "insert into achievement(Rank,Tourney,UserId) values ";
                string valueSQL = "";

                command.Parameters.AddWithValue("username", dto.Username);
                command.Parameters.AddWithValue("textinfo", dto.FreeText);
                command.Parameters.AddWithValue("url", dto.SocialURL);

                for (int i = 0; i < dto.achievementDTOs.Count; i++)
                {
                    if (i == dto.achievementDTOs.Count - 1)
                    {
                        valueSQL += "(@rank" + i + ",@ev" + i + ",@userid)";
                        command.Parameters.AddWithValue("rank" + i, dto.achievementDTOs[i].Rank);
                        command.Parameters.AddWithValue("ev" + i, dto.achievementDTOs[i].Event);
                    }
                    else
                    {
                        valueSQL += "(@rank" + i + ",@ev" + i + ",@userid),";
                        command.Parameters.AddWithValue("rank" + i, dto.achievementDTOs[i].Rank);
                        command.Parameters.AddWithValue("ev" + i, dto.achievementDTOs[i].Event);
                    }
                }

                sql += valueSQL;
                sql += ";";

                command.Connection = conn;
                command.CommandText = "BEGIN; insert into profile(Username,TextInfo) values(@username,@textinfo); set @userid = LAST_INSERT_ID(); " + sql + "insert into social(`URL`,UserId) values(@url,@userid); COMMIT;";
                command.ExecuteNonQuery();
            }
        }
    }
}
