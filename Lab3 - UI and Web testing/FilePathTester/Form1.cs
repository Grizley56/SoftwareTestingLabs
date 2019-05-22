using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePathTester
{
	public partial class FilePathTesterForm : Form
	{
		public FilePathTesterForm()
		{
			InitializeComponent();
		}

		private void ConfirmButtonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(pathTextBox.Text))
			{
				MessageBox.Show("Пустая строка!");
				return;
			}

			string path = pathTextBox.Text;

			if (PathHelper.IsValidPath(path))
			{
				validPathLv.Items.Add(path);
			}
			else
			{
				invalidPathLv.Items.Add(path);
			}

			pathTextBox.Text = string.Empty;
		}

		private void ValidLvRemove(object sender, EventArgs e)
		{
			if (validPathLv.SelectedItem == null)
			{
				MessageBox.Show("Вы не выбрали строку для повторной проверки!");
				return;
			}

			validPathLv.Items.Remove(validPathLv.SelectedItem);
		}

		private void ValidLvMove(object sender, EventArgs e)
		{
			if (validPathLv.SelectedItem == null)
			{
				MessageBox.Show("Вы не выбрали строку для повторной проверки!");
				return;
			}

			var selectedItem = validPathLv.SelectedItem;
			validPathLv.Items.Remove(selectedItem);
			invalidPathLv.Items.Add(selectedItem);
		}

		private void InvalidLvRemove(object sender, EventArgs e)
		{
			if (invalidPathLv.SelectedItem == null)
			{
				MessageBox.Show("Вы не выбрали строку для повторной проверки!");
				return;
			}

			invalidPathLv.Items.Remove(invalidPathLv.SelectedItem);
		}

		private void InvalidLvReturn(object sender, EventArgs e)
		{
			if (invalidPathLv.SelectedItem == null)
			{
				MessageBox.Show("Вы не выбрали строку для повторной проверки!");
				return;
			}

			var selectedItem = invalidPathLv.SelectedItem;

			invalidPathLv.Items.Remove(selectedItem);
			pathTextBox.Text = (string)selectedItem;
		}
	}
}
