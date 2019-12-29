using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Logic;
using System;
using System.Collections.Generic;
using DataLayerDTO;

namespace UnitTestBusiness
{
    [TestClass]
    public class AchievementLogicTests
    {
        private readonly AchievementLogic logic = new AchievementLogic();
        [TestMethod]
        public void DtosToAchievements()
        {
            List<AchievementDTO> adtos = new List<AchievementDTO>() { new AchievementDTO() { Rank = 50, Event = "Luxe_Cup_Finals" }, new AchievementDTO() { Rank = 123, Event = "Katowice_Royale_2019_DUOS" }, };
            List<Achievement> expected = new List<Achievement>() { new Achievement() { Rank = 50, Event = Events.Luxe_Cup_Finals }, new Achievement() { Rank = 123, Event = Events.Katowice_Royale_2019_DUOS } };

            List<Achievement> result = logic.DtosToAchievements(adtos);

            Assert.AreEqual(expected[0].Event, result[0].Event);
        }

        [TestMethod]
        public void DtosToAchievementsEmptyDtoList()
        {
            List<AchievementDTO> adtos = new List<AchievementDTO>();
            List<Achievement> expected = new List<Achievement>();

            List<Achievement> result = logic.DtosToAchievements(adtos);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
