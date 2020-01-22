using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace Fortnite_LFG_Hub.IntegrationTest
{
    public class ProfileTests : IDisposable
    {
        private readonly IWebDriver _driver;
        public ProfileTests()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        private string baseUrl = "https://localhost:44300/";

        [Fact]
        public void GoToProfilePage()
        {
            _driver.Navigate().GoToUrl(baseUrl + "user/57");

            Assert.Contains("TestPepega", _driver.PageSource);
        }

        [Fact]
        public void GoToProfilePageLoggedIn()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Username")).SendKeys("TestPepega");
            _driver.FindElement(By.Id("Password")).SendKeys("TestLolz");
            _driver.FindElement(By.Id("submit")).Click();
            _driver.Navigate().GoToUrl(baseUrl + "user/57");

            Assert.Contains("Edit Profile Details", _driver.PageSource);
        }

        [Fact]
        public void EditProfileDetailsLoggedIn()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Username")).SendKeys("TestPepega");
            _driver.FindElement(By.Id("Password")).SendKeys("TestLolz");
            _driver.FindElement(By.Id("submit")).Click();
            _driver.Navigate().GoToUrl(baseUrl + "user/57");
            _driver.FindElement(By.Id("editDetails")).Click();
            _driver.FindElement(By.Id("FreeText")).SendKeys("INTEGRATION TESTS ARE SOOOO COOL LOL!!!!!!!");
            _driver.FindElement(By.Id("submitDetails")).Click();

            Assert.Contains("INTEGRATION TESTS ARE SOOOO COOL LOL!!!!!!!", _driver.PageSource);
        }

        [Fact]
        public void EditProfileWithoutLoggedIn()
        {
            _driver.Navigate().GoToUrl(baseUrl + "user/57/edit");

            Assert.Contains("You are not allowed to edit this profile.", _driver.PageSource);
        }
    }
}
