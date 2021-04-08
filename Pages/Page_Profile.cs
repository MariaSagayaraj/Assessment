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
        // Excel Initialization
        public Page_Profile()
        {
            Drivers.ExcelLib.PopulateInCollection(BaseClass.ExcelPath, "Registration");
        }

        #region Initialize Web Elements 

        public IWebElement ProfileButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Profile')]"));
        public IWebElement FirstNameTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement LastNameTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement GenderTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='gender']"));
        public IWebElement AgeTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='age']"));
        public IWebElement AddressTextBox => Drivers.driver.FindElement(By.XPath("//textarea[@id='address']"));
        public IWebElement PhonetextBox => Drivers.driver.FindElement(By.XPath("//input[@id='phone']"));
        public IWebElement HobbyTextbox => Drivers.driver.FindElement(By.XPath("//select[@id='hobby']"));
        public IWebElement CurrentPassword => Drivers.driver.FindElement(By.XPath("//input[@id='currentPassword']"));
        public IWebElement NewPassword => Drivers.driver.FindElement(By.XPath("//input[@id='newPassword']"));
        public IWebElement ConfirmPassword => Drivers.driver.FindElement(By.XPath("//input[@id='newPasswordConfirmation']"));
        public IWebElement SaveButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Save')]"));

        #endregion

        // Select Gender
        public void selectGender()
        {
            GenderTextbox.Clear();
            GenderTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Gender"));
        }

        // Select Hobby 
        public void selectHobby()
        {
            new SelectElement(HobbyTextbox).SelectByText(Drivers.ExcelLib.ReadData(2, "Hobby"));
        }

        // Update profile method
        public void UpdateProfile()
        {
            //Click on Profile button
            Thread.Sleep(2000);
            ProfileButton.Click();
            Thread.Sleep(2000);

            //Update FirstName
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys(Drivers.ExcelLib.ReadData(2, "Update FirstName"));

            //Update Last Name
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Update LastName"));

            //Select gender from dropdown
            selectGender();

            //Enter age into the age field
            AgeTextBox.Clear();
            AgeTextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Age"));

            //Enter Address detail into the address field
            AddressTextBox.Clear();
            AddressTextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Address"));

            //Enter Phone number into the phone field
            PhonetextBox.Clear();
            PhonetextBox.SendKeys(Drivers.ExcelLib.ReadData(2, "Phone"));

            //Select hobby from the dropdown
            selectHobby();
        }

        // Update Password
        public void ChangePassword()
        {
            Thread.Sleep(1000);
            ProfileButton.Click();
            Thread.Sleep(1000);

            // Entering current password
            CurrentPassword.SendKeys(Drivers.ExcelLib.ReadData(2, "Password"));

            // Entering New password
            NewPassword.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));

            // Entering Confirm password
            ConfirmPassword.SendKeys(Drivers.ExcelLib.ReadData(2, "New Password"));
        }

        // Update Assertion
        public void AssertUpdate()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("The profile has been saved successful"));           
        }
    }
}
