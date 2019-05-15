using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using Wrapper;
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
            driver.Url = "http://shop.demoqa.com/";
            var homePage = new HomePage();
            PageFactory.InitElements(driver,homePage);
            CommonFunctions.click(homePage.LogInTxt);
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver,loginPage);
            CommonFunctions.enterKeys(loginPage.UserName,"testuser");
            CommonFunctions.enterKeys(loginPage.UserPassword,"Test@123");
            // Now submit the form.
            CommonFunctions.click(loginPage.SubmitButton);
            driver.Quit();

        }
    }
}