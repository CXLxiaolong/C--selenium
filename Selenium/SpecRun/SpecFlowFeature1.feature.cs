﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Selenium.SpecRun
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SpecFlowFeature1", new string[] {
            "TestDILATO"}, SourceFile="SpecRun\\SpecFlowFeature1.feature", SourceLine=1)]
    public partial class SpecFlowFeature1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", null, ProgrammingLanguage.CSharp, new string[] {
                        "TestDILATO"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("The website display successfully", new string[] {
                "selenium-01"}, SourceLine=4)]
        public virtual void TheWebsiteDisplaySuccessfully()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The website display successfully", new string[] {
                        "selenium-01"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("The website display successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The CONTACT US page displayed", new string[] {
                "selenium-02"}, SourceLine=10)]
        public virtual void TheCONTACTUSPageDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The CONTACT US page displayed", new string[] {
                        "selenium-02"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("The CONTACT US page displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check the header text", new string[] {
                "selenium-03"}, SourceLine=17)]
        public virtual void CheckTheHeaderText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the header text", new string[] {
                        "selenium-03"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Check the header text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check the default value of Topic Interested", new string[] {
                "selenium-04"}, SourceLine=24)]
        public virtual void CheckTheDefaultValueOfTopicInterested()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the default value of Topic Interested", new string[] {
                        "selenium-04"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the default value of Topic Interested is \'Cloud Testing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check all the selects in Topic Interested", new string[] {
                "Selenium-05"}, SourceLine=31)]
        public virtual void CheckAllTheSelectsInTopicInterested()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check all the selects in Topic Interested", new string[] {
                        "Selenium-05"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("I check the Topic Interested dropdown list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(@"all options should be 'Cloud Testing、Embedded System Testing、Globalization Testing、Offshore Test Center、System Integration Testing、Test Automation、Function Testing、Mobile Testing、Cloud Services、SKYPALACE、Mobile Test Automation、Test Automation Framework、IaaS Cloud Enablement、Desktop Virtualization、Others'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("all options can be selected successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check the default value of Join us", new string[] {
                "selenium-06"}, SourceLine=40)]
        public virtual void CheckTheDefaultValueOfJoinUs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the default value of Join us", new string[] {
                        "selenium-06"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.When("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the Join us is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check the mandatory in the webform", new string[] {
                "Selenium-07"}, SourceLine=47)]
        public virtual void CheckTheMandatoryInTheWebform()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the mandatory in the webform", new string[] {
                        "Selenium-07"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("Prompt error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input test to Email and move course to other item", new string[] {
                "Selenium-08"}, SourceLine=55)]
        public virtual void InputTestToEmailAndMoveCourseToOtherItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input test to Email and move course to other item", new string[] {
                        "Selenium-08"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("Input \"test\" to Email and move course to other item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("The data can not be saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input the whole data to field except \"Email\" and click submit button", new string[] {
                "Selenium-09"}, SourceLine=64)]
        public virtual void InputTheWholeDataToFieldExceptEmailAndClickSubmitButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input the whole data to field except \"Email\" and click submit button", new string[] {
                        "Selenium-09"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("Input \" \" to Email and move course to other item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("Check the warning massage Email field is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input the right value to Email and clikc submit button", new string[] {
                "Selenium-10"}, SourceLine=74)]
        public virtual void InputTheRightValueToEmailAndClikcSubmitButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input the right value to Email and clikc submit button", new string[] {
                        "Selenium-10"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("Input \"xiaolong.chen@dilatoit.com\" to Email and move course to other item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("The data saved successfully with \"Thank you,your submission has been received\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Click Go back to the form", new string[] {
                "Selenium-11"}, SourceLine=84)]
        public virtual void ClickGoBackToTheForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Click Go back to the form", new string[] {
                        "Selenium-11"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When("Input \"xiaolong.chen@dilatoit.com\" to Email and move course to other item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("click the Go back to the form button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("The edit page displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Click Login on the top", new string[] {
                "Selenium-12"}, SourceLine=95)]
        public virtual void ClickLoginOnTheTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Click Login on the top", new string[] {
                        "Selenium-12"});
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 98
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.When("clcik the Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("Check the login page displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input the value username and password and click Log in", new string[] {
                "Selenium-13"}, SourceLine=103)]
        public virtual void InputTheValueUsernameAndPasswordAndClickLogIn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input the value username and password and click Log in", new string[] {
                        "Selenium-13"});
#line 104
this.ScenarioSetup(scenarioInfo);
#line 105
 testRunner.Given("I choose local firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I navigate to contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.When("clcik the Login button and enter account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("the login successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Selenium Grid", new string[] {
                "Selenium-Grid"}, SourceLine=112)]
        public virtual void TestSeleniumGrid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Selenium Grid", new string[] {
                        "Selenium-Grid"});
#line 113
this.ScenarioSetup(scenarioInfo);
#line 114
 testRunner.Given("I connect Selenium server and choose firefox to start", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 115
 testRunner.When("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then("The website display successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void TestSaucelabs(string browser, string version, string platform, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Selenium-Remote"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Saucelabs", @__tags);
#line 119
this.ScenarioSetup(scenarioInfo);
#line 120
 testRunner.Given(string.Format("I connect saucelabs and choose {0} of {1} at {2}", browser, version, platform), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 121
 testRunner.When("forward to \'http://10.0.30.2:8082/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("The website display successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Firefox", new string[] {
                "Selenium-Remote"}, SourceLine=124)]
        public virtual void TestSaucelabs_Firefox()
        {
            this.TestSaucelabs("Firefox", "47.0", "Windows 7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Chrome", new string[] {
                "Selenium-Remote"}, SourceLine=124)]
        public virtual void TestSaucelabs_Chrome()
        {
            this.TestSaucelabs("Chrome", "50.0", "Windows 10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Safari", new string[] {
                "Selenium-Remote"}, SourceLine=124)]
        public virtual void TestSaucelabs_Safari()
        {
            this.TestSaucelabs("Safari", "9.0", "OS X 10.11", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
