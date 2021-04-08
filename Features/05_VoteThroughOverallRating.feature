Feature: 05_Vote through Overall rating 
  As a Tester, I wanted to test the if the user is able to vote through overall rating

  @automation
  Scenario: Vote through Overall rating
    Given  I login to application with "valid" inputs
    And     I click on the Overall rating category
    And     I select the car to vote
    When  I Add a comment and vote
    Then   I should be able to see the successful vote message added