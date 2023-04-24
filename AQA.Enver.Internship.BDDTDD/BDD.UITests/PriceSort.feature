Feature: PriceSort
	In order to have items sort by
	highest price to lowest
	I need to use sort feature

Scenario: Sort items from highest sort to lowest
	Given I go to website saucedemo.com
	And   I am filling in Username field
	And   I am filling in Password field
	When  I am clicking login button
	When  I click the filter dropdowm menu 
	And   I choose Price(high to low)
	Then goods become sorted from highest price to lowest
	