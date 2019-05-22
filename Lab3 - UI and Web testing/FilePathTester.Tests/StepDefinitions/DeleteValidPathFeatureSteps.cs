using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class DeleteValidPathFeatureSteps
	{
		[When(@"I press Delete button under Valid list box")]
		public void WhenIPressDeleteButtonUnderValidListBox()
		{
			PathTesterWindow.Instance.RemoveValidPathButton.Click();
		}


		[Then(@"the left list box should not contain ""(.*)""")]
		public void ThenTheLeftListBoxShouldNotContain(string p0)
		{
			CollectionAssert.DoesNotContain(PathTesterWindow.Instance.ValidPath, p0);
		}
	}
}
