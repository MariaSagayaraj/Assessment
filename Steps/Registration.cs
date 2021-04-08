using OpenQA.Selenium.Internal;
using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class Registration : Page_Registration
    {
        [Given(@"I Navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            BaseClass init = new BaseClass();
            init.Initialize();
        }
        
        [Given(@"I click on Register button")]
        public void GivenIClickOnRegisterButton()
        {
            RegButton.Click();
        }

        [Given(@"I enter data to the fields")]
        public void GivenIEnterDataToTheFields()
        {
            Register();
        }

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            RegisterButton.Click();
        }
        
        [Then(@"I should be registered successfully")]
        public void ThenIShouldBeRegisteredSuccessfully()
        {
            RegAssertion();
            Drivers.SaveScreenshot();
            Drivers.CloseBrowser();
        }
    }
}
