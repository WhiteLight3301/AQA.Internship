Feature: Addition of two numbers
   In order to use sum function 
   As user
   I want to sum two plain numbers 
	
  Background: 
	Given I start calculator
  Scenario: Add two numbers
	And the first  number is 14
	And the second number is 13247
	When this numbers are added
	Then the result should is 13261
	
 Scenario: Add one negative number and another positive number
	And the first negative number is -44
    And the second positive number is 20
    When this numbers are added together
    Then the result of their sum should be -24

	