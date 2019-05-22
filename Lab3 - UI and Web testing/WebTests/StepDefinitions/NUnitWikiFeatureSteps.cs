using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebTests.Pages;

namespace WebTests.StepDefinitions
{
	[Binding]
	public class NUnitWikiFeatureSteps
	{
		private TestContext _context;

		[Before]
		public void Init()
		{
			_context = new TestContext(new ChromeDriver());
		}


		[When(@"I Open Internet Browser")]
		public void WhenIOpenInternetBrowser()
		{
			_context.Driver.Manage().Window.Maximize();
		}

		[When(@"Open ""(.*)"" page")]
		public void WhenOpenPage(string p0)
		{
			_context.MainPage.Navigate();
		}

		[Then(@"Google startup page should open")]
		public void ThenGoogleStartupPageShouldOpen()
		{
			Assert.That(_context.Driver.Url, Is.EqualTo(GoogleMainPage.Uri));
		}

		[When(@"I enter ""(.*)"" in request string")]
		public void WhenIEnterInRequestString(string p0)
		{
			_context.MainPage.InputField.Click();
			_context.MainPage.InputField.SendKeys(p0);
		}

		[When(@"Click to button named ""(.*)""")]
		public void WhenClickToButtonNamed(string p0)
		{
			_context.MainPage.SearchButton.Click();
		}

		
		[Then(@"Page with result set should open")]
		public void ThenPageWithResultSetShouldOpen()
		{
			Assert.NotNull(_context.ResultsPage.ResultStats);
		}

		[Then(@"Page should contains link to en\.wiki thread")]
		public void ThenPageShouldContainsLinkToEn_WikiThread()
		{
			Assert.That(() =>
			{
				return 
					_context.ResultsPage.Results
						.FirstOrDefault(i => i.Text.StartsWith("https://en.wikipedia.org/")) != null;
			});
		}

		
		[When(@"I open en\.wiki thread")]
		public void WhenIOpenEn_WikiThread()
		{
			_context.ResultsPage.Results
				.FirstOrDefault(i => i.Text.StartsWith("https://en.wikipedia.org/"))?.Click();
		}

		[When(@"Enter ""(.*)"" to search bar")]
		public void WhenEnterToSearchBar(string p0)
		{
			_context.WikiPage.SearchInput.Click();
			_context.WikiPage.SearchInput.SendKeys(p0);
		}

		[When(@"Click search button")]
		public void WhenClickSearchButton()
		{
			_context.WikiPage.SearchButton.Click();
		}

		[Then(@"The page with url ""(.*)"" should open")]
		public void ThenThePageWithUrlShouldOpen(string p0)
		{
			Assert.AreEqual(p0, _context.Driver.Url);
		}

		[Then(@"Page should contains link for ""(.*)"" language of the thread")]
		public void ThenPageShouldContainsLinkForLanguageOfTheThread(string p0)
		{
			Assert.That(() =>
			{
				return
					_context.WikiPage.Languages
						.FirstOrDefault(i => i.Text.Equals(p0, StringComparison.OrdinalIgnoreCase)) != null;
			});
		}
	}
}
