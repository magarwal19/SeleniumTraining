using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
namespace Tests
{
    class HomePage
    {
        public IWebDriver driver;
        [FindsBy(How=How.ClassName, Using="custom-logo")]
        public IWebElement MainLogo{ get; set; }
        [FindsBy(How=How.XPath,Using="//a[text()='Log in']")]
        public IWebElement LogInTxt{ get; set; }
    }
}