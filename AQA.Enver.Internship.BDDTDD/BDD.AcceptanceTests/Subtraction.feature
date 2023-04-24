Feature: Subtraction of two numbers
In order to use deduct function 
As user
I want to deduct two plain numbers 
	
Background: 
	Given  I start the calculator
Scenario: Subtract two numbers
	And the first  number is 70
	And the second number is 50
	When the two numbers are deducted
	Then the result have to be 20