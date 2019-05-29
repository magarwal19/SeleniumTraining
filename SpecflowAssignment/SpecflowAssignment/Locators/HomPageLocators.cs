using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SpecflowAssignment.Locators
{
    class HomPageLocators
    {
        public static By home = By.XPath("//span[text()='Home']");
        public static By favorites = By.XPath("//div[text()='Favourites']");
        public static By businessPartnerFromFav = By.XPath("//a[text()='Business Partner']");
        
    }
}
