using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fortnite_LFG_Hub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fortnite_LFG_Hub.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Auth(User user)
        {
            return View("Index");
        }
    }
}