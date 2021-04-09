using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughPopularModelSteps : Vote
    {
        [Given(@"I login to the application with (.*) input")]
        public void GivenILoginToTheApplicationWithInput(string valid)
        {
            BaseClass init = new BaseClass();
            init.Initialize();
            Page_Login login = new Page_Login();
            login.Login("valid");
        }

        [Given(@"I click on the Popular Model category")]
        public void GivenIClickOnThePopularModelCategory()
        {
            Thread.Sleep(1000);
            Category2.Click();
        }
        
        [When(@"I add a comment and vote")]
        public void WhenIAddACommentAndVote()
        {
            AddCommentAndVote();
        }

        [Then(@"I should able to see the successful vote message (.*)")]
        public void ThenIShouldAbleToSeeTheSuccessfulVoteMessage(string name)
        {
            AssertVote();
            Drivers.SaveScreenshot(name);
            Drivers.CloseBrowser();
        }
    }
}
