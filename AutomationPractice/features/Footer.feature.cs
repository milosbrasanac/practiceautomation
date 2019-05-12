﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationPractice.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Footer")]
    public partial class FooterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Footer.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Footer", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can open links ynder Information section")]
        [NUnit.Framework.CategoryAttribute("Footer")]
        [NUnit.Framework.TestCaseAttribute("Specials", "Price drop", null)]
        [NUnit.Framework.TestCaseAttribute("New products", "New products", null)]
        [NUnit.Framework.TestCaseAttribute("Best sellers", "Best sellers", null)]
        [NUnit.Framework.TestCaseAttribute("Our stores", "Our store(s)!", null)]
        [NUnit.Framework.TestCaseAttribute("Contact us", "Contact", null)]
        [NUnit.Framework.TestCaseAttribute("Terms and conditions of use", "Terms and conditions of use", null)]
        [NUnit.Framework.TestCaseAttribute("About us", "About us", null)]
        [NUnit.Framework.TestCaseAttribute("Sitemap", "Sitemap", null)]
        public virtual void UserCanOpenLinksYnderInformationSection(string informationLink, string page, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Footer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can open links ynder Information section", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.When(string.Format("user clicks on \'{0}\' option", informationLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("correct \'{0}\' is disabled", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can open links under My Account section")]
        [NUnit.Framework.CategoryAttribute("Footer")]
        [NUnit.Framework.TestCaseAttribute("My orders", "Order history", null)]
        [NUnit.Framework.TestCaseAttribute("My credit slips", "Credit slips", null)]
        [NUnit.Framework.TestCaseAttribute("My addresses", "My addresses", null)]
        [NUnit.Framework.TestCaseAttribute("Manage my personal information", "Your personal information", null)]
        public virtual void UserCanOpenLinksUnderMyAccountSection(string myAccountLink, string page, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Footer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can open links under My Account section", @__tags);
#line 23
    this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("user opens sign in page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
    testRunner.And("enters correct credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
    testRunner.And("user submits the login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.When(string.Format("user clicks on \'{0}\' option", myAccountLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
    testRunner.Then(string.Format("correct \'{0}\' is disabled", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

