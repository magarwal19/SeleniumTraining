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
        public static By description = By.XPath("//span[text()='Description']/../../..//td[2]//textarea[contains(@class,'z-textbox')]");
        public static By referenceNumber = By.XPath("//span[text()='Reference No']/../../..//td[2]//input[contains(@class,'z-textbox')]");
        public static By rating = By.XPath("//span[text()='Rating']/../../..//td[4]//input[contains(@class,'z-textbox')]");
        public static By searchKey = By.XPath("//span[text()='Search Key']/../../..//td[2]//input[contains(@class,'z-textbox')]");
        public static By dropDownOption;
        public static By organizationDropDown = By.XPath("//span[text()='Organization']/../../..//td[4]//i[contains(@class,'z-combobox-icon z-icon-caret-down')]");
        public static By creditStatusDropDown = By.XPath("//span[text()='Credit Status']/../../..//td[2]//i[contains(@class,'z-combobox-icon z-icon-caret-down')]");
        public static By businessGroupDropDown = By.XPath("//span[text()='Business Partner Group']/../../..//td[4]//i[contains(@class,'z-combobox-icon z-icon-caret-down')]");
        public static void createDropDownXpath(string value)
        {
            dropDownOption = By.XPath("//div[contains(@class,'z-combobox-popup')]/ul/li/span[contains(text(),'"+ value + "')]");
        }
        public static By vendor = By.XPath("//label[text()='Vendor']/../../span[contains(@class,'z-checkbox z-checkbox-default')]");
        public static By save = By.XPath("//a[contains(@title,'Save changes')]");
        public static By savedMessage = By.XPath("//span[text()='Record saved']");
        public static By errorMessage = By.XPath("//span[contains(text(),'Could not save record - Require unique data:  ')]");
    }
}
