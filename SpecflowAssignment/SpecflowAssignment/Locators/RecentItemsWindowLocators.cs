using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowAssignment.Locators
{
    class RecentItemsWindowLocators
    {
        public static By recentBusinessPartner;
       
        public static void createBusinessPartnerXpath(string searchKey, string name)
        {
            recentBusinessPartner = By.XPath("//div[contains(@class,'desktop-left-column z-west')]//a[text()='Business Partner: " + searchKey + " " + name + "']");
        }
    }
}
