Feature: Multiplication of two numbers
In order to use multiply function 
As user
I want to multiply two plain numbers 
	
Scenario: Multiply two numbers
	Given I start calculator
	And the first number  is  10
	And the second number  is  15
	When the two numbers are multiplied
	Then the result should be  150