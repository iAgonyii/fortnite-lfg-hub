using DataLayer;
using Fortnite_LFG_Hub.Containers;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fortnite_LFG_Hub.Controllers
{
    public class ProfilesController : Controller
    {
        private ProfilesContainer profileRep = new ProfilesContainer();
        private ProfileCommands commands = new ProfileCommands();

        // GET: /<controller>/

        //public IActionResult Index()
        //{
        //    EditProfileViewModel vmodel = new EditProfileViewModel();
        //    vmodel.profile.Achievements = new List<Achievement> { new Achievement(), new Achievement(), new Achievement() };
        //    return View("Index", vmodel);
        //}

        [ValidateAntiForgeryToken]
        public IActionResult IndexValidation(EditProfileViewModel edit)
        {
            if (ModelState.IsValid)
            {
                //ProfileDTO dto = CreateDtoFromInput(edit.profile);
                //commands.SaveNewProfile(dto);

                return View(Profile());
            }
            else
            {
                return View("Index", edit);
            }
        }

        public IActionResult Profile()
        {
            return View("Profile", HttpContext.Session.Get<Profile>("UserProfile"));
        }

        public IActionResult ProfilesRepo()
        {
            return View(profileRep.GetProfiles());
        }

        public IActionResult LoginIndex()
        {
            Profile user = new Profile();
            return View("Login", user);
        }

        public IActionResult Login(Profile user)
        {
            if (ModelState.IsValid)
            {
                if (commands.CheckCredentials(user.Username, user.Password))
                {
                    Profile profile = new Profile(commands.GetProfileData(user.Username));
                    profile.LoggedIn = true;
                    HttpContext.Session.Set("UserProfile", profile);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("Username", "Credentials do not match any registered user");
                return View(user);
            }
            return View(user);
        }

        public IActionResult RegisterIndex()
        {
            Profile user = new Profile();
            return View("Register", user);
        }

        public IActionResult Register(Profile user)
        {
            if (ModelState.IsValid)
            {
                ProfileDTO dto = new ProfileDTO() { Username = user.Username, Password = user.Password };
                //commands.RegisterNewProfile(dto);
                user.LoggedIn = true;
                HttpContext.Session.Set("UserProfile", user);
                //HttpContext.Session.Get<Profile>("UserProfile");
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }



        public ProfileDTO CreateDtoFromInput(Profile input)
        {
            ProfileDTO dto = new ProfileDTO();
            dto.Username = input.Username;
            dto.FreeText = input.FreeText;
            dto.SocialURL = input.SocialURL;
            List<AchievementDTO> adtos = new List<AchievementDTO>();
            foreach(Achievement achievement in input.Achievements)
            {
                adtos.Add(new AchievementDTO() { Rank = (int)achievement.Rank, Event = achievement.Event.ToString() });
            }
            dto.achievementDTOs = adtos;

            //for(int i = 0; i < adtos.Count; i++)
            //{
            //    if(adtos[i].Rank == 0)
            //    {
            //        adtos.Remove(adtos[i]);
            //    }
            //}

            return dto;
        }
    }
}
