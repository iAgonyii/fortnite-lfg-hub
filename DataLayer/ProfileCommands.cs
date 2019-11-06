
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
            using(conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT * FROM profile INNER JOIN achievement ON profile.UserId=achievement.UserId INNER JOIN social ON profile.UserId=social.UserId WHERE Username=@searchInput", conn))
                {
                    command.Parameters.AddWithValue("searchInput", searchInput);
                    using (reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            dto.Username = reader.GetString(1);
                            dto.Achievements = reader.GetString(10) + " " + "-" + " " + reader.GetString(11);
                            dto.FreeText = reader.GetString(3);
                            dto.SocialURL = reader.GetString(14);
                        }
                    }
                }
            }
            return dto;
        }
    }
}
