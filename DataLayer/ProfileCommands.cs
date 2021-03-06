﻿
using DataLayerDTO;
using DataLayerInterface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ProfileCommands : IProfileCommands, IProfileContainerCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;

        public ProfileDTO GetProfileData(int searchInput)
        {
            ProfileDTO dto = new ProfileDTO();
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT p.UserId, p.Username, p.TextInfo, p.Looking, p.Picture, p.Region, p.Flairs FROM profile p WHERE p.UserId = @searchInput", conn))
                {
                    command.Parameters.AddWithValue("searchInput", searchInput);
                    using (reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            IAchievementCommands aCommands = new AchievementCommands();
                            ICommentContainerCommands cCommands = new CommentCommands();
                            ISocialCommands sCommands = new SocialCommands();
                            while (reader.Read())
                            {
                                dto.UserId = reader.GetInt32(0);
                                dto.Username = reader.GetString(1);
                                dto.FreeText = reader.GetString(2);
                                dto.Looking = reader.GetString(3);
                                dto.Picture = reader.GetString(4);
                                dto.Region = reader.GetString(5);
                                dto.Flairs = DatabaseFlairsToStringList(reader.GetString(6));
                                dto.SocialURL = sCommands.GetSocial(dto.UserId);
                            }
                        }
                        else
                        {
                            throw new Exception("No profile found for this user");
                        }
                    }
                }
            }
            return dto;
        }

        public List<ProfileDTO> GetProfiles()
        {
            List<ProfileDTO> profileDTOs = new List<ProfileDTO>();
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT p.UserId, p.Username, p.TextInfo, p.Looking, p.Picture, p.Region, p.Flairs FROM profile p", conn))
                {
                    using (reader = command.ExecuteReader())
                    {
                        // We get all profile data for each profile.
                        IAchievementCommands aCommands = new AchievementCommands();
                        ICommentContainerCommands cCommands = new CommentCommands();
                        ISocialCommands sCommands = new SocialCommands();
                        while (reader.Read())
                        {
                            ProfileDTO dto = new ProfileDTO();
                            dto.UserId = reader.GetInt32(0);
                            dto.Username = reader.GetString(1);
                            dto.FreeText = reader.GetString(2);
                            dto.Looking = reader.GetString(3);
                            dto.Picture = reader.GetString(4);
                            dto.Region = reader.GetString(5);
                            dto.Flairs = DatabaseFlairsToStringList(reader.GetString(6));
                            dto.SocialURL = sCommands.GetSocial(dto.UserId);
                            profileDTOs.Add(dto);
                        }
                    }
                }
            }
            return profileDTOs;
        }

        public void UpdateProfileInfo(ProfileDTO dto)
        {
            if (dto.SocialURL != null)
            {
                ISocialCommands commands = new SocialCommands();
                commands.UpdateSocial(dto.UserId, dto.SocialURL);
            }
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("UPDATE profile SET TextInfo = @textinfo, Looking = @looking, Picture = @picture, Region = @region WHERE UserId = @userid", conn))
                {
                    command.Parameters.AddWithValue("textinfo", dto.FreeText);
                    command.Parameters.AddWithValue("looking", dto.Looking.ToString());
                    command.Parameters.AddWithValue("picture", dto.Picture);
                    command.Parameters.AddWithValue("region", dto.Region);
                    command.Parameters.AddWithValue("userid", dto.UserId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Check first if username isn't already taken before procceeding
        public void RegisterNewProfile(ProfileDTO dto)
        {
            if(!UsernameIsTaken(dto.Username))
            {
                using (conn)
                {
                    conn.Open();
                    using (command = new MySqlCommand("INSERT INTO Profile(Username, Password) VALUES(@username, @password)", conn))
                    {
                        command.Parameters.AddWithValue("username", dto.Username);
                        command.Parameters.AddWithValue("password", dto.Password);


                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                throw new Exception("This username is already taken");
            }
        }

        public bool CheckCredentials(ProfileDTO dto)
        {
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT * FROM Profile where Username=@username AND Password=@password", conn))
                {
                    command.Parameters.AddWithValue("username", dto.Username);
                    command.Parameters.AddWithValue("password", dto.Password);

                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public int GetUserIdForName(string username)
        {
            int id = 0;
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT UserId from Profile where Username = @username", conn))
                {
                    command.Parameters.AddWithValue("username", username);
                    using (reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }

        public string GetUsernameForId(int id)
        {
            string name = "";
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT Username from Profile where UserId = @userid", conn))
                {
                    command.Parameters.AddWithValue("userid", id);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader.GetString(0);
                        }
                    }
                }
            }
            return name;
        }

        private bool UsernameIsTaken(string username)
        {
            bool taken = false;
            using(conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT UserId from Profile where Username = @username", conn))
                {
                    command.Parameters.AddWithValue("username", username);
                    using(reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taken = reader.HasRows;
                        }
                        
                    }
                }
            }
            return taken;
        }




        // Data formatting methods

        private List<string> DatabaseFlairsToStringList(string flairs)
        {
            List<string> listFlairs = new List<string>();
            listFlairs = flairs.Split(',').ToList();
            listFlairs.RemoveAll(f => f == "");
            return listFlairs;
        }


        //public List<AchievementDTO> FormatConcatDataToAchievementDtos(string concatData)
        //{
        //    List<AchievementDTO> adtos = new List<AchievementDTO>();
        //    string[] parts;
        //    if(!string.IsNullOrWhiteSpace(concatData))
        //    {
        //        parts = concatData.Split(',');
        //    }
        //    else
        //    {
        //        return adtos;
        //    }

        //    for(int i = 0; i < 10; i++)
        //    {
        //        if(i >= parts.Length)
        //        {
        //            break;
        //        }
        //        else if(!string.IsNullOrWhiteSpace(parts[i]))
        //        {
        //            string[] achievementParts = parts[i].ToString().Split('#');
        //            AchievementDTO adto = new AchievementDTO() { Rank = Convert.ToInt32(achievementParts[0]), Event = achievementParts[1] };
        //            adtos.Add(adto);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return adtos;
        //}
    }
}
