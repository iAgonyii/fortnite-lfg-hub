﻿using System.Collections.Generic;
using BusinessLayer;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;

namespace BusinessLayerContainer
{
    public class ProfilesContainer
    {
        List<Profile> profiles;
        private IProfileContainerCommands commands;
        private IAchievementCommands aCommands;

        public List<Profile> GetProfiles()
        {
            profiles = new List<Profile>();
            commands = new ProfileCommands();

            // Make profiles from dtos
            foreach (ProfileDTO pdto in commands.GetProfiles())
            {
                Profile profile = new Profile(pdto);
                profiles.Add(profile);
            }

            return profiles;
        }
        public Profile GetProfileData(int id)
        {
            commands = new ProfileCommands();
            aCommands = new AchievementCommands();

            ProfileDTO dto = commands.GetProfileData(id);
            dto.achievementDTOs = aCommands.GetAchievements(id);

            Profile profile = new Profile(dto);
            return profile;
        }
    }
}