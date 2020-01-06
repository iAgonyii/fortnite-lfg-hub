using BusinessLayer;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.ViewModels
{
    public class AchievementsViewModel
    {
        public List<Achievement> Achievements { get; set; }
        public SelectList events { get; set; }
        public AchievementsViewModel()
        {
            
        }
    }
}
