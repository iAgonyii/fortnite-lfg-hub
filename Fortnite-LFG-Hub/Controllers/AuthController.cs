﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Logic;
using Fortnite_LFG_Hub.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fortnite_LFG_Hub.Controllers
{
    public class AuthController : Controller
    {
        [Route("login")]
        public IActionResult LoginIndex()
        {
            return View("Login", new AuthProfileViewModel());
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(AuthProfileViewModel user)
        {
            if (ModelState.IsValid)
            {
                ProfileLogic logic = new ProfileLogic();
                if (logic.Login(user.Username, user.Password))
                {
                    // If we logged in save the Username and UserId in the session
                    HttpContext.Session.Set("Username", user.Username);
                    HttpContext.Session.Set("UserId", logic.GetUserIdForName(user.Username));
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("Username", "Credentials do not match any registered user");
                return View(user);
            }
            return View(user);
        }

        [Route("register")]
        public IActionResult RegisterIndex()
        {
            return View("Register", new AuthProfileViewModel());
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(AuthProfileViewModel user)
        {
            if (ModelState.IsValid)
            {
                ProfileLogic logic = new ProfileLogic();
                try
                {
                    logic.Register(user.Username, user.Password);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("Username", "This username is already taken");
                    return View(user);
                }
                // If we succesfully registered we 'login' and save the values in the session.
                HttpContext.Session.Set("Username", user.Username);
                HttpContext.Session.Set("UserId", logic.GetUserIdForName(user.Username));
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        public IActionResult Logout()
        {
            // Clear all data in the session so we logout.
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}