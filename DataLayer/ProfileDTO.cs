using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public struct ProfileDTO
    {
        public string Username { get; set; }
        //public string Achievements { get; set; }
        public List<AchievementDTO> achievementDTOs { get; set; }
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
    }
}
