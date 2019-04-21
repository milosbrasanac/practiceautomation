using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        public object HomePage { get; private set; }

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.signIn);
        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Passwoard);

        }

        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccount ma = new MyAccount(Driver);
            Assert.True(ut.ElementDisplayed(ma.signout), "User is not logged in");
        }


        [When(@"user open my wishlist page")]
        public void WhenUserMyWishlist()
        {
            MyAccount ma = new MyAccount(Driver);
            ut.ClickOnElement(ma.Mywishlistbutton);
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            MyWishlistPage mwp = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(mwp.newWishList), "User can not add wishlist");
        }
        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.email, email);
            ut.ClickOnElement(ap.signUpBtn);
        }
        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.EnterTextInElement(cap.firstname, TestConstants.firstname);
            ut.EnterTextInElement(cap.lastname, TestConstants.lastname);
            ut.EnterTextInElement(cap.password, TestConstants.password);
            ut.EnterTextInElement(cap.addressfirstname, TestConstants.lastname);
            ut.EnterTextInElement(cap.addresslastname, TestConstants.lastname);
            ut.EnterTextInElement(cap.currentaddress, TestConstants.currentaddress);
            ut.EnterTextInElement(cap.currentcity, TestConstants.currentcity);
            ut.DropdownSelect(cap.residentcountry, TestConstants.residentstate);
            ut.EnterTextInElement(cap.ZipPostalCode, TestConstants.ZipPostalCode);
            ut.EnterTextInElement(cap.mobilephone, TestConstants.mobilephone);
            ut.EnterTextInElement(cap.addressalias, TestConstants.addressalias);
            string fullname = TestConstants.firstname + "" + TestConstants.lastname;
            ScenarioContext.Current.Add(TestConstants.FullName, fullname);

        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
