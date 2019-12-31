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
            CommentsContainer cContainer = new CommentsContainer();
            AchievementsContainer aContainer = new AchievementsContainer();

            // Make profiles from dtos
            foreach (ProfileDTO pdto in commands.GetProfiles())
            {
                Profile profile = new Profile(pdto);
                profile.Comments = cContainer.GetComments(profile.UserId);
                profile.Achievements = aContainer.GetAchievementsForProfile(profile.UserId);
                profiles.Add(profile);
            }

            return profiles;
        }

        // Get all the data of a profile. This includes: achievements, socials and comments.
        public Profile GetProfileData(int id)
        {
            CommentsContainer cContainer = new CommentsContainer();
            AchievementsContainer aContainer = new AchievementsContainer();

            ProfileDTO dto = commands.GetProfileData(id);
            Profile profile = new Profile(dto);

            profile.Comments = cContainer.GetComments(profile.UserId);
            profile.Achievements = aContainer.GetAchievementsForProfile(profile.UserId);
            return profile;
        }
    }
}
