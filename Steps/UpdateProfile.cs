using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class UpdateProfileSteps : Page_Profile
    {
        [Given(@"I login to the application using (.*) credentials")]
        public void GivenILoginToTheApplicationUsingCredentials(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login("valid");
        }

        [Given(@"I enter data to all fields")]
        public void GivenIEnterDataToAllFields()
        {
            UpdateProfile();
        }
        [Given(@"I enter data to the password fields")]
        public void GivenIEnterDataToThePasswordFields()
        {
            ChangePassword();
        }

        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            SaveButton.Click();
        }
        
        [Then(@"The profile should be saved successfully")]
        public void ThenTheProfileShouldBeSavedSuccessfully()
        {
            AssertUpdate();
            Drivers.CloseBrowser();
        }

        [Then(@"The password should be changed successfully")]
        public void ThenThePasswordShouldBeChangedSuccessfully()
        {
            AssertUpdate();
            Drivers.CloseBrowser();
        }
    }
}
