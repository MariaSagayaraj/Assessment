Feature: 04_Vote through Popular Model
  As a user, I wanted to vote through Popular Model category

  @automation
  Scenario: Vote through Popular Model
   Given  I login to the application with "valid" input
    And     I click on the Popular Model category
    When  I add a comment and vote
    Then   I should able to see the successful vote message <screenshotName>

    Examples:
    | screenshotName |
    | Popular_Model    |
