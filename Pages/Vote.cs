using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Vote
    {
        #region Initialize Web Elements 
        // Popular Make button
        public IWebElement Category1 => Drivers.driver.FindElement(By.XPath("//img[@title='Lamborghini']"));

        // Popular Model button
        public IWebElement Category2 => Drivers.driver.FindElement(By.XPath("//img[@title='Diablo']"));

        // Overall rating button
        public IWebElement Category3 => Drivers.driver.FindElement(By.XPath("//img[@src='/img/overall.jpg']"));

        // AVENTADOR image inside Category1
        public IWebElement Model1 => Drivers.driver.FindElement(By.LinkText("AVENTADOR"));

        // Lancia image inside Category2
        public IWebElement OverallModel1 => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Lancia')]"));

        // Delta image inside OverallModel1
        public IWebElement OverallModel2 => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Delta')]"));

        // Add Comment Textbox
        public IWebElement AddComment => Drivers.driver.FindElement(By.XPath("//*[contains(@id,'comment')]"));

        //Vote button
        public IWebElement VoteButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Vote!')]"));

        #endregion

        // Overall rating method
        public void OverallModel()
        {
            // Wait untill the page is loaded
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//a[contains(text(),'»')]");

            // Actions method to move between pages
            Actions act = new Actions(Drivers.driver);
            act.MoveToElement(Drivers.driver.FindElement(By.XPath("//a[contains(text(),'»')]"))).Click().Build().Perform();
            WaitHelpers.TurnOnWait();

            // Click overall model 
            OverallModel1.Click();

            // Wait and Click on the car to vote

            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//a[contains(text(),'Delta')]");
            OverallModel2.Click();
        }

        // Add Comment and Click Vote
        public void AddCommentAndVote()
        {
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//*[contains(@id,'comment')]");

            // Check if  AddComment text box is present and then enter comment
            Assert.AreEqual(AddComment.Displayed, true);

            AddComment.SendKeys("marstest1");
            VoteButton.Click();
        }

        // Voting Assertion
        public void AssertVote()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("Thank you for your vote!"));
        }
    }
}
