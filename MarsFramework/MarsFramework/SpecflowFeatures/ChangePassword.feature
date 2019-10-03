Feature: ChangePassword
	In order to trade skills 
	As a registered trader 
	I want to change my password

@mytag
Scenario: change password
	Given I have logged in my profile
	And I add the new and current password
	When I confirm password
	Then the new password should be added to my account 
