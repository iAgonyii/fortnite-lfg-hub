﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    interface ISocial
    {
        string UserSocialURL { get; set; }
        void SetUserSocialURL(string url);
    }
}