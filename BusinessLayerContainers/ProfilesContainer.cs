using System.Collections.Generic;
using BusinessLayer;

namespace BusinessLayerContainer
{
    public class ProfilesContainer
    {
        List<Profile> profiles;
        
        public List<Profile> GetProfiles()
        {
            profiles = new List<Profile>();
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
