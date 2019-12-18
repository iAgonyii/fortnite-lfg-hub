using Fortnite_LFG_Hub.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class AuthProfile: IProfile
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool LoggedIn { get; set; }
    }
}
