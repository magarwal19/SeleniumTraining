using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SpecflowAssignment.Wrapper
{
    class CommonFunctions
    {
        static IWebDriver driver;
        public static void setDriver(string browser)
        {
            string driverPath = @"C:\Users\mohit.agarwal\Documents\C#TrainingProject\SeleniumTraining\SpecflowAssignment\SpecflowAssignment\Drivers";
            if (browser.Equals("chrome"))
            {
                ChromeOptions chromeoption = new ChromeOptions()
                {

                };
                driver = new ChromeDriver(driverPath);
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
                driver = new InternetExplorerDriver(driverPath, ieOptions);
            }
            if (browser.Equals("edge"))
            {
                EdgeOptions edgeoptions = new EdgeOptions();
                driver = new EdgeDriver(driverPath);
            }
            if (browser.Equals("firefox"))
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(driverPath);
                //service.AcceptInsecureCertificates=true;
                driver = new FirefoxDriver(service);
            }
        }
        public static void changeFocusToNewWindow()
        {
            string parentWindowHandle = driver.CurrentWindowHandle;
            string newWindowHandle="";
            List<string> windowList = driver.WindowHandles.ToList();
            foreach (var handle in windowList)
            {
                if (handle.Equals(parentWindowHandle))
                {
                    driver.Close();
                }
                else
                    newWindowHandle = handle;
            }
            driver.SwitchTo().Window(newWindowHandle);
        }
        public static void opneUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            //delete the cookies stored
            driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window if not maximized already
            driver.Manage().Window.Maximize();
        }
        public static void closeApplication()
        {
            driver.Quit();
        }
        public static void PerformClick(By by)
        {
            IWebElement webElement = driver.FindElement(by);
            if (webElement.Displayed)
            {
                if (webElement.Enabled)
                {
                    webElement.Click();
                }
                else
                {
                    throw new ElementNotSelectableException("Element is not enabled");
                }
            }
            else
                throw new ElementNotVisibleException("Element is not visible");

        }
        public static void EnterKeys(By by, string message)
        {
            IWebElement webElement = driver.FindElement(by);
            if (webElement.Displayed)
            {
                webElement.Click();
                if (webElement.Enabled)
                {
                    webElement.Clear();
                    webElement.SendKeys(message);
                }
                else
                {
                    throw new ElementNotSelectableException("Element is not enabled");
                }
            }
            else
                throw new ElementNotVisibleException("Element is not visible");
        }
        public static IWebElement FindElementBy(By by)
        {
            return driver.FindElement(by);
        }
        public static void waitForEelementExists(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }
        public static void waitForEelementNotExists(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(by));
        }
        public static void waitForEelementEnabled(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
        public static void validateObjectVisible(By by,string objectName)
        {
            if(driver.FindElement(by).Displayed)
            {
                Console.WriteLine("The object " + objectName + " is visible");
            }
            else
            {
                Assert.Fail("The object " + objectName + " is not visible");
            }
        }
        public static void validateObjectInVisible(By by, string objectName)
        {
            try
            {
                if (driver.FindElement(by).Displayed)
                    Assert.Fail("The object " + objectName + " is visible");
            }
            catch(NoSuchElementException)
            {
                Console.WriteLine("The object " + objectName + " is not visible");
            }
        }

        public static string getTextByValue(By by)
        {
            return driver.FindElement(by).GetAttribute("value");
        }

        public static void selectDropDownByText(By by, string value)
        {
            SelectElement oSelect = new SelectElement(CommonFunctions.FindElementBy(by));
            oSelect.SelectByText(value);
          
        }
    }
}
