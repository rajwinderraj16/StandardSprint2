Feature: ShareSkill
	In order to trade skills
	As a registred user
	I want to add skill 

@mytag
Scenario: Add skill
	Given I have clicked on the profile tab
	And I click on the Share skill tab
	When I enter the skill detail
	Then the skill should be added