﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.SpecflowTests.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Certifications tab")]
    public partial class CertificationsTabFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Certifications.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Certifications tab", "\tIn order to update my profile\r\n\tAs a skill trader\r\n\tI want to add, edit and dele" +
                    "te my cetificate information", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add new certificate deatil")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddNewCertificateDeatil()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add new certificate deatil", null, new string[] {
                        "manual"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I am on the Certifications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I add new value in certificate or Award, certificate Formate and Year fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I clicked on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("new certificate detail should display on my listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to edit selected certificate deatil")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToEditSelectedCertificateDeatil()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit selected certificate deatil", null, new string[] {
                        "manual"});
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
testRunner.Given("The certificate deatil is alrady exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.When("I click on edit icon and edit selected certificate deatil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("the edited certificate deatil should display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to delete certificate deatil")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToDeleteCertificateDeatil()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete certificate deatil", null, new string[] {
                        "manual"});
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 22
testRunner.Given("The certificate deatil is alrady exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
testRunner.When("I click on delete icon and delete selected certificate deatil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("the deleted certificate deatil should not display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add duplicate certificate deatil")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddDuplicateCertificateDeatil()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add duplicate certificate deatil", null, new string[] {
                        "manual"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
testRunner.Given("The certificate deatil is already in my list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
testRunner.When("I try to add the same certificate deatil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("The alert message \"Duplicate data\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
testRunner.And("certificate deatil does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add certificate details without filling all the fields")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddCertificateDetailsWithoutFillingAllTheFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add certificate details without filling all the fields", null, new string[] {
                        "manual"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
testRunner.Given("I am on the Certifications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.When("I clicked on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.And("I did not enter any value in any field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.Then("The alert message \"Please enter Certificate Name,Cetificate form and Certificate " +
                    "Year\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.And("education deatil does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

