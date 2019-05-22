Feature: AddInvalidPathFeature

@mytag
Scenario: Add invalid path
	Given I have entered "C:lgk\\d.bk||$" into the text box
	When I press Add
	Then the entry "C:lgk\\d.bk||$" should be in the left list view