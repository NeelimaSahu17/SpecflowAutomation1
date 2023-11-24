using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;


        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }


       [Given(@"I navigate to login page")]
        public void GivenINavigateToLoginPage()
        {
            _loginPage.NavigateToUrl();
        }


        [Given(@"I enter the ""([^""]*)"" and ""([^""]*)""")]
        public void GivenIEnterTheAnd(string username, string password)
        {
            _loginPage.Login(username, password);
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            
        }




    }
}
