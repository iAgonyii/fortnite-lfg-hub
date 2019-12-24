﻿using DataLayerDTO;
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

        public ProfileDTO GetProfileData(string searchInput)
        {
            ProfileDTO dto = new ProfileDTO();
            using (conn)
            {
                conn.Open();
                using (command = new MySqlCommand("SELECT p.UserId, p.Username, p.TextInfo, p.Looking, p.Picture, p.Region FROM profile p WHERE p.Username = @searchInput", conn))
                {
                    command.Parameters.AddWithValue("searchInput", searchInput);
                    using (reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dto.UserId = reader.GetInt32(0);
                                dto.Username = reader.GetString(1);
                                dto.FreeText = reader.GetString(2);
                                dto.Looking = reader.GetString(3);
                                dto.Picture = reader.GetString(4);
                                dto.Region = reader.GetString(5);
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
                using (command = new MySqlCommand("SELECT p.UserId, p.Username, p.TextInfo, p.Looking, p.Picture, p.Region, (SELECT COALESCE(GROUP_CONCAT(COALESCE(a.Rank, ''), '#', COALESCE(a.Tourney, '')), '') FROM achievement a WHERE p.UserId = a.UserId) as achievements, (SELECT COALESCE(s.URL, '') FROM social s WHERE p.UserId = s.UserId) as socials FROM profile p", conn))
                {
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProfileDTO dto = new ProfileDTO();
                            dto.UserId = reader.GetInt32(0);
                            dto.Username = reader.GetString(1);
                            dto.FreeText = reader.GetString(2);
                            dto.Looking = reader.GetString(3);
                            dto.Picture = reader.GetString(4);
                            dto.Region = reader.GetString(5);
                            dto.achievementDTOs = FormatConcatDataToAchievementDtos(reader.GetString(6));
                            if (!reader.IsDBNull(7))
                            {
                                dto.SocialURL = reader.GetString(7);
                            }
                            profileDTOs.Add(dto);
                        }
                    }
                }
            }
            return profileDTOs;
        }

        public void UpdateProfileInfo(ProfileDTO dto)
        {
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

        public void RegisterNewProfile(ProfileDTO dto)
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




        // Data formatting methods

        public List<AchievementDTO> FormatConcatDataToAchievementDtos(string concatData)
        {
            List<AchievementDTO> adtos = new List<AchievementDTO>();
            string[] parts;
            if(!string.IsNullOrWhiteSpace(concatData))
            {
                parts = concatData.Split(',');
            }
            else
            {
                return adtos;
            }
            
            for(int i = 0; i < 10; i++)
            {
                if(i >= parts.Length)
                {
                    break;
                }
                else if(!string.IsNullOrWhiteSpace(parts[i]))
                {
                    string[] achievementParts = parts[i].ToString().Split('#');
                    AchievementDTO adto = new AchievementDTO() { Rank = Convert.ToInt32(achievementParts[0]), Event = achievementParts[1] };
                    adtos.Add(adto);
                }
                else
                {
                    break;
                }
            }
            return adtos;
        }

        public bool CheckCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
