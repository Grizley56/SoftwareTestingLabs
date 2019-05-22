using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebTests.Pages
{
	public class WikiPage
	{
		private IWebDriver _driver;

		private const string SearchInputId = "searchInput";
		private const string SearchButtonId = "searchButton";
		private const string LanguagesClass = "interlanguage-link-target";

		[FindsBy(How = How.Id, Using = SearchInputId)]
		public IWebElement SearchInput { get; private set; }


		[FindsBy(How = How.Id, Using = SearchButtonId)]
		public IWebElement SearchButton { get; private set; }


		[FindsBy(How = How.ClassName, Using = LanguagesClass)]
		public IList<IWebElement> Languages { get; private set; }

		public WikiPage(IWebDriver driver)
		{
			_driver = driver;
			Init();
		}

		public void Init()
		{
			PageFactory.InitElements(_driver, this);
		}
	}
}
