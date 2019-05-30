Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings
	
Scenario: Check if the user could able to edit the existing language
Given I click on language tab on profile page
When I click the edit  button for existing language
And I enter the new language 
And click on  the update button
Then edited language level should be displayed on language tab

Scenario: Check if the user could able to delete existing language
Given I click on language tab under profile page 
When I click  on the delete button under 
Then deleted language should be  remove from languages listing


Scenario Outline:Check if the user could able to add more than four languagaes
Given I am on  profile page and i click on the language tab
When I add  four languages with <Language> and <Level>
Then that <Language> should be dispalyed on my listing

Examples: 
| Language | Level          |
| French   | Basic          |
| English  | Fluent         |
| Chinese  | Conversational |
| Italian  | Basic          |








Scenario: Check if user could able to add language already exists with different level
Given I Clicked on language tab under profile page 
When I add a language that already exists with different level
Then it should display be an error message 

Scenario:Check if the user could able to add language already exists with same level
Given I click on the language tab on profile  page
When I add a language that already exists with same level
Then It should display an error message 

Scenario: Add a language if there are already four languages existing
Given I click on language tab under the profile page
When I try to add fifth language 
Then it should not be added in the list
