using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestStack.White.UIItems;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class AddValidPathFeatureSteps
	{

		[Given(@"I have entered ""(.*)"" into the text box")]
		public void GivenIHaveEnteredIntoTheTextBox(string p0)
		{
			PathTesterWindow.Instance.InputTextBox.Text = p0;
		}

		[When(@"I press Add")]
		public void WhenIPressAdd()
		{
			PathTesterWindow.Instance.AddPathButton.Click();
		}

		[Then(@"the entry ""(.*)"" should be in the right list view")]
		public void ThenTheEntryShouldBeInTheRightListView(string p0)
		{
			Assert.That(PathTesterWindow.Instance.ValidPath.Contains(p0));
		}

	}
}
