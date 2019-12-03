using DataLayer;
using Fortnite_LFG_Hub.Containers;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.Models.ViewModels;
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
                return View("Profile", edit.profile);
            }
            else
            {
                return View("Index", edit);
            }
        }

        public IActionResult ProfilesRepo()
        {
            return View(profileRep.GetProfiles());
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
