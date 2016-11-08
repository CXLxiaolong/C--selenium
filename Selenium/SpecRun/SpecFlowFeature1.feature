@TestDILATO
Feature: SpecFlowFeature1

@selenium-01
Scenario: The website display successfully
	Given I choose local firefox to start
	When  forward to 'http://10.0.30.2:8082/'
	Then  The website display successfully

@selenium-02
Scenario: The CONTACT US page displayed
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	When I navigate to contact us page
	Then The CONTACT US page displayed

@selenium-03
Scenario: Check the header text
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	When I navigate to contact us page
	Then Check the header text

@selenium-04
Scenario: Check the default value of Topic Interested
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	When I navigate to contact us page
	Then the default value of Topic Interested is 'Cloud Testing'

@Selenium-05
Scenario: Check all the selects in Topic Interested
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When I check the Topic Interested dropdown list
	Then all options should be 'Cloud Testing、Embedded System Testing、Globalization Testing、Offshore Test Center、System Integration Testing、Test Automation、Function Testing、Mobile Testing、Cloud Services、SKYPALACE、Mobile Test Automation、Test Automation Framework、IaaS Cloud Enablement、Desktop Virtualization、Others' 
	And all options can be selected successfully

@selenium-06
Scenario: Check the default value of Join us
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
    When  I navigate to contact us page
	Then  the Join us is selected

@Selenium-07
Scenario: Check the mandatory in the webform
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When I click the Submit button 
	Then Prompt error message

@Selenium-08
Scenario: Input test to Email and move course to other item
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When Input "test" to Email and move course to other item
	And I click the Submit button 
	Then The data can not be saved

@Selenium-09
Scenario: Input the whole data to field except "Email" and click submit button
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When Input " " to Email and move course to other item
	And I click the Submit button 
	Then Check the warning massage Email field is required


@Selenium-10
Scenario: Input the right value to Email and clikc submit button
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When Input "xiaolong.chen@dilatoit.com" to Email and move course to other item
	And I click the Submit button 
	Then The data saved successfully with "Thank you,your submission has been received"


@Selenium-11
Scenario: Click Go back to the form
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When Input "xiaolong.chen@dilatoit.com" to Email and move course to other item
	And I click the Submit button 
	And  click the Go back to the form button  
	Then The edit page displayed


@Selenium-12
Scenario: Click Login on the top
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When clcik the Login button 
	Then Check the login page displayed

@Selenium-13
Scenario: Input the value username and password and click Log in	
	Given I choose local firefox to start
	And forward to 'http://10.0.30.2:8082/'
	And I navigate to contact us page
	When clcik the Login button and enter account  
	Then the login successful 


@Selenium-Grid
Scenario: Test Selenium Grid
	Given I connect Selenium server and choose firefox to start
	When  forward to 'http://10.0.30.2:8082/'
	Then  The website display successfully

@Selenium-Remote
Scenario Outline: Test Saucelabs
	Given I connect saucelabs and choose <Browser> of <Version> at <Platform> 
	When  forward to 'http://10.0.30.2:8082/'
	Then  The website display successfully
Examples: 
	| Browser | Version | Platform   |
	| Firefox | 47.0    | Windows 7  |
	| Chrome  | 50.0    | Windows 10 |
	| Safari  | 9.0     | OS X 10.11 |
