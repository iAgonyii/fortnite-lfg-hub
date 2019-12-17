using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models.Interfaces
{
    interface Editable
    {
         List<Achievement> Achievements { get; set; }
         string FreeText { get; set; }
         string SocialURL { get; set; }
         bool Looking { get; set; }
         string Picture { get; set; }
         Regions Region { get; set; }
    }
}
