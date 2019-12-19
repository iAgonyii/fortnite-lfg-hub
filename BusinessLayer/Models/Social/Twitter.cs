using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class Twitter : ISocial
    {
        public string UserSocialURL { get; set; }

        public void SetUserSocialURL(string url)
        {
            this.UserSocialURL = url;
        }

        public Twitter()
        {

        }
    }
}
