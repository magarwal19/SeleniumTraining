using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OnlineInvoiceSystem.Wrapper;
namespace OnlineInvoiceSystem.Pages
{
    class HomePage
    {
        By signedInAs=null;
        By newClient = By.Id("clients_add_new");
        public void setUser(string user)
        {
            signedInAs = By.XPath("//ul[contains(@class,'nav navbar-nav navbar-right hidden-xs')]//p[contains(text(),'Signed in as')]//a[text()='" + user + "']");
        }
        

        public void ValidateHomePageVisible()
        {
            //CommonFunctions.markAsFailed(signedInAs.ToString());
            CommonFunctions.waitForEelementExists(signedInAs);
            //CommonFunctions.PerformClick(signedInAs);
            CommonFunctions.validateObjectVisible(signedInAs,"signed in as message");
        }
        public void clickOnAddClient()
        {
            CommonFunctions.PerformClick(newClient);
        }
    }
}
