Feature: AddSkills
	In order to update my profile
	I want to add skills to the profile


@mytag
Scenario: Check if the user could able to add skills 
	Given I am on profile page and i clicked on the skills tab
    When I Click on the add new button
	When I add the details to add skill
	When I click on the add button
	Then the skill should be added in my profile 
