Feature: ManageListing
	In to update my skills
	As a registerd users 
	I want to be edit and detele some skills 

@mytag
Scenario: Edit skill
	Given I cliked on the ManageListing tab
    When  I enter the new skill the skill
	Then the skill should be edited

Scenario: Delete skill
	Given I cliked on the ManageListing tab
    When  I clicked on the delete button
	Then the skill should be deleted 
