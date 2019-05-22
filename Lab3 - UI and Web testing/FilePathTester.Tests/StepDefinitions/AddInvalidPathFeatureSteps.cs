using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FilePathTester.Tests.StepDefinitions
{
	[Binding]
	public class AddInvalidPathFeatureSteps
	{
		[Then(@"the entry ""(.*)"" should be in the left list view")]
		public void ThenTheEntryShouldBeInTheLeftListView(string p0)
		{
			Assert.That(PathTesterWindow.Instance.InvalidPath.Contains<string>(p0));
		}
	}
}
