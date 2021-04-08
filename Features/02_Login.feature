Feature: 02_Login
  As a Tester, I wanted to test the login functionality of  Buggy Cars Rating application

  @automation
  Scenario Outline: 1 Log into the application with different inputs
    Given I open browser and navigate to the url
    When I enter <data> login credentials and click login button
    Then I validate successfull login to the application as per the <data>

    Examples:
      | data  |
      | valid |
      | invalid |
      | null |

    @automation
   Scenario Outline: 2 Logging out
    Given   I open browser and navigate to the url
    When   I enter <data> login credentials and click login button
    And       I click on Logout button
    Then   I should be successfully logged out from the application

    Examples:
      | data  |
      | valid |