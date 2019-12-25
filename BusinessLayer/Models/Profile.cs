using BusinessLayer.Logic;
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
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public bool Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }
        
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
            this.Region = (Regions)Enum.Parse(typeof(Regions), dto.Region);
            if (dto.achievementDTOs != null)
            {
                ProfileLogic logic = new ProfileLogic();
                this.Achievements = logic.DtosToAchievements(dto.achievementDTOs);
            }
        }
    }
}
