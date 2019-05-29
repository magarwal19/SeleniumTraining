using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;

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
            if(CommonFunctions.getText(BusinessPartnerLocators.searhKey)!="")
            {
                new FormatException("The values for search key is not empty");
            }
            if (CommonFunctions.getText(BusinessPartnerLocators.name) != "")
            {
                new FormatException("The values for name is not empty");
            }
            if (CommonFunctions.getText(BusinessPartnerLocators.name2) != "")
            {
                new FormatException("The values for name2 is not empty");
            }
            if (CommonFunctions.getText(BusinessPartnerLocators.Description) != "")
            {
                new FormatException("The values for Description is not empty");
            }
        }
    }
}
