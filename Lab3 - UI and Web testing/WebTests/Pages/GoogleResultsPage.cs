using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebTests.Pages
{
	public class GoogleResultsPage
	{
		private IWebDriver _driver;

		private const string ResultStatsId = "resultStats";
		private const string ResultSetClass = "iUh30";

		[FindsBy(How = How.Id, Using = ResultStatsId)]
		public IWebElement ResultStats { get; private set; }

		[FindsBy(How = How.ClassName, Using = ResultSetClass)]
		public IList<IWebElement> Results { get; private set; }

		public GoogleResultsPage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(driver, this);
		}
	}
}
