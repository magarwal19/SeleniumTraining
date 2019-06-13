using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OnlineInvoiceSystem.Wrapper;
namespace OnlineInvoiceSystem.Pages
{
    class ClientAddNewPage
    {
        //By newClients = By.XPath("//h4[text()='Clients: Add New']");
        By newClients = By.XPath("//strong[contains(text(),'Client data')]");
        By name = By.Id("name");
        By contact = By.Id("contact");
        By title = By.Id("title");
        By address = By.Id("address");
        By city = By.Id("city");
        By country = By.Id("country");
        By phone = By.Id("phone");
        By emailEdit = By.Id("email-edit-link");
        By emailTextBox = By.Id("email");
        By websiteEdit = By.Id("website-edit-link");
        By websiteTextBox = By.Id("website");
        By comments = By.XPath("//div[contains(@class,'nicEdit-main')]");
        By saveNew = By.XPath("//button[contains(text(),'Save New')]");
        public string strName, strContact, strTitle, strAddress, strCity, strCountry, strPhone, strEmail, strWebsite, strComments = "";
        public void validateAddClientWindow()
        {
            CommonFunctions.switchToFrame();
            CommonFunctions.waitForEelementExists(newClients);
            CommonFunctions.validateObjectVisible(newClients,"new client window");
        }
        public void enterValues()
        {
            if(!strName.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(name,strName);
            }
            if (!strContact.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(contact, strContact);
            }
            if (!strTitle.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(title, strTitle);
            }
            if (!strAddress.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(address, strAddress);
            }
            if (!strCity.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(city, strCity);
            }
            if (!strCountry.Equals(string.Empty))
            {
                CommonFunctions.selectDropDownByText(country, strCountry);
            }
            if (!strPhone.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(phone, strPhone);
            }
            if (!strEmail.Equals(string.Empty))
            { 
                CommonFunctions.PerformClick(emailEdit);
                CommonFunctions.EnterKeys(emailTextBox, strEmail);
            }
            if (!strWebsite.Equals(string.Empty))
            {
                CommonFunctions.PerformClick(websiteEdit);
                CommonFunctions.EnterKeys(websiteTextBox, strWebsite);
            }
            if (!strComments.Equals(string.Empty))
            {
                CommonFunctions.EnterKeys(comments, strComments);
            }
        }
    }
}
