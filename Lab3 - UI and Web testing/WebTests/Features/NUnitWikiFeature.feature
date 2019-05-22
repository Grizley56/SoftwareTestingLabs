Feature: NUnitWikiFeature


@mytag
Scenario: Check is there russian language in the 'Nunit' thread
	When I Open Internet Browser 
	And Open "https://www.google.com" page
	Then Google startup page should open
	When I enter "unit testing" in request string
	And Click to button named "Google Search"
	Then Page with result set should open
	And Page should contains link to en.wiki thread
	When I open en.wiki thread
	And Enter "NUnit" to search bar
	And Click search button
	Then The page with url "https://en.wikipedia.org/wiki/NUnit" should open
	And Page should contains link for "Русский" language of the thread