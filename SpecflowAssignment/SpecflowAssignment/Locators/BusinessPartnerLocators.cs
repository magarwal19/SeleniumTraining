using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SpecflowAssignment.Locators
{
    class BusinessPartnerLocators
    {
        public static By businessPartnerWindow = By.XPath("//span[contains(text(),' Business Partner')]");
        public static By closeBusinessPartner = By.XPath("//i[@class='z-icon-times z-tab-icon']");
        public static By searhKey = By.XPath("//div[contains(@class,'find-window-simple')]//span[text()='Search Key']/../../..//td//input[@class='z-textbox']");
        public static By name = By.XPath("//div[contains(@class,'find-window-simple')]//span[text()='Name']/../../..//td//input[@class='z-textbox']");
        public static By name2 = By.XPath("//div[contains(@class,'find-window-simple')]//span[text()='Name 2']/../../..//td//input[@class='z-textbox']");
        public static By Description = By.XPath("//div[contains(@class,'find-window-simple')]//span[text()='Description']/../../..//td//input[@class='z-textbox']");
        public static By btnReset = By.XPath("//button[@class='img-btn btn-reset z-button']");
        public static By btnOk = By.XPath("//button[@class='img-btn btn-ok z-button']");
        public static By newBusinessPartner = By.XPath("//a[contains(@title,'New    Alt+N')]");
    }
}
