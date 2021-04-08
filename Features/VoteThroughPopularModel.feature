Feature: Vote through Popular Model
  As a Tester, I wanted to test the if the user is able to vote through Popular Model

  @automation
  Scenario: Vote through Popular Model
   Given  I login to the application with "valid" input
    And     I click on the Popular Model category
    When  I add a comment and vote
    Then   I should be able to see the successful vote message
