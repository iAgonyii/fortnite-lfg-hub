using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Logic;
using System;

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
            catch(Exception)
            {
                exceptionCaught = true;
            }

            Assert.IsTrue(exceptionCaught);
        }
    }
}
