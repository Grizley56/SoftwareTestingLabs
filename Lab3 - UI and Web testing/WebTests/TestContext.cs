using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebTests.Pages;

namespace WebTests
{
	public class TestContext
	{
		public IWebDriver Driver { get; }

		public GoogleMainPage MainPage { get; set; }
		public GoogleResultsPage ResultsPage { get; set; }
		public WikiPage WikiPage { get; set; }

		public TestContext(IWebDriver driver)
		{
			Driver = driver;
			MainPage = new GoogleMainPage(Driver);
			ResultsPage = new GoogleResultsPage(Driver);
			WikiPage = new WikiPage(Driver);
		}
	}
}
