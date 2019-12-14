using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public struct ProfileDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<AchievementDTO> achievementDTOs { get; set; }
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public string Looking { get; set; }
        public string Picture { get; set; }
        public string Region { get; set; }
    }
}
