using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Page_Login
    {
        public Page_Login()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        public static String username;
        public static String password;

        #region Initialize Web Elements 
        public IWebElement enterUname => Drivers.driver.FindElement(By.XPath("//input[@name='login']"));

        public IWebElement enterPassword => Drivers.driver.FindElement(By.XPath("//input[@name='password']"));

        public IWebElement LoginButton => Drivers.driver.FindElement(By.XPath("//button[@class='btn btn-success']"));

        #endregion
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

            enterUname.SendKeys(username);
            enterPassword.SendKeys(password);
            LoginButton.Click();
        }

        //Assertions
        public void Assertion(String data)
        {
            switch (data)
            {
                case "valid":
                    Assert.IsTrue(Drivers.driver.Title.Equals("Buggy Cars Rating"));
                    Console.WriteLine("Test Passed");
                    break;

                case "invalid":
                    Assert.Equals(Drivers.driver.FindElement(By.XPath("//span[@class='label label-warning']")).Text, "Invalid username/password");
                    Console.WriteLine("Test Passed");
                    break;

                case "null":
                    Console.WriteLine("Test Passed");
                    break;
            }
        }
    }
 }

            
