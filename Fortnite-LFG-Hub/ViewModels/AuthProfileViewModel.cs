using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.ViewModels
{
    public class AuthProfileViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Your username has to be between 3 and 32 characters long")]
        [RegularExpression(@"^[A-Za-z0-9-_\\s]*$", ErrorMessage = "Your username may only contain alphanumeric characters (a-z, A-Z, 0-9)")]
        public string Username { get; set; }
        [StringLength(999, MinimumLength = 5, ErrorMessage = "Your password must be atleast 5 characters long")]
        public string Password { get; set; }

        public AuthProfileViewModel()
        {

        }
    }
}
