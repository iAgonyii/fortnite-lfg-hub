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
        Katowice_Royale_2019_SOLOS_LAN,
        Katowice_Royale_2019_DUOS_LAN,
        Gauntlet_Cup_Finals,
        Scallywag_Cup_Finals,
        Blackheart_Cup_Finals,
        Luxe_Cup_Finals,
        World_Cup_Warmup_Finals,
        World_Cup_Qualifiers_Solos,
        World_Cup_Qualifiers_Duos,
        Trios_Champion_Series,
        Trios_Champion_Series_Heats,
        Trios_Champion_Series_Grand_Finals,
    }
}
