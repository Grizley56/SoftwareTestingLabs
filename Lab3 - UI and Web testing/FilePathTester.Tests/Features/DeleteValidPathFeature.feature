Feature: DeleteValidPathFeature

@mytag
Scenario: Delete valid path
	Given I have entered "E:/dir" into the text box
	When I press Add
	When I select "E:/dir" entry from left list box
	When I press Delete button under Valid list box
	Then the left list box should not contain "E:/dir"
