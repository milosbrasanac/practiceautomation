using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationPractice.Helpers;
using NUnit.Framework;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps:Base
    {
        Footer ft = new Footer(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {
            ft.ClickOnInformationLink(link);

        }

        [Then(@"correct '(.*)' is disabled")]
        public void ThenCorrectPageIsDisabled(string pageName)
        {
            Assert.True(ft.InformationPageDisplayed(pageName), "information page is not displayed");
        }
    }
}
// ime parametra ne ide pod navodnike a vrednost ide pod navodnike