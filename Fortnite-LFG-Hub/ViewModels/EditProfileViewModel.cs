using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fortnite_LFG_Hub.Models.ViewModels
{
    public class EditProfileViewModel
    { 
        public List<Achievement> Achievements { get; set; }
        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display(Name = "Additional Information")]
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public string Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }

        //public EditProfileViewModel(string username, int achievementsR1, Events event1, int achievementsR2, Events event2, int achievementsR3, Events event3, string freetext, string social)
        //{
        //    this.Username = username;
        //    this.AchievementsRank1 = achievementsR1;
        //    this.event1 = event1;
        //    this.AchievementsRank2 = achievementsR2;
        //    this.event2 = event2;
        //    this.AchievementsRank3 = achievementsR3;
        //    this.event3 = event3;
        //    this.Freetext = freetext;
        //    this.SocialURL = social;
        //}

        //public EditProfileViewModel(string username, List<Achievement> achievements, string freetext, string social)
        //{
        //    this.Username = username;
        //    this.achievements = achievements;
        //    this.Freetext = freetext;
        //    this.SocialURL = social;
        //}
        public EditProfileViewModel()
        {
            Achievements = new List<Achievement>();
        }
    }   
}
