Feature: Education tab
	In order to update my profile
	As a skill trader
	I want to add, edit and delete my education information

@manual
Scenario: Check if user is able to add new education deatil
	Given I am on the Education tab
	When I add new value in College/University name, Country of university/College, Title, Degree and year of graduation fields
	And I clicked on Add New button
	Then new education deatil should display on my listing
	

@manual
Scenario: Check if user is able to edit selected education deatil
Given The education deatil is alrady exist
When I click on edit icon and edit selected education deatil
Then the edited education deatil should display on my listings

@manual
Scenario: Check if user is able to delete education deatil
Given The education deatil is alrady exist
When I click on delete icon and delete selected education deatil
Then the deleted education deatil should not display on my listings

@manual
Scenario: Check if user is able to add duplicate education deatil
Given The education deatil is already in my list
When I try to add the same education deatil
Then The alert message "Duplicate data" should display
And education deatil does not entered

@manual
Scenario: Check if user is able to add eduction detail without filling all the fields
Given I am on the Education tab 
When I clicked on Add New button 
And I did not enter any value in any field
Then The alert message "Please enter all the fields" should display
And education deatil does not entered