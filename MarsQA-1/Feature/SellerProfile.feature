Feature: Seller Profile Feature Operations
	As a Seller
	I want the feature to add, edit my Profile Details
	So that
	The people seeking for some skills can look into my details.



@Regression
Scenario: Add a new seller profile successfully
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on New Profile button
	Then New Profile form opens up
	When I enter following details in the form and click save button
	| username | password | title | job | profileName |
	| wow      | wow1     | QA    | FT  | hello1      |
	Then Details Saved message appears
	And The new created profiles shows up in the grid with profile name <profileName>

@Regression
Scenario: Add multiple(2) seller seller profiles successfully
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I enter following details in the form and click save button
	| username | password | title | job | profileName |
	| wow      | wow1     | QA    | FT  | hello1      |
	Then Details Saved message appears
	And The new created profiles shows up in the grid with profile name <profileName1>
	When I Click on New Profile button
	Then New Profile form opens up
	When I enter following details in the form and click save button
	| username | password | title | job | profileName2 |
	| wow      | wow12    | QA    | FT  | hello2     |
	Then Details Saved message appears
	Then The new created profiles shows up in the grid with profile name <profileName2>
	
@Regression
Scenario: Edit a seller profile successfully
	Given I login to the website with <usename> and <password>
	When I Select the profile <profileName>
	And I edit following details in the form and click save button
	| username | password | title | job | profileName |
	| wow      | wow1     | QA    | FT  | hello1      |
	Then Details Saved message appears
	Then The new created profiles shows up in the grid with profile name <profileName>

@Regression
Scenario: Delete a seller profile successfully
	Given I login to the website with <usename> and <password>
	When I Select the profile <profileName>
	And Click Delete button
	Then Profile deleted message appears
	Then The <profileName> profile does not appear on the grid.

@Regression
Scenario: Search and view an existing seller profile successfully
	Given I login to the website with <usename> and <password>
	When I Select the profile <profileName>
	And Click view button
	Then Selected profile opens up on the page
	Then I am able to validate all critical profile details successfully
	| title | job |
	| QA    | FT  |
