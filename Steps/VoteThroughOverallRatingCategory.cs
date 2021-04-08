using System;
using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
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
            Thread.Sleep(1000);
            Category("Category3");
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
        
        [Then(@"I should be able to see the successful vote message added")]
        public void ThenIShouldBeAbleToSeeTheSuccessfulVoteMessageAdded()
        {
            AssertVote();
        }
    }
}
