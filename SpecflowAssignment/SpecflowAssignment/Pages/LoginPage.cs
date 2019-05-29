using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;

namespace SpecflowAssignment.Pages
{
    class LoginPage
    {
        public static void login(string userName,string password)
        {
            CommonFunctions.EnterKeys(LoginPageLocator.userName,userName);
            CommonFunctions.EnterKeys(LoginPageLocator.password, password);
            CommonFunctions.PerformClick(LoginPageLocator.submit);
            CommonFunctions.waitForEelementExists(HomPageLocators.home);
        }
    }
}
