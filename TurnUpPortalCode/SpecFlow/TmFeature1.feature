Feature: TmFeature1

A short summary of the feature

@regression

Scenario: Given I logged into turnup portal  successfully
	When I navigate to time and material  page
	When I create a time record
	Then the record should be created successfully]
	