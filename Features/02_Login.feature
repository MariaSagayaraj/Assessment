Feature: 02_Login
  As a Tester, I wanted to test the login functionality of  Buggy Cars Rating application

  @automation
  Scenario Outline: Log into the application with different inputs
    Given I open browser and navigate to the url
    When I enter <data> login credentials and click login button
    Then I validate successfull login to the application as per the <data>

    Examples:
      | data  |
      | valid |
      | invalid |
      | null |