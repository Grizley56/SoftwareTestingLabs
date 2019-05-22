Feature: DeleteInvalidPathFeature

@mytag
Scenario: Delete invalid path
	Given I have entered "_|\\ss\\dd" into the text box
	When I press Add
	When I select "_|\\ss\\dd" entry from right list box
	When I press Delete button under Invalid list box
	Then the right text box should not contain "_|\\ss\\dd"

