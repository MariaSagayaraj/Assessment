Feature: 05_Vote through Overall rating 
  As a user, I wanted to vote through overall rating category

  @automation
  Scenario: Vote through Overall rating
    Given  I login to application with "valid" inputs
    And     I click on the Overall rating category
    And     I select the car to vote
    When  I Add a comment and vote
    Then   I should be able to see the successful vote message <screenshotName>

    Examples:
    | screenshotName |
    | Overall_Rating    |