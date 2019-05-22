Feature: MoveBackInvalidPathEmptyFeature

@mytag
Scenario: move invalid path back with no selection
	When I reset selection from right list box
	And I Press move back button
	Then message box with text "Вы не выбрали строку для повторной проверки!" have to appear on the screen