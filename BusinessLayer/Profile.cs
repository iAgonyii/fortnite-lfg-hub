using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{ 
    public class Profile
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }

        public List<Achievement> Achievements { get; set; }

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display (Name = "Additional Information")]
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public bool Looking { get; set; }
        public string Picture { get; set; }
        public string Region { get; set; }

        public Profile()
        {
            
        }
        
        public Profile(ProfileDTO dto)
        {
            this.UserId = dto.UserId;
            this.Username = dto.Username;
            this.FreeText = dto.FreeText;
            this.SocialURL = dto.SocialURL;
            if(!string.IsNullOrWhiteSpace(dto.Looking))
            { 
                this.Looking = bool.Parse(dto.Looking);
            }
            this.Picture = dto.Picture;
            this.Region = dto.Region;
            if(dto.achievementDTOs != null)
            {
                this.Achievements = DtosToAchievements(dto.achievementDTOs);
            }
        }



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

        public void UpdateProfileInfo(string freeText, string socialURL, bool looking, string picture, string region)
        {
            commands = new ProfileCommands();
            commands.UpdateProfileInfo(new ProfileDTO() { FreeText = freeText, SocialURL = socialURL, Looking = looking.ToString(), Picture = picture, Region = region.ToString() });
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
            this.UserId = commands.GetUserIdForName(username);
            return this.UserId;
        }

        private List<AchievementDTO> achievementsToDtos(List<Achievement> achievements)
        {
            List<AchievementDTO> dtos = new List<AchievementDTO>();
            foreach(Achievement achievement in achievements)
            {
                if(achievement.Rank != null)
                {
                    dtos.Add(new AchievementDTO() { Rank = Convert.ToInt32(achievement.Rank), Event = achievement.Event.ToString() });
                }
            }
            return dtos;
        }

        private List<Achievement> DtosToAchievements(List<AchievementDTO> adtos)
        {
            List<Achievement> achvs = new List<Achievement>();
            foreach(AchievementDTO dto in adtos)
            {
                achvs.Add(new Achievement() { Rank = dto.Rank, Event = (Events)Enum.Parse(typeof(Events), dto.Event) });
            }
            return achvs;
        }
    }
}
