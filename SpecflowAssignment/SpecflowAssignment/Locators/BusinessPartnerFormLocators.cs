using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SpecflowAssignment.Locators
{
    class BusinessPartnerFormLocators
    {
        public static By client = By.XPath("//span[text()='Client']/../../..//td[2]//input[contains(@class,'z-combobox-')]");
        public static By name = By.XPath("//span[text()='Name']/../../..//td[2]/input[contains(@class,'z-textbox')]");
        public static By name2 = By.XPath("//span[text()='Name 2']/../../..//td//input[contains(@class,'z-textbox')]");
        public static By organizationDropDown = By.XPath("//span[text()='Organization']/../../..//td[4]//i[contains(@class,'z-combobox-icon z-icon-caret-down')]");        
        public static By searchKey = By.XPath("//span[text()='Search Key']/../../..//td[2]//input[contains(@class,'z-textbox')]");
        public static By organizationOption;
        public static void createDropDownXpath(string value)
        {
             organizationOption = By.XPath("//div[contains(@class,'z-combobox-popup')]/ul/li/span[text()='"+ value + "']");
    }
    }
}
