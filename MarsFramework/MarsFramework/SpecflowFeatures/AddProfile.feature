Feature: AddProfile
	In order to trade skills
	As a registered users
	I want to update my profile

@mytag

Scenario: Check if user is able to add Avalability,Salary,Location to the profile
Given I clicked on the  profile tab
When I add the detail about availability,hours,salary and location
Then that details should be displayed on my page

Scenario: Check if user could able to add a language
Given I clicked on the Language tab under Profile page
When I add new language
Then that language should be displayed on my page

Scenario: Check if user could able to add new skills
Given I clicked on the skill tab under Profile page
When I add new skill
Then that skill should be displayed on my page

Scenario: Check if user could able to add educations
Given I clicked on the education tab under Profile page
When I add new education
Then that educatiion should be displayed on my page

Scenario: Check if user could able to add a certifications
Given I clicked on the certification tab under Profile page
When I add new certification
Then that certification should be displayed on my page

Scenario: Check if user could able to add a description
Given I clicked on the description icon under Profile page
When I add new description
Then that description should be displayed on my page

