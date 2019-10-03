Feature: SearchSkill
	In order to trade skills
	As a registred users
	I want to search skill

@mytag
Scenario: Search skill
	Given I am on the profile tab
	And I entered the Automation in the search field
	When I click on the serach icon
	Then the relavant result should be displayed

	Scenario: Search skill by user
	Given I am on the profile page
	And I click on the serach icon on the serach page
	When I entered the user's name in the user field
	Then the relavant result should be displayed on the page
	