Feature: 02_Login
  As a user, I wanted to login to the application

@automation
Scenario Outline: 1 Log into the application with different inputs
	Given I open browser and navigate to the url
	When I enter <data> login credentials and click login button
	Then I validate successfull login to the application as per the <data>, <screenshotName>

	Examples:
		| data     | screenshotName |
		| valid     |      Login_valid      |
		| invalid |      Login_invalid   |
		| null       |      Login_null         |

@automation
Scenario Outline: 2 Logging out
	Given   I open browser and navigate to the url
	When   I enter <data> login credentials and click login button
	And       I click on Logout button
	Then   I should be successfully logged out from the application <screenshotName>

	Examples:
		| data  | screenshotName |
		| valid |             Logout         |