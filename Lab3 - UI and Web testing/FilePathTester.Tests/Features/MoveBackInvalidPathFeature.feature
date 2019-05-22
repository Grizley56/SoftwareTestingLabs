Feature: MoveBackInvalidPathFeature


@mytag
Scenario: Move back invalid path
	Given I have entered "--invalid-path" into the text box
	When I press Add
	When I select "--invalid-path" entry from right list box
	And I Press move back button
	Then right list box should not exist "--invalid-path" entry
	And text box should fill with "--invalid-path" text
