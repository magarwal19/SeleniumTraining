using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using Scripts;
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
            driverInitialize("edge");
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
                Assert.Pass("The url is opened properly");
            }
            else
            {
                Assert.Fail("Verification Failed - An incorrect Url is opened. Actual URL is : " + actualUrl
                 + " while the Expected URL is " + _applicationUrl);
            }
            Assert.AreEqual(actualUrl, _applicationUrl);
        }
        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
                _driver.Quit();
        }
    }
}