Feature: TmFeature1

A short summary of the feature

@regression

Scenario: create time record with  valid data
    Given I logged into turnup portal  successfully
	When I navigate to time and material  page
	When I create a time record
	Then the record should be created successfully]
	
Scenario Outline: edit existing time record with valid data
	Given I logged into turnup portal  successfully
	When I navigate to time and material  page
	When I update the '<code>' and '<Description>'on an existing Time record
	Then The record should  be updated '<code>' and '<Description>'
	Examples: 
	| code             | Description |
	| Industry connect | Laptop      |
	| TA job ready     | Mouse       |
	| Edit Record      | Keyboard    |
	
	