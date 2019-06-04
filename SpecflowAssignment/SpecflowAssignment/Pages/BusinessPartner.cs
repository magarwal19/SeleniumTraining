using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;
using NUnit.Framework;

namespace SpecflowAssignment.Pages
{
    class BusinessPartner
    {
        public static void enterValues(string searchKey,string name, string name2, string description)
        {
            CommonFunctions.waitForEelementEnabled(BusinessPartnerLocators.searhKey);
            if(searchKey!="")
            {
                CommonFunctions.EnterKeys(BusinessPartnerLocators.searhKey, searchKey);
            }
            if (name != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerLocators.name, name);
            }
            if (name2 != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerLocators.name2, name2);
            }
            if (description != "")
            {
                CommonFunctions.EnterKeys(BusinessPartnerLocators.Description, description);
            }
        }
        public static void validateEmptyFields()
        {
            string val;
            val = CommonFunctions.getTextByValue(BusinessPartnerLocators.searhKey);
            if (val != "")
            {
                Assert.Fail("The values for search key is not empty and is " + val);
            }
            val = CommonFunctions.getTextByValue(BusinessPartnerLocators.name);
            if (CommonFunctions.getTextByValue(BusinessPartnerLocators.name) != "")
            {
                Assert.Fail("The values for name is not empty and is " + val);
            }
            val = CommonFunctions.getTextByValue(BusinessPartnerLocators.name2);
            if (CommonFunctions.getTextByValue(BusinessPartnerLocators.name2) != "")
            {
                Assert.Fail("The values for name2 is not empty and is " + val);
            }
            val = CommonFunctions.getTextByValue(BusinessPartnerLocators.Description);
            if (CommonFunctions.getTextByValue(BusinessPartnerLocators.Description) != "")
            {
                Assert.Fail("The values for Description is not empty and is " + val);
            }
        }
    }
}
