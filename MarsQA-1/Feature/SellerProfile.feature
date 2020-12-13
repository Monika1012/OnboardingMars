Feature: Seller Profile Feature Operations
	As a Seller
	I want the feature to add, edit my Profile Details
	So that
	The people seeking for some skills can look into my details.


	## Below 3 scenarios are automated
@Regression
Scenario: Add New Language
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <language> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| language | proficiency |
	| english  | native      |

@Regression
Scenario: Add and Edit Language
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <language> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| language | proficiency |
	| english  | native      |
	When I click on Edit Icon
	And Update below fields and Click Update
	| Language  |
	| french |
	Then Existing row updates with values
	| language | proficiency |
	| french  | native      |

	@Regression
Scenario: Add and Delete Language
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <language> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| language | proficiency |
	| english  | native      |
	When I click on Delete Icon
	Then Row is deleted
	
	## Below scenarios are not automated. They are part of Task 1.
@Regression
Scenario: Add New Skill
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <skill> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| skill | proficiency |
	| c#  | expert      |

@Regression
Scenario: Add and Edit Skill
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <skill> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| skill | proficiency |
	| c#  | expert      |
	When I click on Edit Icon
	And Update below fields and Click Update
	| Language  |
	| javascript |
	Then Existing row updates with values
	| skill | proficiency |
	| javascript  | expert      |

	@Regression
Scenario: Add and Delete Skill
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <skill> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| skill | proficiency |
	| c#  | expert      |
	When I click on Delete Icon
	Then Row is deleted


	@Regression
Scenario: Add New Education
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      | BCOM  | Software | 2003 |
	Then New Row is added in the grid and I can Validate values
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      | BCOM  | Software | 2003 |

@Regression
Scenario: Add and Edit Education
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      |B.TECH  | Software | 2003 |
	Then New Row is added in the grid and I can Validate values
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      | B.TECH  | Software | 2003 |
	When I click on Edit Icon
	And Update below fields and Click Update
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      |B.TECH  | Software | 2010 |
	Then Existing Row is added in the grid and I can Validate values
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      | B.TECH  | Software | 2010 |

	@Regression
Scenario: Add and Delete Education
Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      |B.TECH  | Software | 2003 |
	Then New Row is added in the grid and I can Validate values
	| collegeName | country | title | degree   | year |
	| AUT         | NZ      | B.TECH  | Software | 2003 |
	When I click on Delete Icon
	Then Row is deleted

	@Regression
Scenario: Add New Certification
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| certificateName | from | date |
	| ISTQB Foundation         | ANZTB      |2017  |
	Then New Row is added in the grid and I can Validate values
	| certificateName | from | date |
	| ISTQB Foundation | ANZTB |2017  |

@Regression
Scenario: Add and Edit Certification
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| certificateName | from | date |
	| ISTQB Foundation         | ANZTB      |2017  |
	Then New Row is added in the grid and I can Validate values
	| certificateName | from | date |
	| ISTQB Foundation | ANZTB |2017  |
	When I click on Edit Icon
	And Update below fields and Click Update
	| certificateName | from | date |
	| ISTQB Foundation         | ANZTB      |2020  |
	Then Existing row updates with values
	| certificateName | from | date |
	| ISTQB Foundation         | ANZTB      |2020  |

	@Regression
Scenario: Add and Delete Certification
	Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter following details and Click on Add Button
	| certificateName | from | date |
	| ISTQB Foundation         | ANZTB      |2017  |
	Then New Row is added in the grid and I can Validate values
	| certificateName | from | date |
	| ISTQB Foundation | ANZTB |2017  |
	When I click on Delete Icon
	Then Row is deleted

@Regression
Scenario: Add multiple(2) languages successfully
Given I login to the website with <usename> and <password>
	And Ensure the profile page loads
	When I Click on the Tab <tabName>
	And Click on Add New Button
	Then A New Row Editable Row is added on the Grid
	When I Enter <language> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| language | proficiency |
	| english  | native      |

	And Click on Add New Button
	When I Enter <language> and Select <proficiencyLevel> and Click on Add Button
	Then New Row is added in the grid and I can Validate values
	| language | proficiency |
	| english  | native      |
	

	