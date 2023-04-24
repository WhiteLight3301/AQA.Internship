Feature: Division of two numbers
In order to use division function 
As user
I want to divide two plain numbers 

Background: Given I start calculator	
Scenario: Divide two numbers
	And  the first  digit is 45
	And  the second digit is 5
	When the two numbers are divided
	Then the result should be 9
	
Scenario: Divide two negative numbers
	And  the first  digit is -4
	And  the second digit is -2
	When the two numbers are divided
	Then the result of that should be 2