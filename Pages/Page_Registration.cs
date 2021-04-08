using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Page_Registration
    {
        // Excel Initialization
        public Page_Registration()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        #region Initialize Web Elements 
        public IWebElement RegButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
        public IWebElement LoginTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement FTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement LTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement PwdTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement ConfirmPwdTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='confirmPassword']"));
        public IWebElement RegisterButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Register')]"));
        #endregion

        // Registration method
        public void Register()
        {
            // Enter login details
            LoginTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Login"));

            // Enter First Name
            FTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "First Name"));

            // Enter Last Name
            LTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Last Name"));

            // Enter Password
            PwdTextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));

            // Enter Confirm Password
            ConfirmPwdTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Confirm Password"));

        }

        // Regsitration Assertion method
        public void RegAssertion()
        {
            // Wait untill the successful message 
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//div[contains(text(),'Registration is successful')]");

            Assert.AreEqual(Drivers.driver.FindElement(By.XPath("//div[contains(text(),'Registration is successful')]")).Displayed, true);
        }
    }
}
