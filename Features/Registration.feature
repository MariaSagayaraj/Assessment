Feature: Registration
	As a User
	I want to Register myself

@mytag
Scenario: Registration
	Given I Navigate to the website
	And I click on Register button
	And I enter data to the fields
	When I click on Register button
	Then I should be registered successfully