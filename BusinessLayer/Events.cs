using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum Events
    {
        [Display(Name = "Select event...")]
        _,
        Winter_Royale_Qualifiers,
        Winter_Royale_Finals,
        Katowice_Royale_2019_SOLOS,
        Katowice_Royale_2019_DUOS,
        Gauntlet_Cup_Finals,
        Scallywag_Cup_Finals,
        Blackheart_Cup_Finals,
        Luxe_Cup_Finals,
        World_Cup_Warmup_Finals,
    }
}
