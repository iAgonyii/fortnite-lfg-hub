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
        public IActionResult Index([Bind] EditProfileViewModel edit)
        {
            if (ModelState.IsValid)
            {
                ProfileDTO dto = CreateDtoFromInput(edit);
                commands.SaveNewProfile(dto);
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
            List<AchievementDTO> adtos = new List<AchievementDTO>()
            {
                new AchievementDTO { Rank = input.AchievementsRank1, Event = input.AchievementsEvent1},
                new AchievementDTO { Rank = (int)input.AchievementsRank2, Event = input.AchievementsEvent2},
                new AchievementDTO { Rank = (int)input.AchievementsRank3, Event = input.AchievementsEvent3},
            };

            foreach(AchievementDTO adto in adtos)
            {
                if(adto.Rank == 0 && adto.Event == "")
                {
                    adtos.Remove(adto);
                }
            }

            ProfileDTO dto = new ProfileDTO();

            dto.Username = input.Username;
            dto.achievementDTOs = adtos;
            dto.FreeText = input.Freetext;
            dto.SocialURL = input.SocialURL;

            return dto;
        }
    }
}
