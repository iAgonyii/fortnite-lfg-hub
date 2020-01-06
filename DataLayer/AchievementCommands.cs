using DataLayerDTO;
using DataLayerInterface;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AchievementCommands : IAchievementCommands, IAchievementContainerCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public List<AchievementDTO> GetAchievements(int profileid)
        {
            using (conn)
            {
                conn.Open();
                using(command = new MySqlCommand("SELECT a.Rank, e.Event, e.EventId FROM achievement a LEFT JOIN event e ON (a.Tourney = e.EventId) WHERE UserId = @profileid", conn))
                {
                    command.Parameters.AddWithValue("profileid", profileid);
                    using(reader = command.ExecuteReader())
                    {
                        List<AchievementDTO> dtos = new List<AchievementDTO>();
                        while(reader.Read())
                        {
                            dtos.Add(new AchievementDTO() { Rank = reader.GetInt32(0), Event = reader.GetString(1), EventId = reader.GetInt32(2).ToString() });
                        }
                        return dtos;
                    }
                }
            }
        }

        public IDictionary<string, string> GetEvents()
        {
            IDictionary<string, string> events = new Dictionary<string, string>();
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT * FROM event", conn))
                {
                    using(reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            events.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                        }
                    }
                }
            }
            return events;
        }

        public void UpdateAchievements(List<AchievementDTO> dtos, List<string> flairs, int profileid)
        {
            UpdateFlairs(flairs, profileid);
            using (conn)
            {
                conn.Open();

                command = new MySqlCommand();
                MySqlTransaction transaction;

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
                        command.Parameters.AddWithValue("ev" + i, Convert.ToInt32(dtos[i].Event));
                    }
                    else
                    {
                        valueSQL += "(@rank" + i + ",@ev" + i + ",@userid),";
                        command.Parameters.AddWithValue("rank" + i, dtos[i].Rank);
                        command.Parameters.AddWithValue("ev" + i, Convert.ToInt32(dtos[i].Event));
                    }
                }

                sql += valueSQL;

                transaction = conn.BeginTransaction();
                command.Connection = conn;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = "DELETE FROM achievement WHERE UserId = @userid";
                    command.ExecuteNonQuery();
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(Exception e)
                {
                    transaction.Rollback();
                    throw new Exception(e.ToString());
                }
            }
        }

        private void UpdateFlairs(List<string> flairs, int userid)
        {
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("UPDATE profile SET Flairs = @flairs WHERE UserId = @userid",conn))
                {
                    command.Parameters.AddWithValue("userid", userid);
                    command.Parameters.AddWithValue("flairs", listToString(flairs));
                    command.ExecuteNonQuery();
                }
            }
        }

        private string listToString(List<string> flairs)
        {
            string flairsString = "";
            foreach(string flair in flairs)
            {
                flairsString += flair + ",";
            }
            return flairsString;
        }
    }
}
