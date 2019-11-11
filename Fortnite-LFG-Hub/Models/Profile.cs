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
        public List<Achievement> Achievements = new List<Achievement>();
        public string FreeText { get; set; }
        public string SocialURL { get; set; }

        public Profile(ProfileDTO dto)
        {
            this.Username = dto.Username;
            foreach(AchievementDTO achvdto in dto.achievementDTOs)
            {
                Achievement a = new Achievement();
                a.Rank = achvdto.Rank;
                a.Event = achvdto.Event;
                this.Achievements.Add(a);
            }
            this.FreeText = dto.FreeText;
            this.SocialURL = dto.SocialURL;
        }
    }

    public class Achievement
    {
        public int Rank;
        public string Event;
    }
}
