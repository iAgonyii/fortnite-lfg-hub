using Fortnite_LFG_Hub.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public class EditAchievementsProfile: IProfile
    {
        public List<Achievement> Achievements { get; set; }
        public EditAchievementsProfile()
        {
            Achievements = new List<Achievement> { new Achievement(), new Achievement(), new Achievement(), new Achievement(), new Achievement(), };
        }
    }
}
