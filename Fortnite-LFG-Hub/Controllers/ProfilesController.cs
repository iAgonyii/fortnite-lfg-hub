using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fortnite_LFG_Hub.Containers;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fortnite_LFG_Hub.Controllers
{
    public class ProfilesController : Controller
    {
        private ProfilesContainer profileRep = new ProfilesContainer();

    // GET: /<controller>/
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("Username,Achievements,Freetext,SocialURL")] EditProfileViewModel edit)
        {
            if(ModelState.IsValid)
            {
                Profile prof = new Profile(edit.Username, edit.Achievements, edit.Freetext, edit.SocialURL);
                return View(edit);
            }
            return View();
        }
    }
}
