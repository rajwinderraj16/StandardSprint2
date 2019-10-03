Feature: SearchByCategory
	In order to trdae skilld
	As a registered users
	I want to  serach skills by the category

@mytag
Scenario: Search skill by category
	Given I am on the profile page
	And I click on the serach icon
	When I select the category
	Then the selected category result should be displayed

