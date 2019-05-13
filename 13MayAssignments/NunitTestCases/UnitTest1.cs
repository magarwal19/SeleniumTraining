using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
namespace Tests
{
    public class Tests
    {
        private static IWebDriver _driver;
        private string driverPath = @".\..\..\..\..\Drivers\";
        private void driverInitialize(string browser)
        {
            if (browser.Equals("chrome"))
            {
                ChromeOptions chromeoption = new ChromeOptions()
                {

                };
                _driver = new ChromeDriver(driverPath);
            }
            if (browser.Equals("ie"))
            {
                InternetExplorerOptions ieOptions = new InternetExplorerOptions()
                {
                    EnsureCleanSession = false,
                    IgnoreZoomLevel = true,
                    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                    EnableNativeEvents = true

                };
                _driver = new InternetExplorerDriver(driverPath, ieOptions);
            }
            if (browser.Equals("edge"))
            {
                EdgeOptions edgeoptions = new EdgeOptions();
                _driver = new EdgeDriver(driverPath);
            }
            if (browser.Equals("firefox"))
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(driverPath);
                //service.AcceptInsecureCertificates=true;
                _driver = new FirefoxDriver(service);
            }
        }
        public void LaunchApplication(string _applicationUrl)
        {
            //Open the specified URL in browser
            _driver.Navigate().GoToUrl(_applicationUrl);
            //delete the cookies stored
            _driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window if not maximized already
            _driver.Manage().Window.Maximize();
            string actualUrl = _driver.Url;
            if (actualUrl.Equals(_applicationUrl))
            {
                System.Console.WriteLine("The actual url is matched with expected url");
                //   Assert.Pass("The url is opened properly");
            }
            else
            {
                Assert.Fail("Verification Failed - An incorrect Url is opened. Actual URL is : " + actualUrl
                 + " while the Expected URL is " + _applicationUrl);
            }
            // Assert.AreEqual(actualUrl, _applicationUrl);
            //  WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 1, 0));
            // wait.Until(ExpectedConditions.ElementExists(By.ClassName("custom-logo")));
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void test1()
        {
            driverInitialize("firefox");
            LaunchApplication("http://shop.demoqa.com/");
            System.Console.WriteLine("Page titile is " + _driver.Title);
            StringAssert.AreEqualIgnoringCase("ToolsQA Demo Site – ToolsQA – Demo E-Commerce Site",_driver.Title);
            System.Console.WriteLine("Title length is " + _driver.Title.Length);
            System.Console.WriteLine("Page URL is " + _driver.Url);
            StringAssert.AreEqualIgnoringCase("http://shop.demoqa.com/",_driver.Url);
            System.Console.WriteLine("Url length is " + _driver.Url.Length);
            System.Console.WriteLine("Source Code length is " + _driver.PageSource.Length);
            _driver.Quit();
        }

        [Test]
        public void test2()
        {
            driverInitialize("firefox");
            LaunchApplication("https://demoqa.com/");
            _driver.FindElement(By.XPath("//a[text()='Widgets']")).Click();
            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().GoToUrl("https://demoqa.com/");
            _driver.Navigate().Refresh();
            _driver.Close();
        }

        [Test]
        public void test3()
        {
             driverInitialize("firefox");
            LaunchApplication("https://www.toolsqa.com/automation-practice-form/");
            _driver.FindElement(By.XPath("//input[contains(@id,'sex') and @value='Male']")).Click();
            IList<IWebElement> sexRadioButtons= _driver.FindElements(By.XPath("//input[contains(@id,'sex')]"));
            foreach (IWebElement rdButton in sexRadioButtons)
            {
                if(rdButton.Enabled && rdButton.Selected)
                {
                    StringAssert.AreEqualIgnoringCase(rdButton.GetAttribute("value").ToString(),"Male");
                }
                else if(rdButton.Enabled && !rdButton.Selected)
                {
                    StringAssert.AreEqualIgnoringCase(rdButton.GetAttribute("value").ToString(),"Female");
                }
            }
            _driver.FindElement(By.XPath("//input[contains(@id,'profession') and @value='Manual Tester']")).Click();
            IList<IWebElement> professionChkBoxs= _driver.FindElements(By.XPath("//input[contains(@id,'profession')]"));
            foreach (IWebElement chkBox in professionChkBoxs)
            {
                if(chkBox.Enabled && chkBox.Selected)
                {
                    StringAssert.AreEqualIgnoringCase(chkBox.GetAttribute("value").ToString(),"Manual Tester");
                }
                else if(chkBox.Enabled && !chkBox.Selected)
                {
                    StringAssert.AreEqualIgnoringCase(chkBox.GetAttribute("value").ToString(),"Automation Tester");
                }
            }
            _driver.FindElement(By.XPath("//input[contains(@id,'profession') and @value='Automation Tester']")).Click();
            professionChkBoxs= _driver.FindElements(By.XPath("//input[contains(@id,'profession')]"));
            foreach (IWebElement chkBox in professionChkBoxs)
            {
                if(chkBox.Enabled && chkBox.Selected)
                {
                    StringAssert.Contains("Tester",chkBox.GetAttribute("value").ToString());
                }
            }
            _driver.Close();
        }
    }
}