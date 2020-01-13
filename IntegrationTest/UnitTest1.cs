using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace IntegrationTest
{
    public class UnitTest1: IDisposable
    {
        private readonly IWebDriver _driver;
        public UnitTest1()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        public string baseUrl = "https://localhost:44300/";

        [Fact]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            Assert.Equal("login - Fortnite LFG Hub", _driver.Title);
        }
    }
}
