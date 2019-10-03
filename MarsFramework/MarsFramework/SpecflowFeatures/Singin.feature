Feature: Singin
	In order to trade skills
	As a register trades
	I want to login in my account

@mytag
Scenario: SignIn
	Given I launched the Skillswappro website
	And I clicked on the signin tab
	When I entered username,password 
	Then I click on the signin button should be redireted to my homepage
