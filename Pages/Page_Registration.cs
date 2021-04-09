using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Page_Registration
    {
        // Excel Initialization
        public Page_Registration()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "TestData");
        }

        #region Initialize Web Elements 
        // Registration Button
        public IWebElement RegButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));

        //Login Textbox
        public IWebElement LoginTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='username']"));

        // First Name Textbox
        public IWebElement FTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));

        //Last Name Textbox
        public IWebElement LTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));

        //Password Textbox
        public IWebElement PwdTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='password']"));

        //Confirm Password Textbox
        public IWebElement ConfirmPwdTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='confirmPassword']"));

        //Register Button
        public IWebElement RegisterButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Register')]"));
        #endregion

        // Registration method - Check if the element is present and then perform function
        public void Register()
        {
            // Enter login details
            Assert.AreEqual(LoginTextbox.Displayed, true);
            LoginTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Login"));

            // Enter First Name
            Assert.AreEqual(FTextbox.Displayed, true);
            FTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "First Name"));

            // Enter Last Name
            Assert.AreEqual(LTextbox.Displayed, true);
            LTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Last Name"));

            // Enter Password
            Assert.AreEqual(PwdTextBox.Displayed, true);
            PwdTextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));

            // Enter Confirm Password
            Assert.AreEqual(ConfirmPwdTextbox.Displayed, true);
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
