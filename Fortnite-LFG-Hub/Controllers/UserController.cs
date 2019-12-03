using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DTOs;
using Fortnite_LFG_Hub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fortnite_LFG_Hub.Controllers
{
    public class UserController : Controller
    {
        UserCommands userCommands = new UserCommands();

        public IActionResult RegisterIndex()
        {
            return View("Register");
        }
        public IActionResult AuthIndex()
        {
            return View("Auth");
        }

        public IActionResult Auth(LoggedInUser user)
        {
            if(ModelState.IsValid)
            {
                if(userCommands.CheckCredentials(user.Username, user.Password))
                {
                    return View("../Home/Index");
                }
                return View(user);
            }
            return View(user);
        }

        public IActionResult Register(LoggedInUser user)
        {
            if(ModelState.IsValid)
            {
                UserDTO dto = new UserDTO() { Username = user.Username, Password = user.Password };
                userCommands.SaveNewUser(dto);
                return View("../Home/Index");
            }
            return View(user);
        }

    }
}