using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Steps
{
    [Binding]
    public  class UserFormSteps
    {

        [Given(@"I start entering user form details like")]
        public void GivenIStartEnteringUserFormDetailsLike(Table table)
        {
            Console.WriteLine("I enter user details");
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            Console.WriteLine("I click submit button");
        }

        [Then(@"I verify the entered user form details in the application database")]
        public void ThenIVerifyTheEnteredUserFormDetailsInTheApplicationDatabase(Table table)
        {
            Console.WriteLine("I verify the user form details");
        }

        [Then(@"I logout of application")]
        public void ThenILogoutOfApplication()
        {
            Console.WriteLine("I logged out :");
        }

    }
}
