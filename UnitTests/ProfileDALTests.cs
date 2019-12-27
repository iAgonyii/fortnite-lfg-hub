using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        ProfileCommands profileCommands = new ProfileCommands();

        // Test can only run once with the same values.
        [TestMethod]
        public void UpdateProfile()
        {
            List<AchievementDTO> achvs = new List<AchievementDTO>() { new AchievementDTO() { Rank = 60, Event = "Wintyale 2018" }, new AchievementDTO() { Rank = 120, Event = "FNCS quads" }, };
            ProfileDTO profile = new ProfileDTO() { UserId = 60, FreeText = "Test", SocialURL = "TeL.com", Looking = "True", Region = "EU", Picture = "TestPic", achievementDTOs = achvs };

            bool updated = false;
            try
            {
                profileCommands.UpdateProfile(profile);
                updated = true;
            }
            catch(Exception)
            {

            }
            Assert.IsTrue(updated);

        }

        [TestMethod]
        public void GetProfileDtoFromSearch()
        {
            string search = "RoyDev";

            ProfileDTO profile = profileCommands.GetProfileData(search);

            Assert.AreEqual("RoyDeveloper", profile.Username);
        }
    }


}
