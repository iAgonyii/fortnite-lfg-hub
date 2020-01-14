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
    public class HomeTests : IDisposable
    {
        private readonly IWebDriver _driver;
        public HomeTests()
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
        public void HomeIndexPage()
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Assert.Contains("Home", _driver.Title);
        }

        [Fact]
        public void SearchResults()
        {
            _driver.Navigate().GoToUrl(baseUrl);

            _driver.FindElement(By.Id("searchInput")).SendKeys("TestPep");
            _driver.FindElement(By.Id("searchSubmit")).Click();

            Assert.Contains("TestPepega", _driver.PageSource);
        }

        [Fact]
        public void FilterResults()
        {
            _driver.Navigate().GoToUrl(baseUrl);

            _driver.FindElement(By.Id("z4_")).Click();
            _driver.FindElement(By.Id("filterSubmit")).Click();

            Assert.Contains("TestPepega", _driver.PageSource);
        }
    }
}
