using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLayerContainer;
using BusinessLayer;
using Fortnite_LFG_Hub.ViewModels;

namespace Fortnite_LFG_Hub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string search)
        {
            ProfilesContainer container = new ProfilesContainer();
            List<Profile> profiles = container.GetProfiles();
            if (string.IsNullOrWhiteSpace(search))
            {
                return View(profiles);
            }
            else
            {
                profiles = profiles.Where(p => p.Username.Contains(search)).ToList();
                return View(profiles);
            }
        }

        public IActionResult FilterIndex(List<bool> filters)
        {
            ProfilesContainer container = new ProfilesContainer();
            List<Profile> profiles = container.GetProfiles();
            List<Profile> filteredProfiles = FilterProfiles(filters, profiles);

            return View("Index", filteredProfiles);
        } 

        private List<Profile> FilterProfiles(List<bool> filters, List<Profile> profiles)
        {
            List<Flairs> flairs = Enum.GetValues(typeof(Flairs)).Cast<Flairs>().ToList();
            for (int i = 0; i < filters.Count; i++)
            {
                if (filters[i] == true)
                {
                    profiles = profiles.Where(p => p.Flairs.Contains(flairs[i])).ToList();
                }
            }

            return profiles;
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
