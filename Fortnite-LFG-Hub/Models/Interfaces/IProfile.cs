using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models.Interfaces
{
    interface IProfile
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        bool LoggedIn { get; set; }
    }
}
