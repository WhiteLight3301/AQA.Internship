Feature: Login
	In order to have acess to website service 
	as a user
	I need to login

Scenario: Login with standard user
	Given I go to website saucedemo.com
	And  I fill in Username field
	And I fill in Password field
	When I click login button
	Then I should be logged in
