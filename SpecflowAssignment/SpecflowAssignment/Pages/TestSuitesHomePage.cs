using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;
namespace SpecflowAssignment.Pages
{
    class TestSuitesHomePage
    {
        public static void OpenIDempiere()
        {
            CommonFunctions.setDriver("chrome");
            CommonFunctions.opneUrl("https://www.idempiere.org/test-sites");
            CommonFunctions.PerformClick(TestSitesHomePageLocator.idempierce);
            CommonFunctions.changeFocusToNewWindow();
            CommonFunctions.waitForEelementEnabled(LoginPageLocator.userName);
        }
    }
}
