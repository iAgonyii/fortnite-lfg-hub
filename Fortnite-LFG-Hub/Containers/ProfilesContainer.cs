using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fortnite_LFG_Hub.Models;

namespace Fortnite_LFG_Hub.Containers
{
    internal class ProfilesContainer
    {
        List<Profile> profiles = new List<Profile>();

        public ProfilesContainer()
        {
            profiles.Add(new Profile("#1 FNCS Week 1", "iAgonyii", 1));
            profiles.Add(new Profile("#1 FNCS Week 2", "mitr0", 2));
        }

        public List<Profile> getAllProfiles()
        {
            return profiles;
        }

        public Profile getProfileDetails(int profileID)
        {
            Profile detailsOfProfile = profiles.Find(profile => profile.id == profileID);
            return detailsOfProfile;
        }

    }
}
