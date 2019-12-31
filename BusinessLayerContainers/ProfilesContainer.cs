using System.Collections.Generic;
using BusinessLayer;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;

namespace BusinessLayerContainer
{
    public class ProfilesContainer
    {
        public List<Profile> profiles;
        private readonly IProfileContainerCommands commands = new ProfileCommands();

        public List<Profile> GetProfiles()
        {
            profiles = new List<Profile>();

            // Make profiles from dtos
            foreach (ProfileDTO pdto in commands.GetProfiles())
            {
                Profile profile = new Profile(pdto);
                profiles.Add(profile);
            }

            return profiles;
        }

        // Get all the data of a profile. This includes: achievements, socials and comments.
        public Profile GetProfileData(int id)
        {
            ProfileDTO dto = commands.GetProfileData(id);
            Profile profile = new Profile(dto);
            return profile;
        }
    }
}
