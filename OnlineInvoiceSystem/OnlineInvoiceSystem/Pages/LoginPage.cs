using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OnlineInvoiceSystem.Wrapper;
namespace OnlineInvoiceSystem.Pages
{
    class LoginPage
    {
        By topIcon = By.XPath("//a[text()=' online inovicing system']");
        By signInText = By.XPath("//strong[text()='Sign In Here']");
        By userName = By.Id("username");
        By password = By.Id("password");
        By signIn = By.Id("submit");
        
        public void Login(string userName, string password)
        {
            CommonFunctions.waitForEelementExists(signInText);
            CommonFunctions.EnterKeys(this.userName, userName);
            CommonFunctions.EnterKeys(this.password, password);
            CommonFunctions.PerformClick(signIn);
        }
        
    }
}
