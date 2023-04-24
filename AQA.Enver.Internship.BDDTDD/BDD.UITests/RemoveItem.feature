Feature: RemoveItem
	In order to remove item from cart 
	I want to add item to cart
	and test remove button

Scenario: Remove item
	Given I go to website saucedemo.com
	Then  I fill in login form
	And  I click login button
	Then I click on Add to cart on random item
	When I go to cart page 
	And  I click remove button
	Then the result is empty cart
