Feature: Skills tab
	In order to update my profile
	As a skill trader
	I want to add, edit and delete skills

@manual
Scenario: Check if user is able to add new skill
	Given I am on the Skills tab
	When I add new skill and level
	And I clicked on Add New button
	Then new skill and level should display on my listing
	

@manual
Scenario: Check if user is able to edit selected skill
Given The skill is alrady exist
When I click on edit icon and edit selected skill
Then the edited skill should display on my listings

@manual
Scenario: Check if user is able to delete the skill
Given The skill is alrady exist
When I click on delete icon and delete selected skill
Then the deleted skill should not display on my listings

@manual
Scenario: Check if user is able to add duplicate skill
Given The skill is already in my list
When I try to add the same skill
Then The alert message "Duplicate data" should display
And Skill does not entered

@manual
Scenario: Check if user is able to add skill without entering the value in skill field
Given I am on the Skills tab 
When I clicked on Add New button 
And I select the skill level
But I did not enter skill
Then The alert message "Please enter skill and experience level" should display
And New skill does not entered

@manual
Scenario: Check if user is able to add skill without selecting the skill level
Given I am on the Skills tab 
When I clicked on Add New button 
And I entered the new skill
But I did not select the skill level
Then The alert message "Please enter skill and experience level" should display 
And New skill does not entered

@manual
Scenario: Check if user is able to add skill without entering the value in skill field and selecting skill level 
Given I am on the Skills tab 
When I clicked on Add New button 
And I did not enter skill and select the skill level
Then The alert message "Please enter skill and experience level" should display
And New skill does not entered