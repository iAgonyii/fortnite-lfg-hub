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
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("Username,AchievementsRank1,AchievementsEvent1,AchievementsRank2,AchievementsEvent2,AchievementsRank3,AchievementsEvent3,Freetext,SocialURL")] EditProfileViewModel edit)
        {
            if (ModelState.IsValid)
            {
                ProfileDTO dto = CreateDtoFromInput(edit);
                //commands.SaveNewProfile(dto);
                Profile prof = new Profile(dto);
                return View("Profile", prof);
            }
            else
            {
                return View(edit);
            }
        }

        public ProfileDTO CreateDtoFromInput(EditProfileViewModel input)
        {
            ProfileDTO dto = new ProfileDTO();

            List<AchievementDTO> adtos = new List<AchievementDTO>();
            AchievementDTO adto = new AchievementDTO();
            AchievementDTO adto2 = new AchievementDTO();
            AchievementDTO adto3 = new AchievementDTO();
            adto.Rank = Convert.ToInt32(input.AchievementsRank1);
            adto.Event = input.AchievementsEvent1;
            adto2.Rank = Convert.ToInt32(input.AchievementsRank2);
            adto2.Event = input.AchievementsEvent2;
            adto3.Rank = Convert.ToInt32(input.AchievementsRank3);
            adto3.Event = input.AchievementsEvent3;
            adtos.Add(adto);
            adtos.Add(adto2);
            adtos.Add(adto3);


            dto.Username = input.Username;
            dto.achievementDTOs = adtos;
            dto.FreeText = input.Freetext;
            dto.SocialURL = input.SocialURL;

            return dto;
        }
    }
}
