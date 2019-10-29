using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fortnite_LFG_Hub.Containers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fortnite_LFG_Hub.Controllers
{
    public class ProfilesController : Controller
    {
        private ProfilesContainer profileRep = new ProfilesContainer();

    // GET: /<controller>/
        public IActionResult Index()
        {
            return View(profileRep.getAllProfiles());
        }
    }
}
