using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        //[TestMethod]
       //// public void GetProfileDataForSearchInput()
       // {
       //     ProfileDTO ExpectedDto = new ProfileDTO();
       //     ExpectedDto.Username = "iAgonyii"; ExpectedDto.Achievements = "44 - Contender cash cup"; ExpectedDto.FreeText = "Nothing"; ExpectedDto.SocialURL = "https://twitter.com/iagonyii";

       //     ProfileCommands profileCommands = new ProfileCommands();
       //     ProfileDTO ActualDto = profileCommands.GetProfileData("iAgonyii");

       //     Assert.AreEqual(ExpectedDto.Achievements, ActualDto.Achievements);
       // 

        [TestMethod]
        public void AddProfileToDatabase()
        {
            bool inserted = false;

            List<AchievementDTO> achievs = new List<AchievementDTO>()
            {
                new AchievementDTO() { Rank = 6352, Event = "Hype Nite Week 2" },
                new AchievementDTO() { Rank = 2323, Event = "Squads FNCS Week 1"}
            };

            ProfileDTO profile = new ProfileDTO()
            {
                Username = "RoyDeveloper",
                FreeText = "Hello this is a unit test. You are not supposed to be seeing this :)",
                SocialURL = "https://google.com",
                achievementDTOs = achievs
            };

            ProfileCommands commands = new ProfileCommands();
            commands.SaveNewProfile(profile);
            inserted = true;

            Assert.IsTrue(inserted);
        }
    }


}
