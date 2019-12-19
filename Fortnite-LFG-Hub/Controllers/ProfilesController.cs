using DataLayer;
using Fortnite_LFG_Hub.Containers;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.Models.ViewModels;
using Fortnite_LFG_Hub.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fortnite_LFG_Hub.Controllers
{
    public class ProfilesController : Controller
    {
        // GET: /<controller>/       

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("user/{id}/edit")]
        public IActionResult EditProfile(string id, EditProfileViewModel edit)
        {
            if (ModelState.IsValid)
            {
                //ProfileDTO dto = CreateDtoFromInput(edit.profile);
                //commands.UpdateProfile(dto);
                return View(Profile(HttpContext.Session.Get<Profile>("UserProfile").Username));
            }
            else
            {
                return View("Index", edit);
            }
        }

        [HttpPost]
        [Route("user/{id}/edit/achievements")]
        public IActionResult EditProfileAchievements(string id, List<Achievement> edit)
        {
            if (ModelState.IsValid)
            {
                //ProfileDTO dto = CreateDtoFromInput(edit.profile);
                //commands.UpdateProfile(dto);
                return View(Profile(HttpContext.Session.Get<Profile>("UserProfile").Username));
            }
            else
            {
                return View("Index", edit);
            }
        }

        [Route("user/{id}/edit")]
        public IActionResult EditProfile(string id)
        {
            if (HttpContext.Session.Get<Profile>("UserProfile") == null)
            {
                return View("Error", new Error() { errorMessage = "You are not logged in." });
            }
            else if (id != HttpContext.Session.Get<Profile>("UserProfile").Username)
            {
                return View("Error", new Error() { errorMessage = "You are not allowed to edit this profile." });
            }
            else
            {
                return View("Index", new EditProfileViewModel());
            }
        }

        [Route("user/{id}")]
        public IActionResult Profile(string id)
        {
            try
            {
                ProfilesContainer container = new ProfilesContainer();
                return View("Profile", container.GetProfileData(id));
            }
            catch(Exception)
            {
                return View("Error", new Error() { errorMessage = "No profile found for this user" });
            }
        }

        public IActionResult ProfilesRepo()
        {
            ProfilesContainer container = new ProfilesContainer();
            return View(container.GetProfiles());
        }

        [Route("login")]
        public IActionResult LoginIndex()
        {
            AuthProfileViewModel authProfileViewModel = new AuthProfileViewModel();
            if(HttpContext.Session.Get<Profile>("UserProfile") != null)
            {
                return View("Login", authProfileViewModel);
            }
            else
            {
                return View("Error", new Error() { errorMessage = "You are already logged in" });
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(AuthProfileViewModel user)
        {
            if (ModelState.IsValid)
            {
                // Check credentials
                Profile profile = new Profile();
                if(profile.Login(user.Username, user.Password))
                {
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
            return View("Register", HttpContext.Session.Get<Profile>("UserProfile"));
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(AuthProfile user)
        {
            if (ModelState.IsValid)
            {
                ProfileDTO dto = new ProfileDTO() { Username = user.Username, Password = user.Password };
                commands.RegisterNewProfile(dto);
                HttpContext.Session.Set("UserProfile", user);
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        [Route("error")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        public ProfileDTO CreateDtoFromInput(Profile input)
        {
            ProfileDTO dto = new ProfileDTO();
            dto.UserId = HttpContext.Session.Get<Profile>("UserProfile").UserId;
            dto.FreeText = input.FreeText;
            dto.Region = input.Region.ToString();
            dto.Picture = input.Picture;
            dto.Looking = input.Looking;
            dto.SocialURL = input.SocialURL;
            List<AchievementDTO> adtos = new List<AchievementDTO>();
            foreach(Achievement achievement in input.Achievements)
            {
                if (achievement.Rank != null && achievement.Event != Events._)
                {
                    adtos.Add(new AchievementDTO() { Rank = (int)achievement.Rank, Event = achievement.Event.ToString() });
                }
            }
            dto.achievementDTOs = adtos;
            return dto;
        }
    }
}
