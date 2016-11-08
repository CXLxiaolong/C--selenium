using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDriver;
using OpenQA.Selenium.Remote;
using PageObject;
using Support;
using TechTalk.SpecFlow;

namespace Selenium.SpecRun
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public WebDriver Driver;
        public HomePage homepage;
        public ContactUs contactUs;
        public LoginPage login;
        public ContactDilatoPage ContactDilato;
        public WebElement TopicInterested;
        public List<WebElement> ActualValue;
        public string[] ExpectedValue;

        #region The website display successfully

        [Given(@"I choose local firefox to start")]
        public void GivenIChooseLocalFirefoxToStart()
        {
            Driver = new WebDriver(Browser.Firefox);
            homepage = new HomePage(Driver);
            contactUs = new ContactUs(Driver);
            login = new LoginPage(Driver);
            ContactDilato = new ContactDilatoPage(Driver);

        }
        [Given(@"forward to '(.*)'")]
        [When(@"forward to '(.*)'")]
        public void GivenForwardTo(string p0)
        {
            Driver.GotoUrl(p0);
        }

        [Then(@"The website display successfully")]
        public void ThenTheWebsiteDisplaySuccessfully()
        {
            Driver.title.ShouldBeEqualsTo("DILATO | The new way to extend |");
        }

        #endregion

        #region The CONTACT US page displayed
        [Given(@"I navigate to contact us page")]
        [When(@"I navigate to contact us page")]

        public void GivenINavigateToContactUsPage()
        {
            homepage.ContactUS.Click();
        }

        [Then(@"The CONTACT US page displayed")]
        public void ThenTheCONTACTUSPageDisplayed()
        {
            Driver.title.ShouldBeEqualsTo("Contact DILATO | DILATO | The new way to extend");
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/contact-us");
            contactUs.HeaderText.Text.ShouldBeEqualsTo("At Dilato, we are delighted to get feedback from you. Use the form below to let us know your opinion about our services, solutions, and the areas that need improvement. We regard your feedback and suggestions as the key driving factors for building a better experience to all our users.");
        }

        #endregion

        #region Check the header text


        [Then(@"Check the header text")]
        public void ThenCheckTheHeaderText()
        {
            contactUs.HeaderText.Text.ShouldBeEqualsTo("At Dilato, we are delighted to get feedback from you. Use the form below to let us know your opinion about our services, solutions, and the areas that need improvement. We regard your feedback and suggestions as the key driving factors for building a better experience to all our users.");
        }
        #endregion

        #region Check the default value of Topic Interested

        [Then(@"the default value of Topic Interested is '(.*)'")]
        public void ThenTheDefaultValueOfTopicInterestedIs(string p0)
        {
            
           contactUs.TopicInterested.Text.ShouldBeEqualsTo(p0);         

        }
        #endregion

        #region Check all the selects in Topic Interested
        [When(@"I check the Topic Interested dropdown list")]
        public void WhenICheckTheTopicInterestedDropdownList()
        {
            TopicInterested = contactUs.TopicInterested;
        }

        [Then(@"all options should be '(.*)'")]
        public void ThenAllOptionsShouldBe(string p0)
        {
            ActualValue = TopicInterested.GetDropdownAllOptions();
            ExpectedValue = p0.Split('、');
        }

        [Then(@"all options can be selected successfully")]
        public void ThenAllOptionsCanBeSelectedSuccessfully()
        {
            for (var i = 0; i < ActualValue.Count; i++)
            {
                TopicInterested.SelectByIndex(i);
                ExpectedValue[i].ShouldBeEqualsTo(TopicInterested.SelectedOption.Text, "Topic Interested value not as expected at index " + i);
            }
        }

        #endregion

        #region  Check the default value of Join us

        [Then(@"the Join us is selected")]
        public void ThenTheJoinUsIsSelected()
        {
            contactUs.JionUS.Selected.ShouldBeTrue();
        }

        #endregion

        #region Check the mandatory in the webform

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            contactUs.Submit.Click();
        }

        [Then(@"Prompt error message")]
        public void ThenPromptErrorMessage()
        {
            contactUs.ErrorOrganization.Text.ShouldBeEqualsTo("Organization field is required.");
            contactUs.ErrorTitle.Text.ShouldBeEqualsTo("Title field is required.");
            contactUs.ErrorFirstName.Text.ShouldBeEqualsTo("First Name field is required.");
            contactUs.ErrorLastName.Text.ShouldBeEqualsTo("Last Name field is required.");
            contactUs.ErrorEmail.Text.ShouldBeEqualsTo("Email field is required.");
            contactUs.ErrorContactNumber.Text.ShouldBeEqualsTo("Contact Number field is required.");
        }

        #endregion

        #region Input test to Email and move course to other item

        [When(@"Input ""(.*)"" to Email and move course to other item")]

        public void WhenInputToAndMoveCourseToOtherItem(string p0)
        {
            contactUs.EnterValueOnScreen(p0);

        }
        [Then(@"The data can not be saved")]
        public void ThenTheDataCanNotBeSaved()
        {
            contactUs.HeaderText.Text.ShouldBeEqualsTo("At Dilato, we are delighted to get feedback from you. Use the form below to let us know your opinion about our services, solutions, and the areas that need improvement. We regard your feedback and suggestions as the key driving factors for building a better experience to all our users."); 
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/contact-us");
        }

        #endregion

        #region Input the whole data to field except "Email" and click submit button

        [Then(@"Check the warning massage Email field is required")]
        public void ThenCheckTheWarningMassageEmailFieldIsRequired()
        {

            contactUs.HeaderText.Text.ShouldBeEqualsTo("At Dilato, we are delighted to get feedback from you. Use the form below to let us know your opinion about our services, solutions, and the areas that need improvement. We regard your feedback and suggestions as the key driving factors for building a better experience to all our users.");
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/contact-us");
        }

        #endregion

        #region Input the right value to Email and clikc submit button

        [Then(@"The data saved successfully with ""(.*)""")]
        public void ThenTheDataSavedSuccessfullyWith(string p0)
        {

            ContactDilato.ThankYou.Text.ShouldBeEqualsTo("Thank you, your submission has been received.");

        }


        #endregion

        #region Click Go back to the form

        [When(@"click the Go back to the form button")]
        public void WhenClickTheGoBackToTheFormButton()
        {
            ContactDilato.Gobacktotheform.Click();
        }

        [Then(@"The edit page displayed")]
        public void ThenTheEditPageDisplayed()
        {
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/contact-us");
        }

        #endregion

        #region Click Login on the top
         [When(@"clcik the Login button")]
        public void WhenClcikTheLoginButton()
        {
            contactUs.Login.Click();
        }
        [Then(@"Check the login page displayed")]
        public void ThenCheckTheLoginPageDisplayed()
        {
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/user");
            login.login.IsDisplayed.ShouldBeTrue();
        }

        #endregion

        #region  Input the value username and password and click Log in

        [When(@"clcik the Login button and enter account")]
        public void WhenClcikTheLoginButtonAndEnterAccount()
        {
            contactUs.Login.Click();
            login.UserName.Sendkeys("test");
            login.Password.Sendkeys("test");
            login.login.Click();
        }


        [Then(@"the login successful")]
        public void ThenTheLoginSuccessful()
        {
            Driver.url.ShouldBeEqualsTo("http://10.0.30.2:8082/user/1");
            Driver.title.ShouldBeEqualsTo("test | DILATO | The new way to extend");
        }
        #endregion

        #region Selenium Grid

        [Given(@"I connect Selenium server and choose firefox to start")]
        public void GivenIConnectSeleniumServerAndChooseFirefoxToStart()
        {
            var url = "http://localhost:4444/wd/hub";
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability("Platform", "win10");
            Driver = new WebDriver(url, capabilities);
        }

        #endregion

        #region RemoteWebDriver

        [Given(@"I connect saucelabs and choose (.*) of (.*) at (.*)")]
        public void GivenIConnectSaucelabsAndChooseFirefoxOfAtWindows(string p0,string p1,string p2)
        {
            var url= "http://ondemand.saucelabs.com/wd/hub";
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("Username", "DemoDemoDemo");
            capabilities.SetCapability("AccessKey", "70d7f837-5e7c-456b-bf1c-0b94834edd2e");
            capabilities.SetCapability("name", "Test");
            capabilities.SetCapability(CapabilityType.BrowserName, p0);
            capabilities.SetCapability("version", p1);
            capabilities.SetCapability("Platform", p2);
            Driver = new WebDriver(url, capabilities);
        }

        #endregion

        #region Common

        [BeforeScenario]
        public void BeforeScenario()
        {
         
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }

        #endregion
    }
}
