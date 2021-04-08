using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Page_Login
    {
        public static String username;
        public static String password;

        // Excel Initialization
        public Page_Login()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        #region Initialize Web Elements 
        public IWebElement enterUname => Drivers.driver.FindElement(By.XPath("//input[@name='login']"));

        public IWebElement enterPassword => Drivers.driver.FindElement(By.XPath("//input[@name='password']"));

        public IWebElement LoginButton => Drivers.driver.FindElement(By.XPath("//button[@class='btn btn-success']"));

        public IWebElement LogoutButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

        #endregion

        // Login method
        public void Login(String data)
        {
            switch (data)
            {
                case "valid":
                    username = Drivers.ExcelLib.ReadData(2, "Login");
                    password = Drivers.ExcelLib.ReadData(2, "Password");
                    break;
                case "invalid":
                    username = Drivers.ExcelLib.ReadData(2, "Invalid Username");
                    password = Drivers.ExcelLib.ReadData(2, "Invalid Password");
                    break;
                case "null":
                    username = Drivers.ExcelLib.ReadData(2, "Null Username");
                    password = Drivers.ExcelLib.ReadData(2, "Null Password");
                    break;
            }

            // Enter user name
            enterUname.SendKeys(username);

            // Enter password
            enterPassword.SendKeys(password);

            // Click login button
            LoginButton.Click();
        }

        // Login Assertion
        public void Assertion(String data)
        {
            switch (data)
            {
                case "valid":
                    Assert.IsTrue(Drivers.driver.Title.Equals("Buggy Cars Rating"));
                    Console.WriteLine("Test Passed");
                    break;

                case "invalid":
                    WaitHelpers.TurnOnWait();
                    Assert.AreEqual(Drivers.driver.FindElement(By.XPath("//span[contains(text(),'Invalid username/password')]")).Displayed, true);
                    Console.WriteLine("Test Passed");
                    break;

                case "null":
                    Console.WriteLine("Test Passed");
                    break;
            }
        }

        // Logout Assertion
        public void LogOutAssertion()
        {
            // Wait untill the login button
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//button[@class='btn btn-success']");

            Assert.AreEqual(LoginButton.Displayed, true);
        }
    }
}

            
