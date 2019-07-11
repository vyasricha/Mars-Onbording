Feature: Certifications tab
	In order to update my profile
	As a skill trader
	I want to add, edit and delete my cetificate information

@manual
Scenario: Check if user is able to add new certificate deatil
	Given I am on the Certifications tab
	When I add new value in certificate or Award, certificate Formate and Year fields
	And I clicked on Add New button
	Then new certificate detail should display on my listing
	

@manual
Scenario: Check if user is able to edit selected certificate deatil
Given The certificate deatil is alrady exist
When I click on edit icon and edit selected certificate deatil
Then the edited certificate deatil should display on my listings

@manual
Scenario: Check if user is able to delete certificate deatil
Given The certificate deatil is alrady exist
When I click on delete icon and delete selected certificate deatil
Then the deleted certificate deatil should not display on my listings

@manual
Scenario: Check if user is able to add duplicate certificate deatil
Given The certificate deatil is already in my list
When I try to add the same certificate deatil
Then The alert message "Duplicate data" should display
And certificate deatil does not entered

@manual
Scenario: Check if user is able to add certificate details without filling all the fields
Given I am on the Certifications tab 
When I clicked on Add New button 
And I did not enter any value in any field
Then The alert message "Please enter Certificate Name,Cetificate form and Certificate Year" should display
And education deatil does not entered