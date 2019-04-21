using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class CreateAccountPage
    {
        readonly IWebDriver driver;

        public By firstname = By.Id("customer_firstname");
        public By lastname = By.Id("customer_lastname");
        public By password = By.Id("passwd");
        public By addressfirstname = By.Id("firstname");
        public By addresslastname = By.Id("lastname");
        public By currentaddress = By.Id("address1");
        public By currentcity = By.Id("city");
        public By residentcountry = By.Id("id_state");
        public By mobilephone = By.Id("phone_mobile");
        public By registerbutton = By.Id("submitAccount");
        public By addressalias = By.Id("alias");
        public By ZipPostalCode = By.Id("postcode");

        public CreateAccountPage(IWebDriver driver)
        {

            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));


        }
    }
}
