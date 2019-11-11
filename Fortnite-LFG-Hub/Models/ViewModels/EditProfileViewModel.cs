using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fortnite_LFG_Hub.Models.ViewModels
{
    public class EditProfileViewModel
    {
        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Your username has to be between 3 and 32 characters long")]
        [RegularExpression(@"^[a-zA-Z0-0_]*$", ErrorMessage = "Your username may only contain alphanumeric characters (a-z, A-Z, 0-9)")]
        public string Username { get; set; }

        [Required(ErrorMessage="Atleast one achievement is required")]
        public int AchievementsRank1 { get; set; }
        [Required(ErrorMessage = "Atleast one achievement is required")]
        public string AchievementsEvent1 { get; set; }

        public int? AchievementsRank2 { get; set; }
        public string AchievementsEvent2 { get; set; }

        public int? AchievementsRank3 { get; set; }
        public string AchievementsEvent3 { get; set; }

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display (Name = "Additional Information")]
        public string Freetext { get; set; }

        [Url(ErrorMessage = "Social Platform input has to be a URL")]
        [Display (Name = "Social URL")]
        public string SocialURL { get; set; }

        public EditProfileViewModel()
        {

        }

        //public EditProfileViewModel(string username, int achievementsR1, string achievementsE1, string freetext, string social)
        //{
        //    this.Username = username;
        //    this.AchievementsRank1 = achievementsR1;
        //    this.AchievementsEvent1 = achievementsE1;
        //    this.Freetext = freetext;
        //    this.SocialURL = social;
        //}

        public EditProfileViewModel(string username, int achievementsR1, string achievementsE1, int achievementsR2, string achievementsE2, int achievementsR3, string achievementsE3, string freetext, string social)
        {
            this.Username = username;
            this.AchievementsRank1 = achievementsR1;
            this.AchievementsEvent1 = achievementsE1;
            this.AchievementsRank2 = achievementsR2;
            this.AchievementsEvent2 = achievementsE2;
            this.AchievementsRank3 = achievementsR3;
            this.AchievementsEvent3 = achievementsE3;
            this.Freetext = freetext;
            this.SocialURL = social;
        }
    }   
}
