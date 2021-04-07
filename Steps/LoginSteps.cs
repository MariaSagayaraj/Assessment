using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Pages;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class LoginSteps : Page_Login
    {
        [Given(@"I open browser and navigate to the url")]
        public void GivenIOpenBrowserAndNavigateToTheUrl()
        {
            BaseClass init = new BaseClass();
            init.Initialize();
        }
        
        [When(@"I enter (.*) login credentials and click login button")]
        public void WhenIEnterLoginCredentialsAndClickLoginButton(string data)
        {
            Login(data);
        }
        
        [Then(@"I validate successfull login to the application as per the (.*)")]
        public void ThenIValidateSuccessfullLoginToTheApplicationAsPerThe(string data)
        {
            Assertion(data);
           Drivers. CloseBrowser();
        }
    }
}
