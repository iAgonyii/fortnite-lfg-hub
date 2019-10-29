using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class Profile
    {
        public string achievement { get;  }
        public string name { get; }
        public int id { get; }

        public Profile(string a, string n, int i)
        {
            this.achievement = a;
            this.name = n;
            this.id = i;
        }
    }
}
