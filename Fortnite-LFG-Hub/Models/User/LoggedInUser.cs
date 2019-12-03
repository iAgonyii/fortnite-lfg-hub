using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class LoggedInUser: IUser
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Your username has to be between 3 and 20 characters long")]
        [RegularExpression(@"^[A-Za-z0-9-_\\s]*$", ErrorMessage = "Your username may only contain alphanumeric characters (a-z, A-Z, 0-9)")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public DateTime LastSeen { get; set; }

        public Profile profile;

        public LoggedInUser()
        {
            this.profile = new Profile();
        }

        public void Logout()
        {

        }


    }
}
