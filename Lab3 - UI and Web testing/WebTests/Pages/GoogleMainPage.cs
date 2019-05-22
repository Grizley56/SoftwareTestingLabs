using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebTests.Pages
{
	public class GoogleMainPage
	{
		public const string Uri = "https://www.google.com/";

		private const string SearchFieldName = "q";
		private const string SearchButtonXpath = "(//input[@name='btnK'])[2]";

		[FindsBy(How = How.Name, Using = SearchFieldName)]
		public IWebElement InputField { get; private set; }

		[FindsBy(How = How.XPath, Using = SearchButtonXpath)]
		public IWebElement SearchButton { get; private set; }

		private readonly IWebDriver _driver;

		public GoogleMainPage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(driver, this);
		}

		public void Navigate()
		{
			_driver.Navigate().GoToUrl(Uri);
		}
	}
}
