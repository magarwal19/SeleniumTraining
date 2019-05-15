using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
namespace Tests
{
    class LoginPage
    {
        public IWebDriver driver;
        [FindsBy(How=How.XPath, Using="//input[@id='user_login']")]
        public IWebElement UserName{ get; set; }
        [FindsBy(How=How.Id,Using="user_pass")]
        public IWebElement UserPassword{ get; set; }
        [FindsBy(How=How.Id, Using="wp-submit")]
        public IWebElement SubmitButton{ get; set; }
    }
}