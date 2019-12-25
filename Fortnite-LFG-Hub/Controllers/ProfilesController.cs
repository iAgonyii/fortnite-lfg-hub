using BusinessLayer;
using BusinessLayer.Logic;
using BusinessLayerContainer;
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
        public IActionResult EditProfile(int id, EditProfileViewModel edit)
        {
            if (ModelState.IsValid)
            {
                ProfileLogic logic = new ProfileLogic();
                logic.UpdateProfileInfo(id, edit.FreeText, edit.SocialURL, edit.Looking, edit.Picture, edit.Region);
                return RedirectToAction("Profile", id);
            }
            else
            {
                return View("Index", edit);
            }
        }

        [HttpPost]
        public IActionResult EditProfileAchievements(int id, List<Achievement> edit)
        {
            if (ModelState.IsValid)
            {
                ProfileLogic logic = new ProfileLogic();
                logic.UpdateProfileAchievements(edit, id);
                return RedirectToAction("Profile", id);
            }
            else
            {
                return View("Index", edit);
            }
        }

        [Route("user/{id}/edit")]
        public IActionResult EditProfile(int id)
        {
            if (HttpContext.Session == null)
            {
                return View("Error", new Error() { errorMessage = "You are not logged in." });
            }
            else
            {
                if (HttpContext.Session.Get<int>("UserId") != id)
                {
                    return View("Error", new Error() { errorMessage = "You are not allowed to edit this profile." });
                }
                ProfilesContainer container = new ProfilesContainer();
                Profile profile = container.GetProfileData(id);
                EditProfileViewModel vm = new EditProfileViewModel() { FreeText = profile.FreeText, Looking = profile.Looking, Picture = profile.Picture, SocialURL = profile.SocialURL, Region = profile.Region };

                for(int i = 0; i < profile.Achievements.Count; i++)
                {
                    vm.Achievements[i] = profile.Achievements[i];
                }

                return View("Index", vm);
            }
        }

        [Route("user/{id}")]
        public IActionResult Profile(int id)
        {
            Profile profile;
            try
            {
                ProfilesContainer container = new ProfilesContainer();
                profile = container.GetProfileData(id);
            }
            catch(Exception e)
            {
                return View("Error", new Error() { errorMessage = e.ToString() });
            }
            return View("Profile", profile);
        }

        public IActionResult ProfilesRepo()
        {
            ProfilesContainer container = new ProfilesContainer();
            return View(container.GetProfiles());
        }


    }
}
