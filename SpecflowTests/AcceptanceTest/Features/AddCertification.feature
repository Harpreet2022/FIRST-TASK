Feature: AddCertification
	In order to update my profile
	I want to add certificate to the profile

@mytag
Scenario: Check if the user could be able to add certification
	Given I am on profile page and I clicked on the certification tab
	When I clicked on the add new button
	When I add all the detail for certification
	When I click on  add button
	Then the certification should be displayed in the profile 