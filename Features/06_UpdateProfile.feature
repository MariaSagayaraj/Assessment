Feature: 06_UpdateProfile
    As a User,
    I need to update my profile details

    Background: 
    Given I login to the application using "valid" credentials
 
@automate
Scenario: 01_Update my information
    And I enter data to all fields
    When I click on Save button
    Then The profile should be saved successfully

 @automate
    Scenario: 02_Change Password
    And I enter data to the password fields
    When I click on Save button
    Then The password should be changed successfully