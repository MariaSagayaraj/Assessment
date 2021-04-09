Feature: 01_Registration
	As a User
	I want to Register into the Buggy Cars rating web application

@automation
Scenario: Registration
	Given I Navigate to the website
	And    I click on Register button
	And    I enter data to the fields
	When I click on Register button
	Then  I should be registered successfully <ScreenshotName>

	Examples: 
	| ScreenshotName |
	| Registration           |
	