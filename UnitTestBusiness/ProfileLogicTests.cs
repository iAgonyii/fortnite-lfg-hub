using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Logic;
using System;
using System.Collections.Generic;
using DataLayerDTO;

namespace UnitTestBusiness
{
    [TestClass]
    public class ProfileLogicTests
    {
        private ProfileLogic logic = new ProfileLogic();
        [TestMethod]
        public void LoginSuccess()
        {
            bool loggedIn;
            loggedIn = logic.Login("TestPepega", "TestLolz");

            Assert.IsTrue(loggedIn);
        }

        [TestMethod]
        public void LoginFail()
        {
            bool loggedIn;
            loggedIn = logic.Login("TestPepega", "idontknow");

            Assert.IsFalse(loggedIn);
        }

        [TestMethod]
        public void RegisterWithUsedName()
        {
            bool exceptionCaught;
            try
            {
                logic.Register("TestPepega", "test123");
                exceptionCaught = false;
            }
            catch (Exception)
            {
                exceptionCaught = true;
            }

            Assert.IsTrue(exceptionCaught);
        }

        [TestMethod]
        public void UpdateProfileInfoEverythingFilled()
        {
            bool updated;
            try
            {
                logic.UpdateProfileInfo(66, "TestFreeText", "https://google.com", false, "TestPicture", Regions.Oceania);
                updated = true;
            }
            catch (Exception)
            {
                updated = false;
            }

            Assert.IsTrue(updated);
        }

        [TestMethod]
        public void UpdateProfileInfoWithNullValues()
        {
            bool updated;
            try
            {
                logic.UpdateProfileInfo(66, null, null, true, null, Regions._);
                updated = true;
            }
            catch (Exception)
            {
                updated = false;
            }

            Assert.IsTrue(updated);
        }

        [TestMethod]
        public void UpdateProfileAchievementsNormal()
        {
            bool updated;
            try
            {
                logic.UpdateProfileAchievements(new List<Achievement>() { new Achievement() { Rank = 23, Event = Events.Katowice_Royale_2019_SOLOS }, new Achievement() { Rank = 123, Event = Events.Scallywag_Cup_Finals } }, 66);
                updated = true;
            }
            catch(Exception)
            {
                updated = false;
            }

            Assert.IsTrue(updated);
        }

        [TestMethod]
        public void UpdateProfileAchievementsAllEmpty()
        {
            bool updated;
            try
            {
                logic.UpdateProfileAchievements(new List<Achievement>() { new Achievement(), new Achievement(), new Achievement(), }, 66);
                updated = true;
            }
            catch(Exception)
            {
                updated = false;
            }
            Assert.IsTrue(updated);
        }

        [TestMethod]
        public void GetUserIdForName()
        {
            int expected = 66;
            int result = logic.GetUserIdForName("UnitTest1");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetUserIdForUnknownName()
        {
            int expected = 0;
            int result = logic.GetUserIdForName("asdasdasdcsadasd");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DtosToAchievements()
        {
            List<AchievementDTO> adtos = new List<AchievementDTO>() { new AchievementDTO() { Rank = 50, Event = "Luxe_Cup_Finals" }, new AchievementDTO() { Rank = 123, Event = "Katowice_Royale_2019_DUOS" }, };
            List<Achievement> expected = new List<Achievement>() { new Achievement() { Rank = 50, Event = Events.Luxe_Cup_Finals }, new Achievement() { Rank = 123, Event = Events.Katowice_Royale_2019_DUOS } };

            List<Achievement> result = logic.DtosToAchievements(adtos);

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
