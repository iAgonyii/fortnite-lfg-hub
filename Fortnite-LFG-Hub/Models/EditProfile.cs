using Fortnite_LFG_Hub.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class EditProfile
    {

        public List<Achievement> Achievements;

        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display(Name = "Additional Information")]
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public string Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }

        public EditProfile()
        {
            Achievements = new List<Achievement> { new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), };
        }
    }
}
