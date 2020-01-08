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
        private readonly ProfileLogic logic = new ProfileLogic();
        [TestMethod]
        public void UpdateProfileAchievementsNormal()
        {
            bool updated;
            try
            {
                logic.UpdateProfileAchievements(new List<Achievement>() { new Achievement() { Rank = 23, EventId = "2" }, new Achievement() { Rank = 123, EventId = "3" } }, 66);
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
