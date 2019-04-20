using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps:Base 
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
        
        [When(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
