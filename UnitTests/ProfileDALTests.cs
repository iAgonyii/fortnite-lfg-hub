using BusinessLayer;
using BusinessLayer.Logic;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestData
{
    [TestClass]
    public class ProfileDALTests
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
    }


}
