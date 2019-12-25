using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Logic
{
    public class ProfileLogic
    {
        private IProfileCommands commands;
        public bool Login(string username, string password)
        {
            commands = new ProfileCommands();
            if (commands.CheckCredentials(new ProfileDTO() { Username = username, Password = password }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(string username, string password)
        {
            commands = new ProfileCommands();
            commands.RegisterNewProfile(new ProfileDTO() { Username = username, Password = password });
        }

        public void UpdateProfileInfo(int id, string freeText, string socialURL, bool looking, string picture, Regions region)
        {
            commands = new ProfileCommands();
            if(freeText == null)
            {
                freeText = "";
            }
            if(picture == null)
            {
                picture = "";
            }
            commands.UpdateProfileInfo(new ProfileDTO() { UserId = id, FreeText = freeText, SocialURL = socialURL, Looking = looking.ToString(), Picture = picture, Region = region.ToString() });
        }

        private IAchievementCommands achievementCommands;
        public void UpdateProfileAchievements(List<Achievement> achievements, int id)
        {
            achievementCommands = new AchievementCommands();
            List<AchievementDTO> dtos = achievementsToDtos(achievements);
            achievementCommands.UpdateAchievements(dtos, id);
        }

        public int GetUserIdForName(string username)
        {
            commands = new ProfileCommands();
            int UserId = commands.GetUserIdForName(username);
            return UserId;
        }

        private List<AchievementDTO> achievementsToDtos(List<Achievement> achievements)
        {
            List<AchievementDTO> dtos = new List<AchievementDTO>();
            foreach (Achievement achievement in achievements)
            {
                if (achievement.Rank != null)
                {
                    dtos.Add(new AchievementDTO() { Rank = Convert.ToInt32(achievement.Rank), Event = achievement.Event.ToString() });
                }
            }
            return dtos;
        }

        public List<Achievement> DtosToAchievements(List<AchievementDTO> adtos)
        {
            List<Achievement> achvs = new List<Achievement>();
            foreach (AchievementDTO dto in adtos)
            {
                achvs.Add(new Achievement() { Rank = dto.Rank, Event = (Events)Enum.Parse(typeof(Events), dto.Event) });
            }
            return achvs;
        }
    }
}
