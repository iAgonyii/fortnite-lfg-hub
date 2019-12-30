using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.Models.ViewModels;
using BusinessLayerContainer;
using BusinessLayer;

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

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
