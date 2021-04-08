using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    public class Page_Profile
    {
        public Page_Profile()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        #region Initialize Web Elements 

        public IWebElement ProfileButton => Drivers.driver.FindElement(By.XPath("//*[contains(@class,'nav-link')][@xpath='2']"));

        public IWebElement UpdateFirstName => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));

        public IWebElement UpdateLastName => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));

        public IWebElement Genderbox => Drivers.driver.FindElement(By.XPath(""));

        public IWebElement AgeBox => Drivers.driver.FindElement(By.XPath("//input[@id='age']"));

        public IWebElement AddressBox => Drivers.driver.FindElement(By.XPath("//textarea[@id='address']"));

        public IWebElement PhoneBox => Drivers.driver.FindElement(By.XPath("//input[@id='phone']"));

        public IWebElement Hobbybox => Drivers.driver.FindElement(By.XPath("//select[@id='hobby']"));

        public IWebElement CurrentPasswordbox => Drivers.driver.FindElement(By.XPath("//input[@id='currentPassword']"));

        public IWebElement NewPasswordbox => Drivers.driver.FindElement(By.XPath("//input[@id='newPassword']"));

        public IWebElement ConfirmPasswordbox => Drivers.driver.FindElement(By.XPath("//input[@id='newPasswordConfirmation']"));

        public IWebElement SaveButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Save')]"));

        #endregion

        public void selectGender()
        {
            
            SelectElement element = new SelectElement(Genderbox);
            element.SelectByText("Female");
         }

        public void selectHobby()
        {
            SelectElement element = new SelectElement(Hobbybox);
            element.SelectByText("Reading");
        }
       
        #endregion

        public void UpdateProfile()
        {
            Thread.Sleep(1000);
            ProfileButton.Click();
            Thread.Sleep(1000);
            UpdateFirstName.SendKeys(Drivers.ExcelLib.ReadData(2, "Update FirstName"));
            UpdateLastName.SendKeys(Drivers.ExcelLib.ReadData(2, "Update LastName"));
            selectGender();
            AgeBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Age"));
            AddressBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Address"));
            PhoneBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Phone"));
        }

        public void ChangePassword()
        {
            //Thread.Sleep(1000);
            ProfileButton.Click();
            Thread.Sleep(1000);
            CurrentPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));
            NewPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));
            ConfirmPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));
        }

        public void AssertUpdate()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("The Profile has been saved successful"));
           
        }
    }
}
