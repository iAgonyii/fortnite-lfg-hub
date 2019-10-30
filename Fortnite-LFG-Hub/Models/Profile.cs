using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class Profile
    {
        public string achievement { get; set; }
        public string name { get; set; }
        public string freetext { get; set; }
        public string socialurl { get; set; }


        public Profile(string n, string a, string f, string u)
        {
            this.name = n;
            this.achievement = a;
            this.freetext = f;
            this.socialurl = u;
        }
    }
}
