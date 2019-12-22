using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
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
