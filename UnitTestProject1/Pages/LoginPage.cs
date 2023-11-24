using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Pages
{
    [Binding]
    public class LoginPage
    {
        private IWebDriver _driver;
        public readonly By Username = By.Id("username");
        public readonly By Password = By.Id("password");
        public readonly By SignIn = By.Id("log-in");

        public void NavigateToUrl()
        {
            _driver.Navigate().GoToUrl("https://demo.applitools.com/");
        }

        public void Login(string username, string password)
        {
            _driver.FindElement(Username).SendKeys(username);
            _driver.FindElement(Password).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(SignIn).Click();
        }
    }
}
