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
    public class Page_Registration
    {
        public Page_Registration()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        #region Initialize Web Elements 
        public IWebElement btnRegister => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));

        public IWebElement txtLogin => Drivers.driver.FindElement(By.XPath("//input[@id='username']"));

        public IWebElement txtFirstName => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));

        public IWebElement txtLastName => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));

        public IWebElement txtPassword => Drivers.driver.FindElement(By.XPath("//input[@id='password']"));

        public IWebElement txtConfirmPassword => Drivers.driver.FindElement(By.XPath("//input[@id='confirmPassword']"));

        public IWebElement buttonRegister => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Register')]"));
        #endregion

        public void Register()
        {
            txtLogin.SendKeys(Drivers.ExcelLib.ReadData(2, "Login"));

            txtFirstName.SendKeys(Drivers.ExcelLib.ReadData(2, "First Name"));

            txtLastName.SendKeys(Drivers.ExcelLib.ReadData(2, "Last Name"));

            txtPassword.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));

            txtConfirmPassword.SendKeys(Drivers.ExcelLib.ReadData(2, "Confirm Password"));

            

        }
    }
}
