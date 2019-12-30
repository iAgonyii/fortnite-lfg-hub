using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.ViewModels
{
    public class FilterViewModel
    {
        public List<Flairs> flairs = Enum.GetValues(typeof(Flairs)).Cast<Flairs>().ToList();
        public List<bool> filters { get; set; }
        public FilterViewModel()
        {
            filters = new List<bool>(new bool[flairs.Count()]);
        }
    }

}
