using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowAssignment.Locators
{
    class LoginPageLocator
    {
        public static By userName = By.XPath("//tr[@id='rowUser']//input");
        public static By password = By.XPath("//tr[@id='rowPassword']//input");
        public static By submit = By.XPath("//button[@class='login-btn z-button']");
    }
}
