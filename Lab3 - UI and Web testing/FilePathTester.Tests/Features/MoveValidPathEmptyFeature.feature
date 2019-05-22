Feature: MoveValidPathEmptyFeature

@mytag
Scenario: move valid path with empty selection
	When I reset selection from left list box
	And I press move button
	Then message box with text "Вы не выбрали строку для повторной проверки!" have to appear on the screen