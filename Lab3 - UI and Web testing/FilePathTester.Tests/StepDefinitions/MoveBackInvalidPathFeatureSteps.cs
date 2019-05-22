using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class MoveBackInvalidPathFeatureSteps
	{
		[When(@"I Press move back button")]
		public void WhenIPressMoveBackButton()
		{
			PathTesterWindow.Instance.MoveBackInvalidPathButton.Click();
		}

		[Then(@"the entry ""(.*)"" should add to left list box")]
		public void ThenTheEntryShouldAddToLeftListBox(string p0)
		{
			CollectionAssert.Contains(PathTesterWindow.Instance.ValidPath, p0);
		}

		[Then(@"right list box should not exist ""(.*)"" entry")]
		public void ThenRightListBoxShouldNotExistEntry(string p0)
		{
			CollectionAssert.DoesNotContain(PathTesterWindow.Instance.InvalidPath, p0);
		}

		[Then(@"text box should fill with ""(.*)"" text")]
		public void ThenTextBoxShouldFillWithText(string p0)
		{
			Assert.AreEqual(PathTesterWindow.Instance.InputTextBox.Text, p0);
		}


	}
}
