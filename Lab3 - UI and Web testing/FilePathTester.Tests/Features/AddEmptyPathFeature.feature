Feature: AddEmptyPathFeature

@mytag2
Scenario: Add empty path
	Given I have entered "" into the text box
	When I press Add
	Then message box with text "Пустая строка!" have to appear on the screen
