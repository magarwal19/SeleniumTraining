using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using Scripts;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private static IWebDriver _driver;
        private string _applicationUrl = "http://shop.demoqa.com/";
        private string driverPath = @"C:\Users\mohit.agarwal\Documents\C#TrainingProject\SeleniumTraining\FirstSolution\Drivers\";
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

        [SetUp]
        public void Setup()
        {
            driverInitialize("chrome");
        }

        [Test]
        public void LaunchApplication()
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
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("custom-logo")));
            _driver.FindElement(By.XPath("//a[@class='noo-search']")).Click();
            _driver.FindElement(By.Name("s")).SendKeys("hello test");
            _driver.FindElement(By.Name("s")).SendKeys(Keys.Enter);
            //_driver.FindElement(By.XPath("//div[@class='remove-form']")).Click();
            _driver.FindElement(By.CssSelector("a[href*='http://shop.demoqa.com/']")).Click();
            var hrefList =_driver.FindElements(By.PartialLinkText("My"));
            foreach (var item in hrefList)
            {
                //item.Click();
                //System.Console.WriteLine(item.GetAttribute("text"));
                if(item.Text.Equals("My Account"))
                {
                    item.Click();
                }
            }
            IWebElement freeShipping= _driver.FindElement(By.XPath("//div[@class='noo-service-content']/h3"));
            Assert.AreEqual("FREE SHIPPING",freeShipping.Text);
            _driver.FindElement(By.TagName("a")).Click();
            IList<IWebElement> h3Tags= _driver.FindElements(By.XPath("//div[contains(@class,'noo-services style_left image')]//descendant::h3"));
            foreach (IWebElement h3TagValue in h3Tags)
            {
                if("FREE SHIPPING".Equals(h3TagValue.Text))
                {
                    System.Console.WriteLine("The value is Free Shipping");
                }
                else if ("Secure payment".Equals(h3TagValue.Text,StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("The value is Secure payment");
                }
                else if ("2 Years Warranty".Equals(h3TagValue.Text,StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("The value is 2 Years Warranty");
                }
                else if ("Money back 30 days".Equals(h3TagValue.Text,StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("The value is Money back 30 days");
                }
                else
                {
                    Assert.Fail("Value is not as expected " + h3TagValue.Text);
                }

            }
        }
        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
                _driver.Quit();
        }
    }
}