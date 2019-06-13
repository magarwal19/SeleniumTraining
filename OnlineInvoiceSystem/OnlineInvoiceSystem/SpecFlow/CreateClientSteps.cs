using System;
using TechTalk.SpecFlow;
using OnlineInvoiceSystem.Pages;
using OnlineInvoiceSystem.Wrapper;
namespace OnlineInvoiceSystem.SpecFlow
{
    [Binding]
    public class CreateClientSteps
    {
        [Given(@"I have navigated to the URL")]
        public void GivenIHaveNavigatedToTheURL()
        {
            CommonFunctions.setDriver("chrome");
            CommonFunctions.opneUrl(@"http://10.11.32.14:8090/online-invoicing-system-2.6/app/index.php");
        }
        
        [Given(@"I have logged in to the system")]
        public void WhenIHaveLoggedInToTheSystem()
        {
            LoginPage login = new LoginPage();
            login.Login("admin","admin123");
            HomePage homePage = new HomePage();
            homePage.setUser("admin");
            homePage.ValidateHomePageVisible();
        }
        [When(@"I click on the new client button")]
        public void WhenIClickOnTheNewClientButton()
        {
            HomePage homepage = new HomePage();
            homepage.clickOnAddClient();
        }
        [Then(@"I should be able to enter the values")]
        public void ThenIShouldBeAbleToEnterTheValues()
        {
            ClientAddNewPage client = new ClientAddNewPage();
            client.validateAddClientWindow();
            client.strName = "mohit";
            client.strContact = "8237394531";
            client.strTitle = "Mr.";
            client.strAddress = "r3a 1404";
            client.strCity = "Pune";
            client.strCountry = "India";
            client.strPhone = "8237394531";
            client.strEmail ="mohit.agarwal@nitorinfotech.com";
            client.strWebsite = "https://www.abc.com";
            client.strComments = "test comments";
            client.enterValues();
        }


    }
}
