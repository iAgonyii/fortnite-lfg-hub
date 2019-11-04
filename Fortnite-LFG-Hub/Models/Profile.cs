using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class Profile
    {
        public string Username { get; set; }
        public string Achievements { get; set; }
        public string FreeText { get; set; }
        public string SocialURL { get; set; }


        public Profile(string n, string aR, string aE, string f, string u)
        {
            this.Username = n;
            this.Achievements = aR + " " + "-" + " " + aE;
            this.FreeText = f;
            this.SocialURL = u;
        }
    }
}
