using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace FilePathTester.Tests
{
	public class PathTesterWindow: IDisposable
	{
		public ListBox ValidPathLv { get; private set; }
		public ListBox InvalidPathLv { get; private set; }
		public TextBox InputTextBox { get; private set; }
		public Button AddPathButton { get; private set; }
		public Button RemoveValidPathButton { get; private set; }
		public Button RemoveInvalidPathButton { get; private set; }
		public Button MoveValidPathButton { get; private set; }
		public Button MoveBackInvalidPathButton { get; private set; }

		private Application _app;
		public Window Window { get; }

		private static PathTesterWindow _instance;

		public static PathTesterWindow Instance
		{
			get
			{
				if (_instance == null)
					_instance = new PathTesterWindow();

				return _instance;
			}
		}

		protected PathTesterWindow()
		{
			var applicationDirectory = TestContext.CurrentContext.TestDirectory;
			var applicationPath = Path.Combine(applicationDirectory, "FilePathTester.exe");

			_app = Application.Launch(applicationPath);
			Window = _app.GetWindow("FilePathTester", InitializeOption.NoCache);

			Init();
		}

		private void Init()
		{
			ValidPathLv = Window.Get<ListBox>("validPathLv");
			InvalidPathLv = Window.Get<ListBox>("invalidPathLv");
			InputTextBox = Window.Get<TextBox>("pathTextBox");
			AddPathButton = Window.Get<Button>("addPathButton");
			RemoveValidPathButton = Window.Get<Button>("deleteValidPathButton");
			RemoveInvalidPathButton = Window.Get<Button>("deleteInvalidPathButton");
			MoveValidPathButton = Window.Get<Button>("moveValidPathButton");
			MoveBackInvalidPathButton = Window.Get<Button>("moveBackInvalidPathButton");
		}

		public void Dispose()
		{
			_app?.Dispose();
			Window?.Dispose();
		}


		public string[] ValidPath
		{
			get { return ValidPathLv.Items.Select(i => i.Text).ToArray(); }
		}

		public string[] InvalidPath
		{
			get { return InvalidPathLv.Items.Select(i => i.Text).ToArray(); }
		}

	}
}
