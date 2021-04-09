using System;
using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughPopularMakeSteps : Vote
    {
        [Given(@"I login to the application with (.*) inputs")]
        public void GivenILoginToTheApplicationWithInputs(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login("valid");
        }

        [Given(@"I click on the Popular Make category")]
        public void GivenIClickOnThePopularMakeCategory()
        {
            WaitHelpers.TurnOnWait();
            Category1.Click();
        }
        
        [Given(@"I click on the desired car model")]
        public void GivenIClickOnTheDesiredCarModel()
        {
            WaitHelpers.TurnOnWait();
            Model1.Click();
        }
        
        [When(@"I add comment and vote")]
        public void WhenIAddCommentAndVote()
        {
            AddCommentAndVote();
        }

        [Then(@"I should be able to see the vote has been added (.*)")]
        public void ThenIShouldBeAbleToSeeTheVoteHasBeenAdded(string name)
        {
            AssertVote();
            Drivers.SaveScreenshot(name);
            Drivers.CloseBrowser();
        }
    }
}
