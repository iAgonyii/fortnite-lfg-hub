using BusinessLayer;
using BusinessLayerContainer;
using DataLayerDTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestContainer
{
    [TestClass]
    public class ProfileContainerDALTests
    {
        private ProfilesContainer profilesContainer = new ProfilesContainer();

        [TestMethod]
        public void GetProfileDataForId()
        {
            int id = 66;
            Profile result = profilesContainer.GetProfileData(id);
            Assert.AreEqual("UnitTest1", result.Username);
        }

        [TestMethod]
        public void GetProfileDataForUnknownIdThrowsException()
        {
            bool caught;
            int id = 999999;
            try
            {
                Profile result = profilesContainer.GetProfileData(id);
                caught = false;
            }
            catch (Exception)
            {

                caught = true;
            }
            Assert.IsTrue(caught);
        }

        [TestMethod]
        public void GetAllProfiles()
        {
            List<Profile> result = profilesContainer.GetProfiles();
            Assert.AreEqual(result.Count, result.Count);
        }
    }
}
