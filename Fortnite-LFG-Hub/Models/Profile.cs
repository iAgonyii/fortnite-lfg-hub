using DataLayer;
using Fortnite_LFG_Hub.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{ 
    public class Profile: IProfile
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Your username has to be between 3 and 32 characters long")]
        [RegularExpression(@"^[A-Za-z0-9-_\\s]*$", ErrorMessage = "Your username may only contain alphanumeric characters (a-z, A-Z, 0-9)")]
        public string Username { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }

        public List<Achievement> Achievements;

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display (Name = "Additional Information")]
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public bool Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }

        public Profile()
        {
            Achievements = new List<Achievement> { new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), };
        }
        public Profile(ProfileDTO dto)
        {
            Achievements = new List<Achievement>();

            this.UserId = dto.UserId;
            this.Username = dto.Username;
            
            foreach(AchievementDTO achvdto in dto.achievementDTOs)
            {
                Achievement a = new Achievement();
                a.Rank = achvdto.Rank;
                a.Event = (Events)Enum.Parse(typeof(Events), achvdto.Event);
                this.Achievements.Add(a);
            }
            this.FreeText = dto.FreeText;
            this.SocialURL = dto.SocialURL;
            this.Looking = dto.Looking;
            this.Picture = dto.Picture;
            this.Region = (Regions)Enum.Parse(typeof(Regions), dto.Region);
        }
    }

    public class Achievement
    {
        public int? Rank;
        public Events Event;
    }
}
