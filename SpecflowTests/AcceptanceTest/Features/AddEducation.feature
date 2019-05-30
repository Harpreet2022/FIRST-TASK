Feature: AddEducation
	In order to update my profile
	I want to add education to the profile


@mytag
Scenario: Check if the user could able to add education
	Given I am on profile page and i clicked on the eductaion tab
	When I click on the add new button
	When I add details to add education
	When I clicked on the add button
	Then the eduction should be dispalyed in the profile
