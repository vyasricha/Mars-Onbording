Feature: Languages tab
	In order to update my profile
	As a skill trader
	I want to add, edit and delete language

@autoamte
Scenario: Check if user is able to add new language
Given I am on the Languages tab
When I click on Add New Button and I add new language and level
Then new language and level should display on my listing
	
@automate
Scenario: Check if user is able to edit selected language
Given The language is alrady exist
When I click on edit icon and edit selected language
Then the edited language should display on my listings

@automate
Scenario: Check if user is able to delete the language
Given The language is alrady exist
When I click on delete icon and delete selected language
Then the deleted language should not display on my listings

@manual
Scenario: Check if user is able to add more than four languages
Given I have four languages in my list
When I try to add fiveth language
Then Add New button should not displayed

@manual
Scenario: Check if user is able to add duplicate language
Given The language is already in my list
When I try to add the same language
Then The alert message "Duplicate data" should display
And Language does not entered

@manual
Scenario: Check if user is able to add language without entering the value in language field
Given I am on the Languages tab 
When I clicked on Add New button 
And I select the language level
But I did not enter language
Then The alert message "Please enter language and level" should display 
And New language does not entered

@manual
Scenario: Check if user is able to add language without selecting the language level
Given I am on the Languages tab 
When I clicked on Add New button 
And I entered the new language
But I did not select the language level
Then The alert message "Please enter language and level" should display 
And New language does not entered

@manual
Scenario: Check if user is able to add language without entering value in language field and selecting the language level
Given I am on the Languages tab 
When I clicked on Add New button 
And I did not entered the new language and select the language level
Then The alert message "Please enter language and level" should display 
And language does not entered