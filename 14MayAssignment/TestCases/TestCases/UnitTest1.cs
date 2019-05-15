using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using Tests;

namespace Tests
{
    class LogInTest
    {
        static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void Test()
        {
            driver = new FirefoxDriver(@".\..\..\..\..\Drivers\");
            driver.Url = "http://www.store.demoqa.com";
            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            homePage.LogInTxt.Click();
            loginPage.UserName.SendKeys("testuser");
            loginPage.UserPassword.SendKeys("Test@123");
            // Now submit the form.
            loginPage.SubmitButton.Click();
            driver.Quit();

        }
    }
}