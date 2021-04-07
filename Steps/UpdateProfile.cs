using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class UpdateProfileSteps
    {
        [Given(@"I login to the application using ""(.*)"" credentials")]
        public void GivenILoginToTheApplicationUsingCredentials(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login(valid);
        }

        [Given(@"I click on Profile menu")]
        public void GivenIClickOnProfileMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter (.*) data to all fields")]
        public void GivenIEnterDataToAllFields(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter (.*) data to the password fields")]
        public void GivenIEnterDataToThePasswordFields(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The profile should be saved successfully")]
        public void ThenTheProfileShouldBeSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The password should be changed successfully")]
        public void ThenThePasswordShouldBeChangedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
