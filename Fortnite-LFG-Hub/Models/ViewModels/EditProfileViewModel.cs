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

        [Display(Name = "Achievements")]
        [Required(ErrorMessage = "Atleast one achievement is required.")]
        public int AchievementsRank1 { get; set; }
        [Required(ErrorMessage = "Atleast one achievement is required.")]
        public Events event1 { get; set; }

        public int? AchievementsRank2 { get; set; }
        public Events event2 { get; set; }

        public int? AchievementsRank3 { get; set; }
        public Events event3 { get; set; }

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display (Name = "Additional Information")]
        public string Freetext { get; set; }

        [Url(ErrorMessage = "Social Platform input has to be a URL")]
        [Display (Name = "Social URL")]
        public string SocialURL { get; set; }

        public EditProfileViewModel()
        {

        }

        public EditProfileViewModel(string username, int achievementsR1, Events event1, int achievementsR2, Events event2, int achievementsR3, Events event3, string freetext, string social)
        {
            this.Username = username;
            this.AchievementsRank1 = achievementsR1;
            this.event1 = event1;
            this.AchievementsRank2 = achievementsR2;
            this.event2 = event2;
            this.AchievementsRank3 = achievementsR3;
            this.event3 = event3;
            this.Freetext = freetext;
            this.SocialURL = social;
        }
    }   
}
