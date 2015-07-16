Feature: Joke unseen by visitor
  In order to have a few laughs
  As a Comedy Store visitor
  I want to be shown a new joke everytime I visit the website

Scenario: Show unseen random joke to user
  Given I am a user
    And there are jokes available
    And I have already seen some of the available jokes
  When I ask to see a random joke
  Then the shown joke should be new to me
