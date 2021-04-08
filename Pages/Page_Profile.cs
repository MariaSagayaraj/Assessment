using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
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

        public IWebElement ProfileButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Profile')]"));
        public IWebElement UpdateFirstName => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement UpdateLastName => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement Genderbox => Drivers.driver.FindElement(By.XPath("//input[@id='gender']"));
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
            Genderbox.Clear();
            Genderbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Gender"));
        }

        public void selectHobby()
        {
            new SelectElement(Hobbybox).SelectByText(Drivers.ExcelLib.ReadData(2, "Hobby"));
        }

        public void UpdateProfile()
        {
            //Click on Profile button
            Thread.Sleep(2000);
            ProfileButton.Click();
            Thread.Sleep(2000);

            //Update FirstName
            UpdateFirstName.Clear();
            UpdateFirstName.SendKeys(Drivers.ExcelLib.ReadData(2, "Update FirstName"));

            //Update Last Name
            UpdateLastName.Clear();
            UpdateLastName.SendKeys(Drivers.ExcelLib.ReadData(2, "Update LastName"));

            //Select gender from dropdown
            selectGender();

            //Enter age into the age field
            AgeBox.Clear();
            AgeBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Age"));

            //Enter Address detail into the address field
            AddressBox.Clear();
            AddressBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Address"));

            //Enter Phone number into the phone field
            PhoneBox.Clear();
            PhoneBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Phone"));

            //Select hobby from the dropdown
            selectHobby();
        }

        public void ChangePassword()
        {
            Thread.Sleep(1000);
            ProfileButton.Click();
            Thread.Sleep(1000);
            CurrentPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));
            NewPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));
            ConfirmPasswordbox.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));
        }

        public void AssertUpdate()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("The profile has been saved successful"));
           
        }
    }
}
