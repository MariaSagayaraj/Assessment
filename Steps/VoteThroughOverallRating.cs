using System;
using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughOverallRatingCategorySteps : Vote
    {
        [Given(@"I login to application with (.*) inputs")]
        public void GivenILoginToApplicationWithInputs(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login("valid");
        }
        
        [Given(@"I click on the Overall rating category")]
        public void GivenIClickOnTheOverallRatingCategory()
        {
            WaitHelpers.TurnOnWait();
            Category3.Click();
        }

        [Given(@"I select the car to vote")]
        public void GivenISelectTheCarToVote()
        {
            OverallModel();
        }

        [When(@"I Add a comment and vote")]
        public void WhenIAddACommentAndVote()
        {
            AddCommentAndVote();
        }

        [Then(@"I should be able to see the successful vote message (.*)")]
        public void ThenIShouldBeAbleToSeeTheSuccessfulVoteMessage(string name)
        {
            AssertVote();
            Drivers.SaveScreenshot(name);
            Drivers.CloseBrowser();
        }
    }
}
