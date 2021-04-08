using System;
using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteCheck : Vote
    {
        [Given(@"User login to application with (.*) inputs")]
        public void GivenUserLoginToApplicationWithInputs(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login("valid");
        }
        
        [Given(@"User click on the Popular Model category")]
        public void GivenUserClickOnThePopularModelCategory()
        {
            Thread.Sleep(1000);
            Category("Category2");
        }

        [Given(@"User click on the Popular Make category")]
        public void GivenUserClickOnThePopularMakeCategory()
        {
            Model();
        }
      
        [Then(@"The user should not see the vote button")]
        public void ThenTheUserShouldNotSeeTheVoteButton()
        {
            AssertVote();
        }
    }
}
