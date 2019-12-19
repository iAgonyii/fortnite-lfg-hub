﻿using System.Collections.Generic;
using DataLayer;
using Fortnite_LFG_Hub.Models;

namespace Fortnite_LFG_Hub.Containers
{
    public class ProfilesContainer
    {
        List<Profile> profiles = new List<Profile>();
        
        public List<Profile> GetProfiles()
        {
            List<Profile> profiles = new List<Profile>();
            ProfileCommands pcommands = new ProfileCommands();
            // Make profiles from dtos
            foreach(ProfileDTO pdto in pcommands.GetProfiles())
            {
                Profile profile = new Profile(pdto);
                profiles.Add(profile);
            }
            return profiles;
        }
        public Profile GetProfileData(string id)
        {
            ProfileCommands commands = new ProfileCommands();
            ProfileDTO dto = commands.GetProfileData(id);
            Profile profile = new Profile(dto);
            return profile;
        }
    }
}