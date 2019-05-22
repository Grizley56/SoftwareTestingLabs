using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class MoveValidPathFeatureSteps
	{
		[When(@"I select ""(.*)"" entry from left list box")]
		public void WhenISelectEntryFromLeftListBox(string p0)
		{
			PathTesterWindow.Instance.ValidPathLv.Select(p0);
		}

		[When(@"I press move button")]
		public void WhenIClickMove()
		{
			PathTesterWindow.Instance.MoveValidPathButton.Click();
		}

		[Then(@"the entry ""(.*)"" should add to right list box")]
		public void ThenTheEntryShouldAddToRightListBox(string p0)
		{
			CollectionAssert.Contains(PathTesterWindow.Instance.InvalidPath, p0);
		}

		[Then(@"left list box should not exist ""(.*)"" entry")]
		public void ThenLeftListBoxShouldNotExistEntry(string p0)
		{
			CollectionAssert.DoesNotContain(PathTesterWindow.Instance.ValidPath, p0);
		}
	}
}
