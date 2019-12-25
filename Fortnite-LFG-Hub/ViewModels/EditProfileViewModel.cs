using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BusinessLayer;

namespace Fortnite_LFG_Hub.Models.ViewModels
{
    public class EditProfileViewModel
    { 
        public List<Achievement> Achievements { get; set; }
        [StringLength(1000, ErrorMessage = "Additional text input can not be longer than 1000 characters")]
        [Display(Name = "Additional Information")]
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public bool Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }

        public EditProfileViewModel()
        {
            this.Achievements = new List<Achievement>() { new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(),};
        }
    }   
}
