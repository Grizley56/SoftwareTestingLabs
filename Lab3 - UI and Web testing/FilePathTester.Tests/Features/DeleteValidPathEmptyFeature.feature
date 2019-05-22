Feature: DeleteValidPathEmptyFeature

@mytag
Scenario: Delete valid path empty
	When I reset selection from left list box
	And I press Delete button under Invalid list box
	Then message box with text "Вы не выбрали строку для повторной проверки!" have to appear on the screen
