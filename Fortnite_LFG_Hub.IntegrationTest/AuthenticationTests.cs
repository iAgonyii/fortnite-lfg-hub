using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Fortnite_LFG_Hub.IntegrationTest
{
    public class AuthenticationTests: IDisposable
    {
        private readonly IWebDriver _driver;
        public AuthenticationTests()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        private string baseUrl = "https://localhost:44300/";

        [Fact]
        public void LoginIndexPage()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            Assert.Equal("Login - Fortnite LFG Hub", _driver.Title);
            Assert.Contains("Login", _driver.PageSource);
        }

        [Fact]
        public void LoginUsernameRequired()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Password")).SendKeys("asdasdsad");
            _driver.FindElement(By.Id("submit")).Click();

            var error = _driver.FindElement(By.Id("UsernameValidation")).Text;

            Assert.Equal("The Username field is required.", error);
        }

        [Fact]
        public void LoginInvalidCredentials()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Username")).SendKeys("asdasdasdasd");
            _driver.FindElement(By.Id("Password")).SendKeys("asdasdasdasdasdasd");
            _driver.FindElement(By.Id("submit")).Click();

            var error = _driver.FindElement(By.Id("UsernameValidation")).Text;
            Assert.Equal("Credentials do not match any registered user", error);
        }

        [Fact]
        public void LoginSuccess()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Username")).SendKeys("TestPepega");
            _driver.FindElement(By.Id("Password")).SendKeys("TestLolz");
            _driver.FindElement(By.Id("submit")).Click();

            Assert.Contains("Home", _driver.Title);
        }

        [Fact]
        public void RegisterIndex()
        {
            _driver.Navigate().GoToUrl(baseUrl + "register");

            Assert.Contains("Register", _driver.Title);
        }

        [Fact]
        public void RegisterInputsStringLength()
        {
            _driver.Navigate().GoToUrl(baseUrl + "register");

            _driver.FindElement(By.Id("Username")).SendKeys("a");
            _driver.FindElement(By.Id("Password")).SendKeys("a");
            _driver.FindElement(By.Id("submit")).Click();

            var usernameError = _driver.FindElement(By.Id("UsernameValidation")).Text;
            var passwordError = _driver.FindElement(By.Id("PasswordValidation")).Text;

            Assert.Equal("Your username has to be between 3 and 32 characters long", usernameError);
            Assert.Equal("Your password must be atleast 5 characters long", passwordError);
        }

        [Fact]
        public void RegisterSuccess()
        {
            _driver.Navigate().GoToUrl(baseUrl + "register");

            _driver.FindElement(By.Id("Username")).SendKeys("IntegrationTest");
            _driver.FindElement(By.Id("Password")).SendKeys("inttest321");
            _driver.FindElement(By.Id("submit")).Click();

            Assert.Contains("Home", _driver.Title);
        }

        [Fact]
        public void Logout()
        {
            _driver.Navigate().GoToUrl(baseUrl + "login");

            _driver.FindElement(By.Id("Username")).SendKeys("TestPepega");
            _driver.FindElement(By.Id("Password")).SendKeys("TestLolz");
            _driver.FindElement(By.Id("submit")).Click();
            _driver.FindElement(By.Id("acceptCookie")).Click();
            _driver.FindElement(By.Id("logout")).Click();

            Assert.Contains("Log In", _driver.PageSource);
        }
    }
}
