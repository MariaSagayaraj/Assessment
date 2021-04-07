using NUnit.Framework;
using OpenQA.Selenium;
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
        public IWebElement Category1 => Drivers.driver.FindElement(By.XPath(""));

        public IWebElement Model1 => Drivers.driver.FindElement(By.XPath("//img[@title='Lamborghini Murciélago']"));

        public IWebElement AddComment => Drivers.driver.FindElement(By.XPath("//*[contains(@id,'comment')]"));

        public IWebElement VoteButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Vote!')]"));

        public void Category()
        {
            Category1.Click();
        }

        public void Model()
        {
            Model1.Click();
        }

        public void AddCommentAndVote()
        {
            Thread.Sleep(1000);
            AddComment.SendKeys("marstest1");
            VoteButton.Click();
        }

        public void AssertVote()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("Thank you for your vote!"));
        }
    }
}
