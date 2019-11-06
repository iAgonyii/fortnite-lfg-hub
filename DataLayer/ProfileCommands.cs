using MySql.Data.MySqlClient;

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
                using (command = new MySqlCommand("begin;" +
                    " insert into profile(Username,TextInfo) values(@username,@textinfo);" +
                    " set @userid = LAST_INSERT_ID(); " +
                    " insert into achievement(Rank,Event,UserId) values(@rank,@event,@userid);" +
                    " insert into social(URL,UserId) values(@url,@userid);" +
                    " COMMIT;", conn))
                {
                    command.Parameters.AddWithValue("username", dto.Username);
                    command.Parameters.AddWithValue("textinfo", dto.FreeText);

                    //string[] parts = dto.Achievements.Split(' ');

                   // command.Parameters.AddWithValue("rank", parts[0]);
                    //command.Parameters.AddWithValue("event", parts[2]);
                    command.Parameters.AddWithValue("url", dto.SocialURL);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
