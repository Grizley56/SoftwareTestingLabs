Feature: MoveValidPathFeature

@mytag
Scenario: Move valid path to invalid
	Given I have entered "C:\test\123" into the text box
	When I press Add
	When I select "C:\test\123" entry from left list box
	And I press move button
	Then the entry "C:\test\123" should add to right list box
	And left list box should not exist "C:\test\123" entry