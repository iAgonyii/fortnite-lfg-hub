using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.Models
{
    public enum Regions
    {
        [Display(Name="Select region")]
        _,
        Europe,
        NA_East,
        NA_West,
        Middle_East,
        Oceania,
        Brazil,
        Asia
    }
}
