using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestMethod]
        public void GetProfileDataForSearchInput()
        {
            ProfileDTO ExpectedDto = new ProfileDTO();
            ExpectedDto.Username = "iAgonyii"; ExpectedDto.Achievements = "44 - Contender cash cup"; ExpectedDto.FreeText = "Nothing"; ExpectedDto.SocialURL = "https://twitter.com/iagonyii";

            ProfileCommands profileCommands = new ProfileCommands();
            ProfileDTO ActualDto = profileCommands.GetProfileData("iAgonyii");

            Assert.AreEqual(ExpectedDto.Achievements, ActualDto.Achievements);
        }
    }
}
