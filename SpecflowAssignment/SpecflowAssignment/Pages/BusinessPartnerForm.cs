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
        public static void enterValues(BusinessPartnerInfo partnerInfo)
        {
            string classval = CommonFunctions.FindElementBy(BusinessPartnerFormLocators.name).GetAttribute("class").ToString();
            while(classval.Contains("readonly"))
            {
                classval = CommonFunctions.FindElementBy(BusinessPartnerFormLocators.name).GetAttribute("class").ToString();
            }
            
            CommonFunctions.PerformClick(BusinessPartnerFormLocators.name);
            if (partnerInfo.name != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.name, partnerInfo.name);
            }
            if (partnerInfo.searchKey != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.searchKey, partnerInfo.searchKey);
            }
            if (partnerInfo.name2 != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.name2, partnerInfo.name2);
            }
            if (partnerInfo.organization != "")
            {
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.organizationDropDown);
                BusinessPartnerFormLocators.createDropDownXpath(partnerInfo.organization);
                CommonFunctions.waitForEelementEnabled(BusinessPartnerFormLocators.dropDownOption);
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.dropDownOption);
            }
            if (partnerInfo.referenceNumber != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.referenceNumber, partnerInfo.referenceNumber);
            }
            if (partnerInfo.rating != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.rating, partnerInfo.rating);
            }
            if(partnerInfo.vendor==true)
            {
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.vendor);
            }
            if(partnerInfo.description!="")
            {
                CommonFunctions.EnterKeys(BusinessPartnerFormLocators.description, partnerInfo.description);
            }
            if (partnerInfo.creditStatus != "")
            {
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.creditStatusDropDown);
                BusinessPartnerFormLocators.createDropDownXpath(partnerInfo.creditStatus);
                CommonFunctions.waitForEelementEnabled(BusinessPartnerFormLocators.dropDownOption);
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.dropDownOption);
            }
            if (partnerInfo.businessPartnerGroup != "")
            {
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.businessGroupDropDown);
                BusinessPartnerFormLocators.createDropDownXpath(partnerInfo.businessPartnerGroup);
                CommonFunctions.waitForEelementEnabled(BusinessPartnerFormLocators.dropDownOption);
                CommonFunctions.PerformClick(BusinessPartnerFormLocators.dropDownOption);
            }
        }
    }
}
