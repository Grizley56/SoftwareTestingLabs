using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class DeleteInvalidPathFeatureSteps
	{
		[When(@"I select ""(.*)"" entry from right list box")]
		public void WhenISelectEntryFromRightListBox(string p0)
		{
			PathTesterWindow.Instance.InvalidPathLv.Select(p0);
		}

		[When(@"I press Delete button under Invalid list box")]
		public void WhenIPressDeleteButtonUnderInvalidListBox()
		{
			PathTesterWindow.Instance.RemoveInvalidPathButton.Click();
		}

		[Then(@"the right text box should not contain ""(.*)""")]
		public void ThenTheRightTextBoxShouldNotContain(string p0)
		{
			CollectionAssert.DoesNotContain(PathTesterWindow.Instance.InvalidPath, p0);
		}
	}
}
