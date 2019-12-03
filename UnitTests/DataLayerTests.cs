using DataLayer;
using DataLayer.DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        ProfileCommands profileCommands = new ProfileCommands();
        UserCommands userCommands = new UserCommands();

        // Test can only run once to avoid duplicates
        [TestMethod]
        public void AddProfileToDatabase()
        {
            bool inserted = false;

            List<AchievementDTO> achievs = new List<AchievementDTO>()
            {
                new AchievementDTO() { Rank = 6352, Event = "Winter_Royale_Qualifiers" },
                new AchievementDTO() { Rank = 2323, Event = "Luxe_Cup_Finals" }
            };

            ProfileDTO profile = new ProfileDTO()
            {
                Username = "RoyDeveloper",
                FreeText = "Hello this is a unit test. You are not supposed to be seeing this :)",
                SocialURL = "https://google.com",
                achievementDTOs = achievs
            };

            try
            {
                profileCommands.SaveNewProfile(profile);
                inserted = true;
            }
            catch (Exception) { }
            
            Assert.IsTrue(inserted);
        }

        [TestMethod]
        public void GetProfileDtoFromSearch()
        {
            string search = "RoyDev";

            ProfileDTO profile = profileCommands.GetProfileData(search);

            Assert.AreEqual("RoyDeveloper", profile.Username);
        }

        [TestMethod]
        public void AddNewUserToDatabase()
        {
            bool inserted = false;
            UserDTO dto = new UserDTO() { Username = "TestUser", Password = "TestPassword" };

            try
            {
                userCommands.SaveNewUser(dto);
                inserted = true;
            }
            catch (Exception) { }
            Assert.IsTrue(inserted);
        }
    }


}
