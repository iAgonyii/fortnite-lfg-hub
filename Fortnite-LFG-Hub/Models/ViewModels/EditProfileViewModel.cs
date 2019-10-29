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
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Your username be between 3 and 32 characters long")]
        [RegularExpression(@"^[a-zA-Z0-0_]*$", ErrorMessage = "Your username may only contain alphanumeric characters (a-z, A-Z, 0-9)")]
        public string Username { get; set; }

        public string[] Achievements { get; set; }

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        public string Freetext { get; set; }

        [Url(ErrorMessage = "Your social platform input has to be a URL")]
        public string SocialURL { get; set; }

        public EditProfileViewModel()
        {
            this.Username = "Username";
            this.Achievements[0] = "Achievements";
            this.Freetext = "Additional Information";
            this.SocialURL = "Social";
        }

        public EditProfileViewModel(string username, string[] achievements, string freetext, string social)
        {
            this.Username = username;
            this.Achievements = achievements;
            this.Freetext = freetext;
            this.SocialURL = social;
        }
    }   
}
