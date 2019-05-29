using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;
using OpenQA.Selenium.Support.UI;

namespace SpecflowAssignment.Pages
{
    class BusinessPartnerForm
    {
        public static void enterValues(string organization, string name, string name2, string searchKey)
        {
            string classval = CommonFunctions.FindElementBy(BusinessPartnerFormLocators.name).GetAttribute("class").ToString();
            while(classval.Contains("readonly"))
            {
                classval = CommonFunctions.FindElementBy(BusinessPartnerFormLocators.name).GetAttribute("class").ToString();
            }
            
            CommonFunctions.PerformClick(BusinessPartnerFormLocators.name);
            if (name!= "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.name, name);
            }
            if (searchKey!="")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.searchKey,searchKey);
            }
            if (name2!="")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.name2,name2);
            }
            if (organization != "")
            {
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.organizationDropDown);
                BusinessPartnerFormLocators.createDropDownXpath(organization);
                CommonFunctions.waitForEelementEnabled(BusinessPartnerFormLocators.organizationOption);
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.organizationOption);
            }
        }
    }
}
