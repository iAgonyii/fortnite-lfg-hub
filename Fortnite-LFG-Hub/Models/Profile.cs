using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{ 
    public class Profile
    {
        public string Username { get; set; }
        public List<Achievement> Achievements;
        public string FreeText { get; set; }
        public string SocialURL { get; set; }

        public Profile(ProfileDTO dto)
        {
            Achievements = new List<Achievement>();

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
        }
    }

    public class Achievement
    {
        public int Rank;
        public Events Event;
    }
}
