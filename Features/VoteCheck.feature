Feature: Vote Check
  As a Tester, I wanted to test the if the user is not able to vote twice for the same car.

  @automation
  Scenario: Vote Check
    Given  User login to application with "valid" inputs
    And     User click on the Popular Make category
    When  The user select the car that is already voted 
    Then   The user should not see the vote button