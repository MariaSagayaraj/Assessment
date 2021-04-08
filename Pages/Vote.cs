using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Vote
    {
        #region Initialize Web Elements 
        public IWebElement Category1 => Drivers.driver.FindElement(By.XPath("//img[@title='Lamborghini']"));

        public IWebElement Category2 => Drivers.driver.FindElement(By.XPath("//img[@title='Diablo']"));

        public IWebElement Category3 => Drivers.driver.FindElement(By.XPath("//img[@src='/img/overall.jpg']"));

        public IWebElement Model1 => Drivers.driver.FindElement(By.LinkText("AVENTADOR"));

        public IWebElement OverallModel1 => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Lancia')]"));

        public IWebElement OverallModel2 => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Delta')]"));

        public IWebElement AddComment => Drivers.driver.FindElement(By.XPath("//*[contains(@id,'comment')]"));

        public IWebElement VoteButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Vote!')]"));

        #endregion
       /* public void Category(String category)
        {
            if (category == "Category1")
            {
                Category1.Click();
            }
            if (category == "Category2")
            {
                Category2.Click();
            }
            if(category == "Category3")
            {
                Category3.Click();
            }
            else
            {
                Console.WriteLine("Incorrect category supplied");
            }
        }*/


        // Overall rating method
        public void OverallModel()
        {
            Thread.Sleep(1000);

            // Actions method to move between pages
            Actions act = new Actions(Drivers.driver);
            act.MoveToElement(Drivers.driver.FindElement(By.XPath("//a[contains(text(),'»')]"))).Click().Build().Perform();
            Thread.Sleep(1000);

            OverallModel1.Click();
            Thread.Sleep(1000);
            OverallModel2.Click();
        }

        // Add Comment and Click Vote
        public void AddCommentAndVote()
        {
            Thread.Sleep(1000);
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
