using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class AddEmptyPathFeatureSteps
	{
		[Then(@"message box with text ""(.*)"" have to appear on the screen")]
		public void ThenMessageBoxWithTextHaveToAppearOnTheScreen(string p0)
		{
			Window messageBox = null;

			Assert.DoesNotThrow(() =>
			{
				messageBox = PathTesterWindow.Instance.Window.MessageBox("");
			});

			var label = messageBox.Get<Label>(SearchCriteria.Indexed(0));
			Assert.AreEqual(p0, label.Text);
			messageBox.Close();
		}
	}
}
