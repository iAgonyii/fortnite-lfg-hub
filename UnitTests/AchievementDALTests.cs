using BusinessLayer;
using BusinessLayer.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestData
{
    [TestClass]
    public class AchievementDALTests
    {
        private readonly AchievementLogic logic = new AchievementLogic();
        [TestMethod]
        public void UpdateProfileAchievementsNormal()
        {
            bool updated;
            try
            {
                logic.UpdateProfileAchievements(new List<Achievement>() { new Achievement() { Rank = 23, Event = Events.Katowice_Royale_2019_SOLOS }, new Achievement() { Rank = 123, Event = Events.Scallywag_Cup_Finals } }, 66);
                updated = true;
            }
            catch (Exception)
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
            catch (Exception)
            {
                updated = false;
            }
            Assert.IsTrue(updated);
        }
    }
}
