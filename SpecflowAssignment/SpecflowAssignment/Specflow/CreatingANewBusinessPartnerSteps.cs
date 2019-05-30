using System;
using TechTalk.SpecFlow;
using SpecflowAssignment.Pages;
using SpecflowAssignment.Wrapper;
using SpecflowAssignment.Locators;
namespace SpecflowAssignment.Specflow
{
    [Binding]
    public class CreatingANewBusinessPartnerSteps
    {
        [Given(@"I have navigated to the idempiere login page")]
        public void GivenIHaveNavigatedToTheIdempiereLoginPage()
        {
            TestSuitesHomePage.OpenIDempiere();
        }
        
        [Given(@"I have logged in with valid credentials")]
        public void GivenIHaveLoggedInWithValidCredentials()
        {
            LoginPage.login("admin @ gardenworld.com", "GardenAdmin");
        }
        
        [When(@"I press select businees partner from favorites")]
        public void WhenIPressSelectBusineesPartnerFromFavorites()
        {
            CommonFunctions.waitForEelementExists(HomPageLocators.favorites);
            CommonFunctions.PerformClick(HomPageLocators.businessPartnerFromFav);
        }
        
        [Then(@"The business partner page should be displayed")]
        public void ThenTheBusinessPartnerPageShouldBeDisplayed()
        {
            CommonFunctions.waitForEelementExists(BusinessPartnerLocators.businessPartnerWindow);
            CommonFunctions.validateObjectVisible(BusinessPartnerLocators.businessPartnerWindow,"Busineess Partner Window");
        }

        [Given(@"I have navigated to the business partner page")]
        public void GivenIHaveNavigatedToTheBusinessPartnerPage()
        {
            TestSuitesHomePage.OpenIDempiere();
            LoginPage.login("admin @ gardenworld.com", "GardenAdmin");
            CommonFunctions.waitForEelementExists(HomPageLocators.favorites);
            CommonFunctions.PerformClick(HomPageLocators.businessPartnerFromFav);
            CommonFunctions.waitForEelementExists(BusinessPartnerLocators.businessPartnerWindow);
            CommonFunctions.validateObjectVisible(BusinessPartnerLocators.businessPartnerWindow, "Busineess Partner Window");
        }

        [When(@"I click on the close button")]
        public void WhenIClickOnTheCloseButton()
        {
            CommonFunctions.PerformClick(BusinessPartnerLocators.closeBusinessPartner);
        }

        [Then(@"The business partner page should be closed")]
        public void ThenTheBusinessPartnerPageShouldBeClosed()
        {
            CommonFunctions.waitForEelementNotExists(BusinessPartnerLocators.businessPartnerWindow);
            CommonFunctions.validateObjectInVisible(BusinessPartnerLocators.businessPartnerWindow,"Business Partner Window");
        }

        [When(@"I enter the values in the fields")]
        public void WhenIEnterTheValuesInTheFields()
        {
            BusinessPartner.enterValues("123", "asdf", "def", "test");
        }

        [When(@"click on reset button")]
        public void WhenClickOnResetButton()
        {
            CommonFunctions.PerformClick(BusinessPartnerLocators.btnReset);
        }

        [Then(@"The fields values filled should be removed")]
        public void ThenTheFieldsValuesFilledShouldBeRemoved()
        {
            BusinessPartner.validateEmptyFields();
        }

        [When(@"click on ok button")]
        public void WhenClickOnOkButton()
        {
            CommonFunctions.PerformClick(BusinessPartnerLocators.btnOk);
        }

        [Then(@"The business partner page should be open")]
        public void ThenTheBusinessPartnerPageShouldBeOpen()
        {
            CommonFunctions.waitForEelementExists(BusinessPartnerFormLocators.client);
        }

        [Given(@"I have navigated to create business partner page")]
        public void GivenIHaveNavigatedToCreateBusinessPartnerPage()
        {
            TestSuitesHomePage.OpenIDempiere();
            LoginPage.login("admin @ gardenworld.com", "GardenAdmin");
            CommonFunctions.waitForEelementExists(HomPageLocators.favorites);
            CommonFunctions.PerformClick(HomPageLocators.businessPartnerFromFav);
            CommonFunctions.waitForEelementExists(BusinessPartnerLocators.businessPartnerWindow);
            CommonFunctions.validateObjectVisible(BusinessPartnerLocators.businessPartnerWindow, "Busineess Partner Window");
            BusinessPartner.enterValues("123", "asdf", "def", "test");
            CommonFunctions.PerformClick(BusinessPartnerLocators.btnOk);
            CommonFunctions.waitForEelementExists(BusinessPartnerFormLocators.client);
            CommonFunctions.waitForEelementEnabled(BusinessPartnerLocators.newBusinessPartner);
            CommonFunctions.PerformClick(BusinessPartnerLocators.newBusinessPartner);
            CommonFunctions.waitForEelementEnabled(BusinessPartnerFormLocators.name);
        }

        [When(@"I enter the required values in Business partner form")]
        public void WhenIEnterTheRequiredValuesInBusinessPartnerForm()
        {
            BusinessPartnerInfo partnerInfo = new BusinessPartnerInfo();
            partnerInfo.name = "test2";
            partnerInfo.name2 = "user";
            partnerInfo.organization = "Fertilizer";
            partnerInfo.rating = "C";
            partnerInfo.referenceNumber = "user123";
            partnerInfo.searchKey = "9993";
            partnerInfo.vendor = true;
            partnerInfo.businessPartnerGroup = "Customers";
            partnerInfo.creditStatus = "OK";
            partnerInfo.description = "creating a test user";
            BusinessPartnerForm.enterValues(partnerInfo);
        }

        [When(@"Click on Save button")]
        public void WhenClickOnSaveButton()
        {
            CommonFunctions.PerformClick(BusinessPartnerFormLocators.save);
        }

        [Then(@"A new business partner should be created")]
        public void ThenANewBusinessPartnerShouldBeCreated()
        {
            RecentItemsWindowLocators.createBusinessPartnerXpath("9993", "test2");
            CommonFunctions.waitForEelementExists(RecentItemsWindowLocators.recentBusinessPartner);
            CommonFunctions.validateObjectVisible(RecentItemsWindowLocators.recentBusinessPartner,"business partner created");
        }

        [Then(@"The application should be closed after run")]
        public void ThenTheApplicationShouldBeClosedAfterRun()
        {
            CommonFunctions.closeApplication();
        }

    }
}
