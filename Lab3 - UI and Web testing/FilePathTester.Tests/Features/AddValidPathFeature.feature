Feature: AddValidPathFeature

@mytag
Scenario: Add valid path
	Given I have entered "C:\Windows" into the text box
	When I press Add
	Then the entry "C:\Windows" should be in the right list view