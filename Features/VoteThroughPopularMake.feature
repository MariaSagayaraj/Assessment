Feature: Vote through Popular Make
  As a Tester, I wanted to test the if the user is able to vote through Popular Make

  @automation
  Scenario: Vote through Popular Make
    Given I login to the application with "valid" inputs
    And   I click on the Popular Make category 
    And   I click on the desired car model
    When  I add comment and vote
    Then  I should be able to see the vote has been added